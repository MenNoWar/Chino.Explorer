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
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
            tvDetails.Nodes.Clear();
            tvSchemas.Nodes.Clear();
        }       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private Api Api = null;
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            var frmConnect = new FormConnectData();
            if (frmConnect.ShowDialog() == DialogResult.OK)
            {
                HostUrl = frmConnect.HostUrl;
                CustomerId = frmConnect.CustomerId;
                CustomerKey = frmConnect.CustomerKey;
                RepositoryId = frmConnect.RepositoryId;

                InitializeApi();
            }
        }

        public string HostUrl { get; set; }
        public string CustomerId { get; set; }
        public string CustomerKey { get; set; }
        public string RepositoryId { get; set; }
        private Dictionary<string, Schema> SchemaList = new Dictionary<string, Schema>();

        private void InitializeApi()
        {
            SchemaList = new Dictionary<string, Schema>();

            if (!string.IsNullOrEmpty(HostUrl) && !string.IsNullOrEmpty(CustomerId) && !string.IsNullOrEmpty(CustomerKey))
            {
                Api = new Api(HostUrl, CustomerId, CustomerKey);
            }
            else
            {
                Api = null;
                return;
            }

            tvSchemas.Nodes.Clear();
            tvDetails.Nodes.Clear();

            var listResult = Api.Schemas.List(RepositoryId, 0, 100);
            foreach (var schema in listResult.Schemas)
            {
                SchemaList.Add(schema.Id, schema);
                var tn = new TreeNode(schema.Description);
                tn.Tag = schema;
                tvSchemas.Nodes.Add(tn);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InitializeApi();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CreateDataViewWindow();
        }

        void CreateDataViewWindow()
        {
            if (tvSchemas.SelectedNode == null) return;
            var schema = tvSchemas.SelectedNode.Tag as Schema;
            if (schema == null) return;

            foreach (var form in this.MdiChildren)
            {
                var frm = (FormDataView)form;
                if (frm.CurrentSchema.Id == schema.Id)
                {
                    frm.Visible = true;
                    frm.BringToFront();

                    return;
                }                
            }

            var f = new FormDataView(schema, Api);
            f.MdiParent = this;
            f.Visible = true;
        }        

        private void tvSchemas_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CreateDataViewWindow();
        }

        private void tvSchemas_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            tvDetails.Nodes.Clear();
            if (e.Node == null || e.Node.Tag == null) return;

            var schema = e.Node.Tag as Schema;
            foreach (var f in schema.Fields)
            {
                var tn = tvDetails.Nodes.Add(string.Format("{0} [{1}]", f.Name, f.Type));
                tn.ImageIndex = f.IsIndexed ? 1 : 2;
                tn.SelectedImageIndex = tn.ImageIndex;
            }
        }

        private void changeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormConnectData();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                InitializeApi();
            }
        }
    }
}
