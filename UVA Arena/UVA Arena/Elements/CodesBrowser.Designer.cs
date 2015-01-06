﻿namespace UVA_Arena.Elements
{
    partial class CodesBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodesBrowser));
            this.problemListContainer = new System.Windows.Forms.TableLayoutPanel();
            this.plistPanel = new System.Windows.Forms.Panel();
            this.plistLabel = new System.Windows.Forms.Label();
            this.folderTreeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openExternallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pascalFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.inputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.changeDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshTool = new System.Windows.Forms.ToolStripButton();
            this.selectDirectoryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browseFolderButton = new System.Windows.Forms.Button();
            this.cancelBrowseButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.searchBox1 = new UVA_Arena.Custom.SearchBox();
            this.folderTreeView = new System.Windows.Forms.NativeTreeView();
            this.problemListContainer.SuspendLayout();
            this.plistPanel.SuspendLayout();
            this.folderTreeContext.SuspendLayout();
            this.newContextMenu.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.selectDirectoryPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // problemListContainer
            // 
            this.problemListContainer.ColumnCount = 1;
            this.problemListContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.problemListContainer.Controls.Add(this.searchBox1, 0, 3);
            this.problemListContainer.Controls.Add(this.plistPanel, 0, 0);
            this.problemListContainer.Controls.Add(this.folderTreeView, 0, 2);
            this.problemListContainer.Controls.Add(this.toolStrip3, 0, 1);
            this.problemListContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.problemListContainer.Location = new System.Drawing.Point(0, 0);
            this.problemListContainer.Name = "problemListContainer";
            this.problemListContainer.RowCount = 4;
            this.problemListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.problemListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.problemListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.problemListContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.problemListContainer.Size = new System.Drawing.Size(304, 419);
            this.problemListContainer.TabIndex = 3;
            this.problemListContainer.Tag = "115";
            // 
            // plistPanel
            // 
            this.plistPanel.Controls.Add(this.plistLabel);
            this.plistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plistPanel.Location = new System.Drawing.Point(1, 1);
            this.plistPanel.Margin = new System.Windows.Forms.Padding(1);
            this.plistPanel.Name = "plistPanel";
            this.plistPanel.Size = new System.Drawing.Size(302, 26);
            this.plistPanel.TabIndex = 4;
            // 
            // plistLabel
            // 
            this.plistLabel.BackColor = System.Drawing.Color.Transparent;
            this.plistLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plistLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plistLabel.ForeColor = System.Drawing.Color.Navy;
            this.plistLabel.Location = new System.Drawing.Point(0, 0);
            this.plistLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.plistLabel.Name = "plistLabel";
            this.plistLabel.Size = new System.Drawing.Size(302, 26);
            this.plistLabel.TabIndex = 2;
            this.plistLabel.Text = "Codes";
            this.plistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderTreeContext
            // 
            this.folderTreeContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExternallyToolStripMenuItem,
            this.toolStripSeparator6,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.newToolStripMenuItem,
            this.toolStripSeparator7,
            this.changeDirectoryToolStripMenuItem,
            this.formatDirectoryToolStripMenuItem,
            this.toolStripSeparator10,
            this.collapseAllToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.folderTreeContext.Name = "contextMenuStrip1";
            this.folderTreeContext.Size = new System.Drawing.Size(167, 242);
            // 
            // openExternallyToolStripMenuItem
            // 
            this.openExternallyToolStripMenuItem.Image = global::UVA_Arena.Properties.Resources.external;
            this.openExternallyToolStripMenuItem.Name = "openExternallyToolStripMenuItem";
            this.openExternallyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openExternallyToolStripMenuItem.Text = "Open Externally";
            this.openExternallyToolStripMenuItem.Click += new System.EventHandler(this.openExternallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(163, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDown = this.newContextMenu;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newContextMenu
            // 
            this.newContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.textFileToolStripMenuItem,
            this.toolStripSeparator11,
            this.cFileToolStripMenuItem,
            this.cPPFileToolStripMenuItem,
            this.javaFileToolStripMenuItem,
            this.pascalFileToolStripMenuItem,
            this.toolStripSeparator8,
            this.inputFileToolStripMenuItem,
            this.outputFileToolStripMenuItem});
            this.newContextMenu.Name = "newContextMenu";
            this.newContextMenu.Size = new System.Drawing.Size(151, 192);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("folderToolStripMenuItem.Image")));
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textFileToolStripMenuItem.Image")));
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.textFileToolStripMenuItem.Text = "Text File";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(147, 6);
            // 
            // cFileToolStripMenuItem
            // 
            this.cFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cFileToolStripMenuItem.Image")));
            this.cFileToolStripMenuItem.Name = "cFileToolStripMenuItem";
            this.cFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cFileToolStripMenuItem.Text = "C File";
            this.cFileToolStripMenuItem.Click += new System.EventHandler(this.cFileToolStripMenuItem_Click);
            // 
            // cPPFileToolStripMenuItem
            // 
            this.cPPFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cPPFileToolStripMenuItem.Image")));
            this.cPPFileToolStripMenuItem.Name = "cPPFileToolStripMenuItem";
            this.cPPFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cPPFileToolStripMenuItem.Text = "CPP File";
            this.cPPFileToolStripMenuItem.Click += new System.EventHandler(this.cPPFileToolStripMenuItem_Click);
            // 
            // javaFileToolStripMenuItem
            // 
            this.javaFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("javaFileToolStripMenuItem.Image")));
            this.javaFileToolStripMenuItem.Name = "javaFileToolStripMenuItem";
            this.javaFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.javaFileToolStripMenuItem.Text = "Java File";
            this.javaFileToolStripMenuItem.Click += new System.EventHandler(this.javaFileToolStripMenuItem_Click);
            // 
            // pascalFileToolStripMenuItem
            // 
            this.pascalFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pascalFileToolStripMenuItem.Image")));
            this.pascalFileToolStripMenuItem.Name = "pascalFileToolStripMenuItem";
            this.pascalFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pascalFileToolStripMenuItem.Text = "Pascal File";
            this.pascalFileToolStripMenuItem.Click += new System.EventHandler(this.pascalFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(147, 6);
            // 
            // inputFileToolStripMenuItem
            // 
            this.inputFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inputFileToolStripMenuItem.Image")));
            this.inputFileToolStripMenuItem.Name = "inputFileToolStripMenuItem";
            this.inputFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.inputFileToolStripMenuItem.Text = "Input File";
            this.inputFileToolStripMenuItem.Click += new System.EventHandler(this.inputFileToolStripMenuItem_Click);
            // 
            // outputFileToolStripMenuItem
            // 
            this.outputFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("outputFileToolStripMenuItem.Image")));
            this.outputFileToolStripMenuItem.Name = "outputFileToolStripMenuItem";
            this.outputFileToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.outputFileToolStripMenuItem.Text = "Output File";
            this.outputFileToolStripMenuItem.Click += new System.EventHandler(this.outputFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(163, 6);
            // 
            // changeDirectoryToolStripMenuItem
            // 
            this.changeDirectoryToolStripMenuItem.Image = global::UVA_Arena.Properties.Resources.folder;
            this.changeDirectoryToolStripMenuItem.Name = "changeDirectoryToolStripMenuItem";
            this.changeDirectoryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.changeDirectoryToolStripMenuItem.Text = "Change Directory";
            this.changeDirectoryToolStripMenuItem.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // formatDirectoryToolStripMenuItem
            // 
            this.formatDirectoryToolStripMenuItem.Name = "formatDirectoryToolStripMenuItem";
            this.formatDirectoryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.formatDirectoryToolStripMenuItem.Text = "Format Directory";
            this.formatDirectoryToolStripMenuItem.Click += new System.EventHandler(this.formatDir_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(163, 6);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::UVA_Arena.Properties.Resources.reload;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshTool_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.refreshTool});
            this.toolStrip3.Location = new System.Drawing.Point(3, 28);
            this.toolStrip3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(298, 25);
            this.toolStrip3.TabIndex = 6;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDown = this.newContextMenu;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton2.Text = "New";
            // 
            // refreshTool
            // 
            this.refreshTool.Image = global::UVA_Arena.Properties.Resources.reload;
            this.refreshTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshTool.Name = "refreshTool";
            this.refreshTool.Size = new System.Drawing.Size(66, 22);
            this.refreshTool.Text = "Refresh";
            this.refreshTool.Click += new System.EventHandler(this.refreshTool_Click);
            // 
            // selectDirectoryPanel
            // 
            this.selectDirectoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDirectoryPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.selectDirectoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectDirectoryPanel.Controls.Add(this.label1);
            this.selectDirectoryPanel.Controls.Add(this.tableLayoutPanel1);
            this.selectDirectoryPanel.ForeColor = System.Drawing.Color.Black;
            this.selectDirectoryPanel.Location = new System.Drawing.Point(40, 142);
            this.selectDirectoryPanel.MinimumSize = new System.Drawing.Size(180, 200);
            this.selectDirectoryPanel.Name = "selectDirectoryPanel";
            this.selectDirectoryPanel.Size = new System.Drawing.Size(218, 200);
            this.selectDirectoryPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 158);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click Browse to select a directory for code files. \r\nClick Cancel to store codes " +
    "in default directory.\r\n\r\nNote : This will automatically <FORMAT> the selected di" +
    "rectory.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.browseFolderButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelBrowseButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 40);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // browseFolderButton
            // 
            this.browseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFolderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFolderButton.Location = new System.Drawing.Point(4, 5);
            this.browseFolderButton.Name = "browseFolderButton";
            this.browseFolderButton.Size = new System.Drawing.Size(100, 30);
            this.browseFolderButton.TabIndex = 1;
            this.browseFolderButton.Text = "Browse";
            this.browseFolderButton.UseVisualStyleBackColor = true;
            this.browseFolderButton.Click += new System.EventHandler(this.browseFolderButton_Click);
            // 
            // cancelBrowseButton
            // 
            this.cancelBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBrowseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBrowseButton.Location = new System.Drawing.Point(111, 5);
            this.cancelBrowseButton.Name = "cancelBrowseButton";
            this.cancelBrowseButton.Size = new System.Drawing.Size(101, 30);
            this.cancelBrowseButton.TabIndex = 2;
            this.cancelBrowseButton.Text = "Cancel";
            this.cancelBrowseButton.UseVisualStyleBackColor = true;
            this.cancelBrowseButton.Click += new System.EventHandler(this.cancelBrowseButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, ".c.png");
            this.imageList1.Images.SetKeyName(1, ".cpp.png");
            this.imageList1.Images.SetKeyName(2, ".java.png");
            this.imageList1.Images.SetKeyName(3, ".pascal.png");
            this.imageList1.Images.SetKeyName(4, "folder.png");
            this.imageList1.Images.SetKeyName(5, "input.txt.png");
            this.imageList1.Images.SetKeyName(6, "output.txt.png");
            this.imageList1.Images.SetKeyName(7, "problem.png");
            this.imageList1.Images.SetKeyName(8, "root.png");
            this.imageList1.Images.SetKeyName(9, "volume.png");
            // 
            // searchBox1
            // 
            this.searchBox1.BackColor = System.Drawing.Color.LightCyan;
            this.searchBox1.ClearButtonVisible = true;
            this.searchBox1.CueText = "Search...";
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox1.Location = new System.Drawing.Point(1, 392);
            this.searchBox1.Margin = new System.Windows.Forms.Padding(1);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.SearchButtonVisible = true;
            this.searchBox1.SearchText = "";
            this.searchBox1.Size = new System.Drawing.Size(302, 26);
            this.searchBox1.TabIndex = 0;
            this.searchBox1.SearchButtonClicked += new System.EventHandler<System.EventArgs>(this.searchBox1_SearchButtonClicked);
            this.searchBox1.ClearButtonClicked += new System.EventHandler<System.EventArgs>(this.searchBox1_ClearButtonClicked);
            // 
            // folderTreeView
            // 
            this.folderTreeView.BackColor = System.Drawing.Color.Azure;
            this.folderTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderTreeView.ContextMenuStrip = this.folderTreeContext;
            this.folderTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTreeView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderTreeView.ForeColor = System.Drawing.Color.Black;
            this.folderTreeView.HideSelection = false;
            this.folderTreeView.ImageIndex = 0;
            this.folderTreeView.ImageList = this.imageList1;
            this.folderTreeView.ItemHeight = 25;
            this.folderTreeView.Location = new System.Drawing.Point(3, 56);
            this.folderTreeView.Name = "folderTreeView";
            this.folderTreeView.SelectedImageIndex = 0;
            this.folderTreeView.ShowLines = false;
            this.folderTreeView.ShowNodeToolTips = true;
            this.folderTreeView.Size = new System.Drawing.Size(298, 332);
            this.folderTreeView.TabIndex = 5;
            this.folderTreeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.folderTreeView_AfterLabelEdit);
            this.folderTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.folderTreeView_AfterSelect);
            this.folderTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.folderTreeView_NodeMouseClick);
            this.folderTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.folderTreeView_NodeMouseDoubleClick);
            this.folderTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.folderTreeView_KeyDown);
            // 
            // CodesBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectDirectoryPanel);
            this.Controls.Add(this.problemListContainer);
            this.Name = "CodesBrowser";
            this.Size = new System.Drawing.Size(304, 419);
            this.problemListContainer.ResumeLayout(false);
            this.problemListContainer.PerformLayout();
            this.plistPanel.ResumeLayout(false);
            this.folderTreeContext.ResumeLayout(false);
            this.newContextMenu.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.selectDirectoryPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel problemListContainer;
        private Custom.SearchBox searchBox1;
        private System.Windows.Forms.Panel plistPanel;
        private System.Windows.Forms.Label plistLabel;
        private System.Windows.Forms.NativeTreeView folderTreeView;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton refreshTool;
        private System.Windows.Forms.Panel selectDirectoryPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button browseFolderButton;
        private System.Windows.Forms.Button cancelBrowseButton;
        public System.Windows.Forms.ContextMenuStrip newContextMenu;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pascalFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem inputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip folderTreeContext;
        private System.Windows.Forms.ToolStripMenuItem openExternallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem changeDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}