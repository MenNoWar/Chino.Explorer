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
    public partial class FormConnectData : Form
    {
        public FormConnectData()
        {
            InitializeComponent();
            CustomerId = Properties.Settings.Default.CustomerId;
            CustomerKey = Properties.Settings.Default.CustomerKey;
            HostUrl = Properties.Settings.Default.HostUrl;
            RepositoryId = Properties.Settings.Default.RepositoryId;

#if DEBUG
//            tbCustomerId.Text = "19c47c7d-144e-4a49-9d75-48b28ba2569f";
//            tbCustomerKey.Text = "432074bc-7b3c-440a-a7e8-4ac220bef256";
//            tbHost.Text = "https://api.test.chino.io/v1";
//            tbRepositoryId.Text = "a6ab3ea6-0959-455d-bbcd-26df6e6b45db";
#endif
        }

        public string RepositoryId
        {
            get { return tbRepositoryId.Text; }
            set { tbRepositoryId.Text = value; }
        }

        public string CustomerId
        {
            get { return tbCustomerId.Text; }
            set { tbCustomerId.Text = value; }
        }

        public string CustomerKey
        {
            get { return tbCustomerKey.Text; }
            set { tbCustomerKey.Text = value; }
        }

        public string HostUrl
        {
            get { return tbHost.Text; }
            set { tbHost.Text = value; }
        }

        private bool TestConnect()
        {
            try
            {
                var api = new Api(HostUrl, CustomerId, CustomerKey);
                var test = api.Applications.List();
                return test != null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connecting");
                return false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CustomerId = CustomerId;
            Properties.Settings.Default.CustomerKey = CustomerKey;
            Properties.Settings.Default.HostUrl = HostUrl;
            Properties.Settings.Default.RepositoryId = RepositoryId;
            Properties.Settings.Default.Save();

            if (TestConnect()) {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
