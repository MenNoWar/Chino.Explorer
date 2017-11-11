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
    public partial class CollectionDataWindow : Form
    {
        public Api Api { get; private set; }
        public Collection Collection { get; private set; }
        public CollectionDataWindow()
        {
            InitializeComponent();
        }

        private void UpdateCollectionView()
        {
            Collection = Api.Collections.Get(Collection.Id, true);            
            foreach (var d in Collection.Documents)
            {
                var tn = new TreeNode(d.Id);
                tn.Tag = d;
                treeView1.Nodes.Add(tn);
            }
        }

        public CollectionDataWindow(Api api, Collection collection) : this() {
            this.Api = api;
            this.Collection = collection;
            this.Text = collection.Name;
            UpdateCollectionView();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var doc = (Document)treeView1.SelectedNode.Tag;
            var dt = new DataTable();
            dt.Columns.Add("Key", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            foreach (var prop in doc.Content)
            {
                var row = dt.NewRow();
                row[0] = prop.Key;
                row[1] = Convert.ToString(prop.Value);
                dt.AcceptChanges();
            }

            dt.AcceptChanges();
            dataGridView1.DataSource = dt;
        }
    }
}
