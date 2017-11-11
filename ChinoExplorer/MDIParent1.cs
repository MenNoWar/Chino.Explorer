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

        private string HostUrl { get; set; }
        private string CustomerId { get; set; }
        private string CustomerKey { get; set; }
        private string RepositoryId { get; set; }
        private TreeNode tnSchemas = null;
        private TreeNode tnCollections = null;
        private TreeNode tnUsersRoot = null;

        private Api Api = null;

        private Dictionary<string, Schema> SchemaList = new Dictionary<string, Schema>();

        private Dictionary<string, UserSchema> UserSchemaList = new Dictionary<string, UserSchema>();
        
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
        
        private void ShowConnectionDialog()
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

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ShowConnectionDialog();
        }
        
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

            CreateRootNodes();
            
            var listResult = Api.Schemas.List(RepositoryId, 0, 100);
            foreach (var schema in listResult.Schemas)
            {
                SchemaList.Add(schema.Id, schema);
                var tn = new TreeNode(schema.Description);
                tn.Tag = schema;
                tn.ContextMenuStrip = cmsSchemas;
                // tvSchemas.Nodes.Add(tn);
                tnSchemas.Nodes.Add(tn);
            }


            var collectionResult = Api.Collections.List(false);
            foreach (var collection in collectionResult.Collections)
            {
                var tn = new TreeNode(collection.Name);
                tn.Tag = collection;
                // tvSchemas.Nodes.Add(tn);
                tnCollections.Nodes.Add(tn);
            }

            RefreshUserTree();
        }

        private void RefreshUserTree()
        {
            tnUsersRoot.Nodes.Clear();
            UserSchemaList = new Dictionary<string, UserSchema>();

            var userSchemas = Api.UserSchemas.List();
            var count = userSchemas.Count;

            foreach (var s in userSchemas.Schemas)
            {
                UserSchemaList.Add(s.Id, s);
            }

            while (UserSchemaList.Count < count)
            {
                var tmpList = Api.UserSchemas.List(UserSchemaList.Count, 20);
                foreach (var s in tmpList.Schemas)
                {
                    UserSchemaList.Add(s.Id, s);
                }
            }

            foreach (var kvp in UserSchemaList)
            {
                var schema = kvp.Value;                
                var tsItem = addNewUserToolStripMenuItem.DropDownItems.Add(schema.Description);
                tsItem.Image = Properties.Resources.schema;
                tsItem.Tag = schema;
                tsItem.Click += CreateUserFromSchema_Click;
                var userResult = Api.Users.List(schema.Id);

                var cmUserSchema = new ContextMenuStrip();
                var createUserBySchemaMenuItem = new ToolStripMenuItem("Add new User");
                createUserBySchemaMenuItem.Image = ChinoExplorer.Properties.Resources.if_add_user_3802;
                createUserBySchemaMenuItem.Tag = schema;
                createUserBySchemaMenuItem.Click += CreateUserFromSchema_Click;
                cmUserSchema.Items.Add(createUserBySchemaMenuItem);

                var tnSchema = new TreeNode(schema.Description);
                tnSchema.Tag = schema;
                tnSchema.ImageKey = "schema";
                tnSchema.SelectedImageKey = "schema";
                tnSchema.ContextMenuStrip = cmUserSchema;
                tnUsersRoot.Nodes.Add(tnSchema);

                foreach (User u in userResult.Users)
                {
                    var tn = new TreeNode(u.Name);
                    tn.ImageKey = "user";
                    tn.SelectedImageKey = "user";
                    tn.Tag = u;
                    tn.ContextMenuStrip = cmsUser;
                    tnSchema.Nodes.Add(tn);
                }
            }
        }

        private void CreateUserFromSchema_Click(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(ToolStripMenuItem)) return;
            var tsi = (ToolStripMenuItem)sender;
            if (tsi.Tag == null || tsi.Tag.GetType() != typeof(UserSchema)) return;
            var schema = (UserSchema)tsi.Tag;

            var user = new User
            {
                Attributes = new Dictionary<string, object>(),
                Created = DateTime.Now,
                Id = "",
                IsActive = true,
                Name = "New_User",
                SchemaId = schema.Id
            };

            foreach (var field in schema.Structure.Fields)
            {
                object val = null;
                if (field.Type == SchemaFieldType.integer) val = 0;
                else if (field.Type == SchemaFieldType.date) val = DateTime.Now.Date;
                else if (field.Type == SchemaFieldType.datetime) val = DateTime.Now;
                else if (field.Type == SchemaFieldType.base64) val = string.Empty;
                else if (field.Type == SchemaFieldType.blob) val = string.Empty;
                else if (field.Type == SchemaFieldType.boolean) val = false;
                else if (field.Type == SchemaFieldType.@float) val = 0;
                else if (field.Type == SchemaFieldType.integer) val = 0;
                else if (field.Type == SchemaFieldType.json) val = "{}";
                else if (field.Type == SchemaFieldType.@string) val = string.Empty;
                else if (field.Type == SchemaFieldType.text) val = string.Empty;
                else if (field.Type == SchemaFieldType.time) val = DateTime.Now.TimeOfDay;

                user.Attributes.Add(field.Name, val);                
            }

            GenerateUserDataViewWindow(user, schema);
        }

        private void CreateRootNodes()
        {
            tvSchemas.Nodes.Clear();
            tvDetails.Nodes.Clear();
            
            tnSchemas = CreateParentNode("Schemas");
            tvSchemas.Nodes.Add(tnSchemas);

            tnUsersRoot = CreateParentNode("Users");
            tnUsersRoot.ContextMenuStrip = cmsUserRoot;
            tvSchemas.Nodes.Add(tnUsersRoot);

            tnCollections = CreateParentNode("Collections");
            tvSchemas.Nodes.Add(tnCollections);
        }

        private TreeNode CreateParentNode(string text)
        {
            var treeNode = new TreeNode(text);
            treeNode.ImageKey = "folder_grey";
            treeNode.SelectedImageKey = "folder_red";
            treeNode.StateImageKey = "folder_red_open";
            
            return treeNode;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InitializeApi();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GenerateDataViewWindow();
        }

        private void GenerateCollectionDataViewWindow(Collection collection)
        {
            if (collection == null) return;
            var win = new CollectionDataWindow(Api, collection);
            win.MdiParent = this;            
            win.Visible = true;
        }

        private void GenerateSchemaDataViewWindow()
        {
            var schema = tvSchemas.SelectedNode.Tag as Schema;
            if (schema == null) return;

            foreach (var form in this.MdiChildren)
            {
                if (typeof(FormDataView) == form.GetType())
                {
                    var frm = (FormDataView)form;
                    if (frm.CurrentSchema.Id == schema.Id)
                    {
                        ShowWindow(frm);
                        return;
                    }
                }
            }

            var f = new FormDataView(schema, Api);
            f.MdiParent = this;
            f.Visible = true;
        }
        
        private void GenerateDataViewWindow()
        {
            if (tvSchemas.SelectedNode == null || tvSchemas.SelectedNode.Tag == null) return;
            if (tvSchemas.SelectedNode.Tag.GetType() == typeof(Schema))
            {
                GenerateSchemaDataViewWindow();
            } else if (tvSchemas.SelectedNode.Tag.GetType() == typeof(Collection))
            {
                GenerateCollectionDataViewWindow(tvSchemas.SelectedNode.Tag as Collection);
            }
            else if (tvSchemas.SelectedNode.Tag.GetType() == typeof(User))
            {
                GenerateUserDataViewWindow(tvSchemas.SelectedNode.Tag as User);
            }
        }        

        private void ShowWindow(Form form)
        {
            form.Visible = true;
            form.BringToFront();
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void GenerateUserDataViewWindow(User user, UserSchema schema = null)
        {
            // var schema = UserSchemaList[user.SchemaId];
            foreach (var child in this.MdiChildren)
            {
                if (child.GetType() == typeof(UserDataWindow))
                {
                    var userWin = (UserDataWindow)child;
                    if (userWin.User != null && userWin.User.Id == user.Id)
                    {
                        ShowWindow(userWin);
                        return;
                    }
                }
            }

            var win = new UserDataWindow(Api, user, schema);
            win.MdiParent = this;
            win.Visible = true;

            win.OnUserUpdated += (obj, usr, method) =>
            {
                if (method == UserDataWindow.UserUpdateMethod.Create)
                {
                    // just reload all the users, when a new user is added
                    this.RefreshUserTree();
                }

                // find the corrosponding TreeNode for the UserSchema and the User
                var schemaNodes = from node in tnUsersRoot.Nodes.Cast<TreeNode>()
                                  where
                                        node.Tag != null && node.Tag.GetType() == typeof(UserSchema) &&
                                        ((UserSchema)node.Tag).Id == user.SchemaId
                                  select node;

                // this is the node where the schema is displayed
                var schemaNode = schemaNodes.FirstOrDefault();

                if (schemaNode != null)
                {                    
                    var userNodes = from node in schemaNode.Nodes.Cast<TreeNode>()
                                    where
                                        node.Tag != null 
                                        && node.Tag.GetType() == typeof(User)
                                        // && ((User)node.Tag).Id == user.Id
                                    select node;

                    // this is the node where the user is displayed
                    var userNode = userNodes.FirstOrDefault(o=>(o.Tag as User).Name == user.Name);

                    if (userNode != null)
                    {
                        tnUsersRoot.Expand();
                        schemaNode.Expand();

                        if (method == UserDataWindow.UserUpdateMethod.Create)
                        {   // select the newly generated user
                            tvSchemas.SelectedNode = userNode;
                        } else
                        {
                            // simply update the selected text
                            userNode.Text = user.Name;
                        }
                    }
                }
            };
        }

        private void tvSchemas_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            GenerateDataViewWindow();
        }

        private void tvSchemas_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            tvDetails.Nodes.Clear();
            if (e.Node == null || e.Node.Tag == null) return;

            if (e.Node.Tag.GetType() == typeof(Schema))
            {
                var schema = e.Node.Tag as Schema;
                foreach (var f in schema.Fields)
                {
                    var tn = tvDetails.Nodes.Add(string.Format("{0} [{1}]", f.Name, f.Type));
                    tn.ImageIndex = f.IsIndexed ? 1 : 2;
                    tn.SelectedImageIndex = tn.ImageIndex;
                }
            }
        }

        private void changeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConnectionDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new AboutBox())
            {
                about.ShowDialog();
            }
        }

        private void tvSchemas_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.SelectedImageKey = "folder_red_open";
            e.Node.ImageKey = "folder_grey_open";
        }

        private void tvSchemas_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.SelectedImageKey = "folder_red";
            e.Node.ImageKey = "folder_grey";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var node = tvSchemas.SelectedNode;
            if (node == null || node.Tag == null) return;
            if (node.Tag.GetType() == typeof(User))
            {
                var user = (User)node.Tag;
                if (MessageBox.Show(string.Format("Are you sure to delete User {0} ?", user.Name), "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    Api.Users.Delete(user.Id);
                    tvSchemas.Nodes.Remove(node);
                }                
            }
        }

        private void tvSchemas_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) tvSchemas.SelectedNode = tvSchemas.GetNodeAt(e.X, e.Y);
            if (tvSchemas.SelectedNode != null)
            {
                var txt = tvSchemas.SelectedNode.Text;
                cmsUserHeader.Text = txt;
                cmsSchemaHeader.Text = txt;
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateDataViewWindow();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateDataViewWindow();
        }
    }
}
