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
    public partial class UserDataWindow : Form
    {
        public enum UserUpdateMethod
        {
            Create,
            Update
        }

        private Api Api;
        private UserSchema UsersSchema;

        public TreeNode Node { get; set; }
        public TreeNode RootNode { get; set; }

        public delegate void UserUpdatedEvent(object sender, User user, UserUpdateMethod method);
        public event UserUpdatedEvent OnUserUpdated = null;

        public UserDataWindow()
        {
            InitializeComponent();
        }

        public UserDataWindow(Api api, User user, UserSchema schema = null) : this()
        {            
            this.Api = api;
            this.User = user;
            this.Text = string.Format("User: {0}", user.Name);
            this.UsersSchema = schema ?? Api.UserSchemas.Get(user.SchemaId);            
            UpdateUserDisplay();
        }
        
        public User User { get; private set; }

        private DataTable PropertiesTable = new DataTable("Initial");

        private void UpdateUserDisplay()
        {            
            if (string.IsNullOrEmpty(User.Id))
            {
                btnUpdateUser.Text = "Create";
                this.Text = string.Format("Create User [{0}]", UsersSchema.Description);
                lblUdated.Text = "-";
                lblCreated.Text = "-";
                tbPassword.Text = string.Empty;
                lblPassword.Visible = true;
                tbPassword.Visible = true;
            } else
            {
                btnUpdateUser.Text = "Update";
                lblCreated.Text = string.Format("{0:d}, {0:t}", User.Created);
                lblUdated.Text = string.Format("{0:d}, {0:t}", User.Updated);
                lblPassword.Visible = false;
                tbPassword.Visible = false;
            }

            tbName.Text = User.Name;
            cbIsActive.Checked = User.IsActive;
            lblId.Text = User.Id;

            PropertiesTable = new DataTable("User");
            PropertiesTable.Columns.Add(new DataColumn("Key", typeof(string)));
            PropertiesTable.Columns.Add(new DataColumn("Value", typeof(object)));

            foreach (var kvp in User.Attributes)
            {
                var row = PropertiesTable.NewRow();
                row[0] = kvp.Key;
                row[1] = kvp.Value;
                PropertiesTable.Rows.Add(row);
            }

            PropertiesTable.Columns[0].ReadOnly = true;
            PropertiesTable.AcceptChanges();
            dataGridView1.DataSource = PropertiesTable;
            dataGridView1.Columns[0].Frozen = true;
        }

        private void UserDataWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in PropertiesTable.Rows)
                {
                    var propName = (string)row[0];
                    var schemaField = UsersSchema.Structure.Fields.First(o => o.Name == propName);
                    var val = Convert.ChangeType(row[1], schemaField.ClrType);
                    User.Attributes[propName] = val;
                }

                User.Name = tbName.Text;
                User.IsActive = cbIsActive.Checked;

                if (string.IsNullOrEmpty(User.Id))
                {
                    var pw = tbPassword.Text.Trim();
                    if (string.IsNullOrWhiteSpace(pw))
                    {
                        MessageBox.Show("Password has to be set", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    User = Api.Users.Create(User, pw);
                    UpdateUserDisplay();
                    OnUserUpdated?.Invoke(this, User, UserUpdateMethod.Create);
                }
                else
                {
                    Api.Users.Update(User);
                    OnUserUpdated?.Invoke(this, User, UserUpdateMethod.Update);
                }

                MessageBox.Show("User has been updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
