namespace ChinoExplorer
{
    partial class MDIParent1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Knoten0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Knoten2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Knoten0");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Knoten3", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Knoten1");
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvSchemas = new System.Windows.Forms.TreeView();
            this.ilTreeviews = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tvDetails = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ilToolbars = new System.Windows.Forms.ImageList(this.components);
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsUserHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSchemas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSchemaHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.createSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectUserSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.cmsUser.SuspendLayout();
            this.cmsSchemas.SuspendLayout();
            this.cmsUserRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsToolStripMenuItem,
            this.windowsMenu,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(872, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeConnectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // changeConnectionToolStripMenuItem
            // 
            this.changeConnectionToolStripMenuItem.Name = "changeConnectionToolStripMenuItem";
            this.changeConnectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeConnectionToolStripMenuItem.Text = "Change Connection";
            this.changeConnectionToolStripMenuItem.Click += new System.EventHandler(this.changeConnectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Quit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(63, 20);
            this.windowsMenu.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cascadeToolStripMenuItem.Text = "&Overlapping";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tileVerticalToolStripMenuItem.Text = "&Side by Side";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tileHorizontalToolStripMenuItem.Text = "St&acked";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeAllToolStripMenuItem.Text = "&Close all";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange S&ymbols";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 484);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(872, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 460);
            this.panel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 34);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvSchemas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tvDetails);
            this.splitContainer1.Size = new System.Drawing.Size(215, 423);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 9;
            // 
            // tvSchemas
            // 
            this.tvSchemas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSchemas.HideSelection = false;
            this.tvSchemas.ImageIndex = 4;
            this.tvSchemas.ImageList = this.ilTreeviews;
            this.tvSchemas.Location = new System.Drawing.Point(0, 0);
            this.tvSchemas.Name = "tvSchemas";
            treeNode1.Name = "Knoten1";
            treeNode1.Text = "Knoten1";
            treeNode2.Name = "Knoten1";
            treeNode2.Text = "Knoten1";
            treeNode3.Checked = true;
            treeNode3.Name = "Knoten0";
            treeNode3.Text = "Knoten0";
            treeNode4.Name = "Knoten2";
            treeNode4.Text = "Knoten2";
            treeNode5.Name = "Knoten0";
            treeNode5.Text = "Knoten0";
            treeNode6.Name = "Knoten3";
            treeNode6.Text = "Knoten3";
            this.tvSchemas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode6});
            this.tvSchemas.SelectedImageIndex = 4;
            this.tvSchemas.Size = new System.Drawing.Size(215, 237);
            this.tvSchemas.TabIndex = 0;
            this.tvSchemas.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvSchemas_AfterCollapse);
            this.tvSchemas.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvSchemas_AfterExpand);
            this.tvSchemas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSchemas_AfterSelect);
            this.tvSchemas.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSchemas_NodeMouseClick);
            this.tvSchemas.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSchemas_NodeMouseDoubleClick);
            // 
            // ilTreeviews
            // 
            this.ilTreeviews.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTreeviews.ImageStream")));
            this.ilTreeviews.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTreeviews.Images.SetKeyName(0, "if_table_green_48_10358.png");
            this.ilTreeviews.Images.SetKeyName(1, "if_icon-24-key_314756.png");
            this.ilTreeviews.Images.SetKeyName(2, "if_stock_select-column-16_94719.png");
            this.ilTreeviews.Images.SetKeyName(3, "if_icon-24-key_314861.png");
            this.ilTreeviews.Images.SetKeyName(4, "schema");
            this.ilTreeviews.Images.SetKeyName(5, "folder_grey");
            this.ilTreeviews.Images.SetKeyName(6, "folder_red");
            this.ilTreeviews.Images.SetKeyName(7, "folder_grey_open");
            this.ilTreeviews.Images.SetKeyName(8, "folder_red_open");
            this.ilTreeviews.Images.SetKeyName(9, "user");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schema";
            // 
            // tvDetails
            // 
            this.tvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvDetails.ImageIndex = 2;
            this.tvDetails.ImageList = this.ilTreeviews;
            this.tvDetails.Location = new System.Drawing.Point(0, 19);
            this.tvDetails.Name = "tvDetails";
            treeNode7.Name = "Knoten1";
            treeNode7.Text = "Knoten1";
            this.tvDetails.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.tvDetails.SelectedImageIndex = 0;
            this.tvDetails.ShowRootLines = false;
            this.tvDetails.Size = new System.Drawing.Size(215, 160);
            this.tvDetails.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(221, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ilToolbars
            // 
            this.ilToolbars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilToolbars.ImageStream")));
            this.ilToolbars.TransparentColor = System.Drawing.Color.Transparent;
            this.ilToolbars.Images.SetKeyName(0, "refresh-icon.png");
            this.ilToolbars.Images.SetKeyName(1, "search-icon.png");
            this.ilToolbars.Images.SetKeyName(2, "if_Database_copy_DynamoDB_Table_259307.png");
            this.ilToolbars.Images.SetKeyName(3, "if_table_green_48_10358.png");
            // 
            // cmsUser
            // 
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsUserHeader,
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(108, 76);
            // 
            // cmsUserHeader
            // 
            this.cmsUserHeader.Enabled = false;
            this.cmsUserHeader.Name = "cmsUserHeader";
            this.cmsUserHeader.Size = new System.Drawing.Size(107, 22);
            this.cmsUserHeader.Text = "User";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::ChinoExplorer.Properties.Resources.if_edit_user_3918;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::ChinoExplorer.Properties.Resources.if_delete_user_3912;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmsSchemas
            // 
            this.cmsSchemas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSchemaHeader,
            this.editToolStripMenuItem1,
            this.toolStripSeparator3,
            this.createSqlToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteToolStripMenuItem1});
            this.cmsSchemas.Name = "cmsSchemas";
            this.cmsSchemas.Size = new System.Drawing.Size(153, 126);
            // 
            // cmsSchemaHeader
            // 
            this.cmsSchemaHeader.Enabled = false;
            this.cmsSchemaHeader.Name = "cmsSchemaHeader";
            this.cmsSchemaHeader.Size = new System.Drawing.Size(152, 22);
            this.cmsSchemaHeader.Text = "Schema";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Image = global::ChinoExplorer.Properties.Resources.edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "&Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // createSqlToolStripMenuItem
            // 
            this.createSqlToolStripMenuItem.Name = "createSqlToolStripMenuItem";
            this.createSqlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createSqlToolStripMenuItem.Text = "Create Sql";
            this.createSqlToolStripMenuItem.Click += new System.EventHandler(this.createSqlToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::ChinoExplorer.Properties.Resources.delete;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "&Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // cmsUserRoot
            // 
            this.cmsUserRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.addNewUserToolStripMenuItem});
            this.cmsUserRoot.Name = "cmsUserRoot";
            this.cmsUserRoot.Size = new System.Drawing.Size(148, 48);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectUserSchemaToolStripMenuItem});
            this.addNewUserToolStripMenuItem.Image = global::ChinoExplorer.Properties.Resources.if_add_user_3802;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.addNewUserToolStripMenuItem.Text = "Add new User";
            // 
            // selectUserSchemaToolStripMenuItem
            // 
            this.selectUserSchemaToolStripMenuItem.Enabled = false;
            this.selectUserSchemaToolStripMenuItem.Name = "selectUserSchemaToolStripMenuItem";
            this.selectUserSchemaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.selectUserSchemaToolStripMenuItem.Text = "Select UserSchema";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(221, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 460);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 506);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsUser.ResumeLayout(false);
            this.cmsSchemas.ResumeLayout(false);
            this.cmsUserRoot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList ilToolbars;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvSchemas;
        private System.Windows.Forms.ImageList ilTreeviews;
        private System.Windows.Forms.TreeView tvDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem changeConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsUserHeader;
        private System.Windows.Forms.ContextMenuStrip cmsSchemas;
        private System.Windows.Forms.ToolStripMenuItem cmsSchemaHeader;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsUserRoot;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectUserSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Splitter splitter1;
    }
}



