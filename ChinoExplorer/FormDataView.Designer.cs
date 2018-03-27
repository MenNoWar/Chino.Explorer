namespace ChinoExplorer
{
    partial class FormDataView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataView));
            this.chinoData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LoadNext100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chinoData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chinoData
            // 
            this.chinoData.AllowUserToOrderColumns = true;
            this.chinoData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.chinoData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.chinoData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chinoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chinoData.Location = new System.Drawing.Point(0, 33);
            this.chinoData.Name = "chinoData";
            this.chinoData.Size = new System.Drawing.Size(566, 349);
            this.chinoData.TabIndex = 0;
            this.chinoData.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.chinoData_RowValidated);
            this.chinoData.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.chinoData_RowValidating);
            this.chinoData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.chinoData_UserAddedRow);
            this.chinoData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.chinoData_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_LoadNext100);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 32);
            this.panel1.TabIndex = 1;
            // 
            // btn_LoadNext100
            // 
            this.btn_LoadNext100.Location = new System.Drawing.Point(3, 4);
            this.btn_LoadNext100.Name = "btn_LoadNext100";
            this.btn_LoadNext100.Size = new System.Drawing.Size(115, 23);
            this.btn_LoadNext100.TabIndex = 0;
            this.btn_LoadNext100.Text = "Load Next 100";
            this.btn_LoadNext100.UseVisualStyleBackColor = true;
            this.btn_LoadNext100.Click += new System.EventHandler(this.btn_LoadNext100_Click);
            // 
            // FormDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chinoData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataView";
            this.ShowInTaskbar = false;
            this.Text = "FormDataView";
            ((System.ComponentModel.ISupportInitialize)(this.chinoData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chinoData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_LoadNext100;
    }
}