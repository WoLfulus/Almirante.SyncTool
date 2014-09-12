namespace Almirante.SyncTool.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabList = new System.Windows.Forms.TabControl();
            this.pageImporters = new System.Windows.Forms.TabPage();
            this.groupImporter = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textImporterValue = new System.Windows.Forms.TextBox();
            this.textImporterDescription = new System.Windows.Forms.TextBox();
            this.listImporters = new System.Windows.Forms.ListBox();
            this.pageProcessors = new System.Windows.Forms.TabPage();
            this.groupProcessor = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textProcessorValue = new System.Windows.Forms.TextBox();
            this.textProcessorDescription = new System.Windows.Forms.TextBox();
            this.listProcessors = new System.Windows.Forms.ListBox();
            this.pageExtensions = new System.Windows.Forms.TabPage();
            this.groupExtension = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkDesigner = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkCopy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textProcessor = new System.Windows.Forms.TextBox();
            this.textImporter = new System.Windows.Forms.TextBox();
            this.listExtensions = new System.Windows.Forms.ListBox();
            this.contextTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSynchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewExport = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextExtensions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextImporters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextProcessors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.traySync = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabList.SuspendLayout();
            this.pageImporters.SuspendLayout();
            this.groupImporter.SuspendLayout();
            this.pageProcessors.SuspendLayout();
            this.groupProcessor.SuspendLayout();
            this.pageExtensions.SuspendLayout();
            this.groupExtension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextTray.SuspendLayout();
            this.contextExtensions.SuspendLayout();
            this.contextImporters.SuspendLayout();
            this.contextProcessors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.pageImporters);
            this.tabList.Controls.Add(this.pageProcessors);
            this.tabList.Controls.Add(this.pageExtensions);
            this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList.Location = new System.Drawing.Point(5, 5);
            this.tabList.Margin = new System.Windows.Forms.Padding(10);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(765, 231);
            this.tabList.TabIndex = 3;
            // 
            // pageImporters
            // 
            this.pageImporters.Controls.Add(this.groupImporter);
            this.pageImporters.Controls.Add(this.listImporters);
            this.pageImporters.Location = new System.Drawing.Point(4, 22);
            this.pageImporters.Name = "pageImporters";
            this.pageImporters.Padding = new System.Windows.Forms.Padding(3);
            this.pageImporters.Size = new System.Drawing.Size(757, 205);
            this.pageImporters.TabIndex = 2;
            this.pageImporters.Text = "Content Importers";
            this.pageImporters.UseVisualStyleBackColor = true;
            // 
            // groupImporter
            // 
            this.groupImporter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupImporter.Controls.Add(this.label3);
            this.groupImporter.Controls.Add(this.label4);
            this.groupImporter.Controls.Add(this.textImporterValue);
            this.groupImporter.Controls.Add(this.textImporterDescription);
            this.groupImporter.Enabled = false;
            this.groupImporter.Location = new System.Drawing.Point(380, 0);
            this.groupImporter.Name = "groupImporter";
            this.groupImporter.Size = new System.Drawing.Size(371, 199);
            this.groupImporter.TabIndex = 4;
            this.groupImporter.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // textImporterValue
            // 
            this.textImporterValue.Location = new System.Drawing.Point(103, 45);
            this.textImporterValue.Name = "textImporterValue";
            this.textImporterValue.Size = new System.Drawing.Size(256, 20);
            this.textImporterValue.TabIndex = 7;
            this.textImporterValue.TextChanged += new System.EventHandler(this.OnImporterValueChanged);
            // 
            // textImporterDescription
            // 
            this.textImporterDescription.Location = new System.Drawing.Point(103, 19);
            this.textImporterDescription.Name = "textImporterDescription";
            this.textImporterDescription.Size = new System.Drawing.Size(256, 20);
            this.textImporterDescription.TabIndex = 6;
            this.textImporterDescription.TextChanged += new System.EventHandler(this.OnImporterDescriptionChanged);
            // 
            // listImporters
            // 
            this.listImporters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listImporters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listImporters.FormattingEnabled = true;
            this.listImporters.IntegralHeight = false;
            this.listImporters.Location = new System.Drawing.Point(6, 6);
            this.listImporters.Name = "listImporters";
            this.listImporters.Size = new System.Drawing.Size(368, 193);
            this.listImporters.TabIndex = 3;
            this.listImporters.SelectedIndexChanged += new System.EventHandler(this.OnImporterSelect);
            this.listImporters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnImporterMouseDown);
            // 
            // pageProcessors
            // 
            this.pageProcessors.Controls.Add(this.groupProcessor);
            this.pageProcessors.Controls.Add(this.listProcessors);
            this.pageProcessors.Location = new System.Drawing.Point(4, 22);
            this.pageProcessors.Name = "pageProcessors";
            this.pageProcessors.Padding = new System.Windows.Forms.Padding(3);
            this.pageProcessors.Size = new System.Drawing.Size(757, 205);
            this.pageProcessors.TabIndex = 3;
            this.pageProcessors.Text = "Content Processors";
            this.pageProcessors.UseVisualStyleBackColor = true;
            // 
            // groupProcessor
            // 
            this.groupProcessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupProcessor.Controls.Add(this.label7);
            this.groupProcessor.Controls.Add(this.label8);
            this.groupProcessor.Controls.Add(this.textProcessorValue);
            this.groupProcessor.Controls.Add(this.textProcessorDescription);
            this.groupProcessor.Enabled = false;
            this.groupProcessor.Location = new System.Drawing.Point(380, 0);
            this.groupProcessor.Name = "groupProcessor";
            this.groupProcessor.Size = new System.Drawing.Size(371, 199);
            this.groupProcessor.TabIndex = 4;
            this.groupProcessor.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description:";
            // 
            // textProcessorValue
            // 
            this.textProcessorValue.Location = new System.Drawing.Point(103, 45);
            this.textProcessorValue.Name = "textProcessorValue";
            this.textProcessorValue.Size = new System.Drawing.Size(256, 20);
            this.textProcessorValue.TabIndex = 13;
            this.textProcessorValue.TextChanged += new System.EventHandler(this.OnProcessorValueChanged);
            // 
            // textProcessorDescription
            // 
            this.textProcessorDescription.Location = new System.Drawing.Point(103, 19);
            this.textProcessorDescription.Name = "textProcessorDescription";
            this.textProcessorDescription.Size = new System.Drawing.Size(256, 20);
            this.textProcessorDescription.TabIndex = 12;
            this.textProcessorDescription.TextChanged += new System.EventHandler(this.OnProcessorDescriptionChanged);
            // 
            // listProcessors
            // 
            this.listProcessors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProcessors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listProcessors.FormattingEnabled = true;
            this.listProcessors.IntegralHeight = false;
            this.listProcessors.Location = new System.Drawing.Point(6, 6);
            this.listProcessors.Name = "listProcessors";
            this.listProcessors.Size = new System.Drawing.Size(368, 193);
            this.listProcessors.TabIndex = 3;
            this.listProcessors.SelectedIndexChanged += new System.EventHandler(this.OnProcessorSelect);
            this.listProcessors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnProcessorMouseDown);
            // 
            // pageExtensions
            // 
            this.pageExtensions.Controls.Add(this.groupExtension);
            this.pageExtensions.Controls.Add(this.listExtensions);
            this.pageExtensions.Location = new System.Drawing.Point(4, 22);
            this.pageExtensions.Name = "pageExtensions";
            this.pageExtensions.Padding = new System.Windows.Forms.Padding(3);
            this.pageExtensions.Size = new System.Drawing.Size(757, 205);
            this.pageExtensions.TabIndex = 1;
            this.pageExtensions.Text = "Extensions";
            this.pageExtensions.UseVisualStyleBackColor = true;
            // 
            // groupExtension
            // 
            this.groupExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExtension.Controls.Add(this.pictureBox2);
            this.groupExtension.Controls.Add(this.pictureBox1);
            this.groupExtension.Controls.Add(this.checkDesigner);
            this.groupExtension.Controls.Add(this.label1);
            this.groupExtension.Controls.Add(this.checkCopy);
            this.groupExtension.Controls.Add(this.label2);
            this.groupExtension.Controls.Add(this.textProcessor);
            this.groupExtension.Controls.Add(this.textImporter);
            this.groupExtension.Enabled = false;
            this.groupExtension.Location = new System.Drawing.Point(380, 0);
            this.groupExtension.Name = "groupExtension";
            this.groupExtension.Size = new System.Drawing.Size(371, 199);
            this.groupExtension.TabIndex = 2;
            this.groupExtension.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnBrowseProcessors);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnBrowseImporters);
            // 
            // checkDesigner
            // 
            this.checkDesigner.AutoSize = true;
            this.checkDesigner.Location = new System.Drawing.Point(133, 71);
            this.checkDesigner.Name = "checkDesigner";
            this.checkDesigner.Size = new System.Drawing.Size(93, 17);
            this.checkDesigner.TabIndex = 12;
            this.checkDesigner.Text = "Uses designer";
            this.checkDesigner.UseVisualStyleBackColor = true;
            this.checkDesigner.CheckedChanged += new System.EventHandler(this.OnExtensionDesignerChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Content Processor:";
            // 
            // checkCopy
            // 
            this.checkCopy.AutoSize = true;
            this.checkCopy.Location = new System.Drawing.Point(133, 94);
            this.checkCopy.Name = "checkCopy";
            this.checkCopy.Size = new System.Drawing.Size(72, 17);
            this.checkCopy.TabIndex = 10;
            this.checkCopy.Text = "Copy only";
            this.checkCopy.UseVisualStyleBackColor = true;
            this.checkCopy.CheckedChanged += new System.EventHandler(this.OnExtensionCopyChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Content Importer:";
            // 
            // textProcessor
            // 
            this.textProcessor.Location = new System.Drawing.Point(133, 45);
            this.textProcessor.Name = "textProcessor";
            this.textProcessor.Size = new System.Drawing.Size(202, 20);
            this.textProcessor.TabIndex = 7;
            this.textProcessor.TextChanged += new System.EventHandler(this.OnExtensionProcessorChanged);
            // 
            // textImporter
            // 
            this.textImporter.Location = new System.Drawing.Point(133, 19);
            this.textImporter.Name = "textImporter";
            this.textImporter.Size = new System.Drawing.Size(202, 20);
            this.textImporter.TabIndex = 6;
            this.textImporter.TextChanged += new System.EventHandler(this.OnExtensionImporterChange);
            // 
            // listExtensions
            // 
            this.listExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listExtensions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listExtensions.FormattingEnabled = true;
            this.listExtensions.IntegralHeight = false;
            this.listExtensions.Location = new System.Drawing.Point(6, 6);
            this.listExtensions.Name = "listExtensions";
            this.listExtensions.Size = new System.Drawing.Size(368, 193);
            this.listExtensions.TabIndex = 1;
            this.listExtensions.SelectedIndexChanged += new System.EventHandler(this.OnExtensionSelect);
            this.listExtensions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnExtensionsMouseDown);
            // 
            // contextTray
            // 
            this.contextTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSynchronize,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuExit});
            this.contextTray.Name = "contextTray";
            this.contextTray.Size = new System.Drawing.Size(153, 98);
            this.contextTray.Text = "Menu";
            // 
            // menuSynchronize
            // 
            this.menuSynchronize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewExport,
            this.synchronizeAllToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuSynchronize.Image = ((System.Drawing.Image)(resources.GetObject("menuSynchronize.Image")));
            this.menuSynchronize.Name = "menuSynchronize";
            this.menuSynchronize.Size = new System.Drawing.Size(152, 22);
            this.menuSynchronize.Text = "Projects";
            // 
            // menuNewExport
            // 
            this.menuNewExport.Image = ((System.Drawing.Image)(resources.GetObject("menuNewExport.Image")));
            this.menuNewExport.Name = "menuNewExport";
            this.menuNewExport.Size = new System.Drawing.Size(155, 22);
            this.menuNewExport.Text = "New...";
            this.menuNewExport.Click += new System.EventHandler(this.OnCreateExport);
            // 
            // synchronizeAllToolStripMenuItem
            // 
            this.synchronizeAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("synchronizeAllToolStripMenuItem.Image")));
            this.synchronizeAllToolStripMenuItem.Name = "synchronizeAllToolStripMenuItem";
            this.synchronizeAllToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.synchronizeAllToolStripMenuItem.Text = "Synchronize All";
            this.synchronizeAllToolStripMenuItem.Click += new System.EventHandler(this.SynchronizeAllProjects);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnSettingsClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.OnCloseInterface);
            // 
            // contextExtensions
            // 
            this.contextExtensions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.contextExtensions.Name = "contextMenuStrip1";
            this.contextExtensions.Size = new System.Drawing.Size(118, 48);
            this.contextExtensions.Text = "Menu";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Add";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.OnCreateExtension);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem4.Text = "Remove";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.OnRemoveExtension);
            // 
            // contextImporters
            // 
            this.contextImporters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.contextImporters.Name = "contextMenuStrip1";
            this.contextImporters.Size = new System.Drawing.Size(118, 48);
            this.contextImporters.Text = "Menu";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "Add";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.OnCreateImporter);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem5.Text = "Remove";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.OnRemoveImporter);
            // 
            // contextProcessors
            // 
            this.contextProcessors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.contextProcessors.Name = "contextMenuStrip1";
            this.contextProcessors.Size = new System.Drawing.Size(118, 48);
            this.contextProcessors.Text = "Menu";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem6.Text = "Add";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.OnCreateProcessor);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem7.Text = "Remove";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.OnRemoveProcessor);
            // 
            // contextBrowser
            // 
            this.contextBrowser.Name = "contextBrowser";
            this.contextBrowser.Size = new System.Drawing.Size(61, 4);
            // 
            // traySync
            // 
            this.traySync.ContextMenuStrip = this.contextTray;
            this.traySync.Icon = ((System.Drawing.Icon)(resources.GetObject("traySync.Icon")));
            this.traySync.Text = "XNA SyncTool";
            this.traySync.Visible = true;
            this.traySync.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnShowInterface);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 241);
            this.Controls.Add(this.tabList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XNA SyncTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosingInterface);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.OnShownInterface);
            this.tabList.ResumeLayout(false);
            this.pageImporters.ResumeLayout(false);
            this.groupImporter.ResumeLayout(false);
            this.groupImporter.PerformLayout();
            this.pageProcessors.ResumeLayout(false);
            this.groupProcessor.ResumeLayout(false);
            this.groupProcessor.PerformLayout();
            this.pageExtensions.ResumeLayout(false);
            this.groupExtension.ResumeLayout(false);
            this.groupExtension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextTray.ResumeLayout(false);
            this.contextExtensions.ResumeLayout(false);
            this.contextImporters.ResumeLayout(false);
            this.contextProcessors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage pageExtensions;
        private System.Windows.Forms.GroupBox groupExtension;
        private System.Windows.Forms.ListBox listExtensions;
        private System.Windows.Forms.CheckBox checkDesigner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProcessor;
        private System.Windows.Forms.TextBox textImporter;
        private System.Windows.Forms.ContextMenuStrip contextTray;
        private System.Windows.Forms.ToolStripMenuItem menuSynchronize;
        private System.Windows.Forms.ToolStripMenuItem menuNewExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ContextMenuStrip contextExtensions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage pageImporters;
        private System.Windows.Forms.TabPage pageProcessors;
        private System.Windows.Forms.GroupBox groupImporter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textImporterValue;
        private System.Windows.Forms.TextBox textImporterDescription;
        private System.Windows.Forms.ListBox listImporters;
        private System.Windows.Forms.GroupBox groupProcessor;
        private System.Windows.Forms.ListBox listProcessors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textProcessorValue;
        private System.Windows.Forms.TextBox textProcessorDescription;
        private System.Windows.Forms.ContextMenuStrip contextImporters;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip contextProcessors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ContextMenuStrip contextBrowser;
        private System.Windows.Forms.NotifyIcon traySync;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem synchronizeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

