using Chino.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinoExplorer
{
    public partial class FormDataView : Form
    {
        public FormDataView()
        {
            InitializeComponent();
        }

        private Api Api = null;

        public FormDataView(Schema schema, Api api) : this()
        {
            this.Api = api;
            CreateSchemaDisplay(schema);
            this.Text = schema.Description;
        }

        public Schema CurrentSchema { get; private set; }
        private int CurrentStart = 0;

        private DataRow RowFromIndex(int rowIndex)
        {
            DataGridViewRow gridrow = chinoData.Rows[rowIndex];
            if (gridrow == null) return null;
            DataRowView rowview = (DataRowView)gridrow.DataBoundItem;
            if (rowview == null) return null;
            DataRow row = rowview.Row;

            return row;
        }

        private void CreateSchemaDisplay(Schema schema)
        {
            var dt = new DataTable();
            dt.BeginInit();

            var idColumn = dt.Columns.Add("Id", typeof(string));

            dt.Columns.Add("IsActive", typeof(bool));

            foreach (var fd in schema.Fields)
            {
                if (fd.Type == SchemaFieldType.blob)
                {
                    // dt.Columns.Add(fd.Name, typeof(string));
                }
                else
                {
                    var newCol = dt.Columns.Add(fd.Name, fd.ClrType);
                    if (fd.Type == SchemaFieldType.boolean)
                    {
                        newCol.DefaultValue = false;
                    }
                }
            }

            dt.AcceptChanges();
            dt.EndInit();

            chinoData.DataSource = dt;
            CurrentSchema = schema;
            CurrentStart = 0;
            GetData(schema.Id);            
        }
        
        private void GetData(string schemaId)
        {
            if (CurrentSchema == null) return;
            var currentTable = (DataTable)chinoData.DataSource;
            var listResult = Api.Documents.List(CurrentStart, 25, CurrentSchema.Id, true);
            CurrentStart += listResult.Count;
            currentTable.BeginLoadData();

            foreach (Document doc in listResult.Documents)
            {
                var dr = currentTable.Rows.Add();
                dr["Id"] = doc.Id;
                dr["IsActive"] = doc.IsActive;

                foreach (var prop in doc.Content)
                {
                    // var idx = dr.Table.Columns.IndexOf(prop.Key);
                    var field = CurrentSchema.Fields.FirstOrDefault(o => o.Name == prop.Key);
                    // if (field.ClrType != typeof(byte[]))
                    {
                        if (dr.Table.Columns.Contains(prop.Key))
                        {
                            var val = prop.Value;
                            dr[prop.Key] = val ?? DBNull.Value;
                        }
                    }
                }
            }

            currentTable.AcceptChanges();
            currentTable.EndLoadData();
        }

        private Document DataRowToDocument(DataRow row)
        {
            if (row == null) return null;
            var documentId = row["Id"] == DBNull.Value ? "" : (string)row["Id"];
            var docOrig = row.RowState == DataRowState.Added ? new Document() : Api.Documents.Get(documentId);

            var doc = new Document { Id = docOrig.Id };

            foreach (DataColumn col in row.Table.Columns)
            {
                var fd = CurrentSchema.Fields.FirstOrDefault(o => o.Name == col.ColumnName);
                if (fd != null && fd.Type != SchemaFieldType.blob)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        doc.Content.Add(col.ColumnName, row[col.ColumnName]);
                    }
                    else
                    {
                        if (docOrig.Content.ContainsKey(col.ColumnName))
                        {
                            doc.Content[col.ColumnName] = row[col.ColumnName];
                        }
                    }
                }
            }

            doc.IsActive = row.RowState == DataRowState.Added ? true : (bool)row["IsActive"];

            return doc;
        }

        private void ValidateDataRow(DataRow row)
        {
            if (row == null) return;
            foreach (var f in CurrentSchema.Fields)
            {
                if (f.IsIndexed)
                {
                    var val = row[f.Name];
                    if (val == DBNull.Value)
                    {
                        throw new Exception("Field " + f.Name + " is indexed and should not be null");
                    }
                }
            }
        }

        private void chinoData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var id = (string)e.Row.Cells["Id"].Value;
            if (MessageBox.Show("Really delete the selected row?", "Confirm", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Api.Documents.Delete(id);
            }
        }

        private void chinoData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            foreach (var f in CurrentSchema.Fields)
            {
                if (f.Type == SchemaFieldType.boolean)
                {
                    var val = e.Row.Cells[f.Name].Value;
                    if (val == null)
                    {
                        e.Row.Cells[f.Name].Value = false;
                    }
                }
            }
        }

        private void chinoData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataRow row = RowFromIndex(e.RowIndex);
            // var id = (string)row["Id"];
            if (row == null) return;
            if (row.RowState != DataRowState.Unchanged)
            {
                switch (row.RowState)
                {
                    case DataRowState.Added:
                        ValidateDataRow(row);
                        var doc = DataRowToDocument(row);
                        var id = Api.Documents.Create(CurrentSchema.Id, doc);
                        row["Id"] = id;
                        row["IsActive"] = true;
                        // MessageBox.Show("Add new");
                        break;
                    case DataRowState.Deleted:
                        // Api.Documents.Create(CurrentSchema.Id, doc);
                        break;
                    case DataRowState.Modified:
                        var doc2 = DataRowToDocument(row);
                        Api.Documents.Update(doc2);
                        break;
                }

                ((DataTable)chinoData.DataSource).AcceptChanges();
            }
        }

        private void chinoData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                var row = RowFromIndex(e.RowIndex);
                if (row == null) return;
                ValidateDataRow(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                e.Cancel = true;
            }
        }
    }
}
