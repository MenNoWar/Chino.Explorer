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
            ((System.ComponentModel.ISupportInitialize)(this.chinoData)).BeginInit();
            this.SuspendLayout();
            // 
            // chinoData
            // 
            this.chinoData.AllowUserToOrderColumns = true;
            this.chinoData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.chinoData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.chinoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chinoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chinoData.Location = new System.Drawing.Point(0, 0);
            this.chinoData.Name = "chinoData";
            this.chinoData.Size = new System.Drawing.Size(566, 382);
            this.chinoData.TabIndex = 0;
            this.chinoData.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.chinoData_RowValidated);
            this.chinoData.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.chinoData_RowValidating);
            this.chinoData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.chinoData_UserAddedRow);
            this.chinoData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.chinoData_UserDeletingRow);
            // 
            // FormDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.chinoData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDataView";
            this.ShowInTaskbar = false;
            this.Text = "FormDataView";
            ((System.ComponentModel.ISupportInitialize)(this.chinoData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView chinoData;
    }
}