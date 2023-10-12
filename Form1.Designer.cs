namespace RedTeamGUI
{
    partial class MainForm1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Cache Flags");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Client");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("ID");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("KB Encryption");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("KDC");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Renew");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Server");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Sessin Key");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Start");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Ticket Flags");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Groups");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ACLs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Unquoted Services");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Domain");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Groups");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Hash");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "LUID",
            "Sub1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Password");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Username");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Rubeus = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.credentials = new System.Windows.Forms.TabPage();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketsSubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dumpCreds = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.attacks = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Mimikatz = new System.Windows.Forms.TabPage();
            this.Certify = new System.Windows.Forms.TabPage();
            this.AMSI = new System.Windows.Forms.TabPage();
            this.Enumeration = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powershellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.powerSploitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.Rubeus.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.credentials.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TicketsSubMenu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.attacks.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Enumeration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Rubeus);
            this.tabControl1.Controls.Add(this.Mimikatz);
            this.tabControl1.Controls.Add(this.Certify);
            this.tabControl1.Controls.Add(this.AMSI);
            this.tabControl1.Controls.Add(this.Enumeration);
            this.tabControl1.Location = new System.Drawing.Point(6, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 586);
            this.tabControl1.TabIndex = 0;
            // 
            // Rubeus
            // 
            this.Rubeus.BackColor = System.Drawing.Color.Gray;
            this.Rubeus.Controls.Add(this.tabControl2);
            this.Rubeus.Location = new System.Drawing.Point(4, 22);
            this.Rubeus.Name = "Rubeus";
            this.Rubeus.Padding = new System.Windows.Forms.Padding(3);
            this.Rubeus.Size = new System.Drawing.Size(950, 560);
            this.Rubeus.TabIndex = 0;
            this.Rubeus.Text = "Rubeus";
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.credentials);
            this.tabControl2.Controls.Add(this.attacks);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(950, 560);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 0;
            // 
            // credentials
            // 
            this.credentials.Controls.Add(this.panel1);
            this.credentials.Controls.Add(this.groupBox4);
            this.credentials.Location = new System.Drawing.Point(4, 4);
            this.credentials.Name = "credentials";
            this.credentials.Padding = new System.Windows.Forms.Padding(3);
            this.credentials.Size = new System.Drawing.Size(942, 534);
            this.credentials.TabIndex = 0;
            this.credentials.Text = "Credentials";
            this.credentials.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "C:\\tools\\Invoke-Mimikatz.ps1 \"sekurlsa::logonpasswords\"",
            "C:\\tools\\Rubeus.exe",
            "C:\\tools\\mimikatz.exe",
            "C:\\tools\\Loader.exe",
            "C:\\tools\\Certify.exe find /vulnerable"});
            this.comboBox5.Location = new System.Drawing.Point(69, 15);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(484, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.Text = "C:\\tools\\Invoke-Mimikatz.ps1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Location = new System.Drawing.Point(6, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 219);
            this.panel1.TabIndex = 4;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.ContextMenuStrip = this.TicketsSubMenu;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "RFS";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView2.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView2.LabelWrap = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.Size = new System.Drawing.Size(930, 219);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.SmallIcon;
            // 
            // TicketsSubMenu
            // 
            this.TicketsSubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.TicketsSubMenu.Name = "TicketsSubMenu";
            this.TicketsSubMenu.Size = new System.Drawing.Size(111, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "&Export";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "&Import";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dumpCreds);
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(424, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dumpCreds
            // 
            this.dumpCreds.Location = new System.Drawing.Point(253, 33);
            this.dumpCreds.Name = "dumpCreds";
            this.dumpCreds.Size = new System.Drawing.Size(97, 23);
            this.dumpCreds.TabIndex = 1;
            this.dumpCreds.Text = "Dump creds";
            this.dumpCreds.UseVisualStyleBackColor = true;
            this.dumpCreds.Click += new System.EventHandler(this.dumpCreds_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "SAM"});
            this.comboBox4.Location = new System.Drawing.Point(26, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(202, 21);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.Text = "/dump";
            // 
            // attacks
            // 
            this.attacks.Controls.Add(this.groupBox5);
            this.attacks.Controls.Add(this.button2);
            this.attacks.Location = new System.Drawing.Point(4, 4);
            this.attacks.Name = "attacks";
            this.attacks.Size = new System.Drawing.Size(942, 534);
            this.attacks.TabIndex = 3;
            this.attacks.Text = "Attacks";
            this.attacks.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 140);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(565, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(942, 534);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tickets";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dump creds";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "klist",
            "triage",
            "dump"});
            this.comboBox3.Location = new System.Drawing.Point(26, 33);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(202, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.Text = "dump";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(942, 534);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Forests";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Mimikatz
            // 
            this.Mimikatz.Location = new System.Drawing.Point(4, 22);
            this.Mimikatz.Name = "Mimikatz";
            this.Mimikatz.Padding = new System.Windows.Forms.Padding(3);
            this.Mimikatz.Size = new System.Drawing.Size(950, 560);
            this.Mimikatz.TabIndex = 1;
            this.Mimikatz.Text = "MimiKatz";
            this.Mimikatz.UseVisualStyleBackColor = true;
            // 
            // Certify
            // 
            this.Certify.Location = new System.Drawing.Point(4, 22);
            this.Certify.Name = "Certify";
            this.Certify.Size = new System.Drawing.Size(950, 560);
            this.Certify.TabIndex = 2;
            this.Certify.Text = "Certify";
            this.Certify.UseVisualStyleBackColor = true;
            // 
            // AMSI
            // 
            this.AMSI.Location = new System.Drawing.Point(4, 22);
            this.AMSI.Name = "AMSI";
            this.AMSI.Size = new System.Drawing.Size(950, 560);
            this.AMSI.TabIndex = 3;
            this.AMSI.Text = "AMSI";
            this.AMSI.UseVisualStyleBackColor = true;
            // 
            // Enumeration
            // 
            this.Enumeration.Controls.Add(this.treeView1);
            this.Enumeration.Location = new System.Drawing.Point(4, 22);
            this.Enumeration.Name = "Enumeration";
            this.Enumeration.Size = new System.Drawing.Size(950, 560);
            this.Enumeration.TabIndex = 4;
            this.Enumeration.Text = "Enumeration";
            this.Enumeration.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Users";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Groups";
            treeNode3.Name = "Node2";
            treeNode3.Text = "ACLs";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Unquoted Services";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(220, 549);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(710, 11);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "Hash",
            "Ticket"});
            this.comboBox1.Location = new System.Drawing.Point(176, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Passwords";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.configsToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1622, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binariesToolStripMenuItem,
            this.powershellToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // binariesToolStripMenuItem
            // 
            this.binariesToolStripMenuItem.Name = "binariesToolStripMenuItem";
            this.binariesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.binariesToolStripMenuItem.Text = "&Binaries";
            this.binariesToolStripMenuItem.Click += new System.EventHandler(this.binariesToolStripMenuItem_Click);
            // 
            // powershellToolStripMenuItem
            // 
            this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
            this.powershellToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.powershellToolStripMenuItem.Text = "&PS Modules";
            this.powershellToolStripMenuItem.Click += new System.EventHandler(this.powershellToolStripMenuItem_Click);
            // 
            // configsToolStripMenuItem
            // 
            this.configsToolStripMenuItem.Name = "configsToolStripMenuItem";
            this.configsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.configsToolStripMenuItem.Text = "&Configs";
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.powerSploitToolStripMenuItem,
            this.powerUpToolStripMenuItem,
            this.aDModuleToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.modulesToolStripMenuItem.Text = "&Modules";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // powerSploitToolStripMenuItem
            // 
            this.powerSploitToolStripMenuItem.Name = "powerSploitToolStripMenuItem";
            this.powerSploitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.powerSploitToolStripMenuItem.Text = "&PowerSploit";
            // 
            // powerUpToolStripMenuItem
            // 
            this.powerUpToolStripMenuItem.Name = "powerUpToolStripMenuItem";
            this.powerUpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.powerUpToolStripMenuItem.Text = "&PowerUp";
            // 
            // aDModuleToolStripMenuItem
            // 
            this.aDModuleToolStripMenuItem.Name = "aDModuleToolStripMenuItem";
            this.aDModuleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aDModuleToolStripMenuItem.Text = "&AD Module";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Command:";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AutoArrange = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listView1.Location = new System.Drawing.Point(6, 669);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1604, 213);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.runBtn);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.executeBtn);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(970, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 636);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select: ";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(559, 16);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 20);
            this.runBtn.TabIndex = 8;
            this.runBtn.Text = "&Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Get-NetIPConfiguration",
            "Get-NetIPAddress",
            "Get-NetRoute",
            "Get-NetTCPConnection",
            "Get-DnsClient",
            "Get-DnsClientServerAddress"});
            this.comboBox2.Location = new System.Drawing.Point(116, 603);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(268, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // executeBtn
            // 
            this.executeBtn.Location = new System.Drawing.Point(409, 601);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(75, 23);
            this.executeBtn.TabIndex = 6;
            this.executeBtn.Text = "Excute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(6, 42);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(628, 553);
            this.textBox5.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel10});
            this.statusStrip1.Location = new System.Drawing.Point(0, 885);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1622, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 17);
            this.toolStripStatusLabel1.Text = "IP:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Username:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel5.Text = "SID:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel6.Text = "toolStripStatusLabel6";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel7.Text = "Domain:";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel8.Text = "toolStripStatusLabel8";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel9.Text = "OS Version:";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel10.Text = "toolStripStatusLabel10";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 907);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "RedTeam GUI by RFS";
            this.tabControl1.ResumeLayout(false);
            this.Rubeus.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.credentials.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TicketsSubMenu.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.attacks.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.Enumeration.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Rubeus;
        private System.Windows.Forms.TabPage Mimikatz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage credentials;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripMenuItem binariesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powershellToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button dumpCreds;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage attacks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.TabPage Certify;
        private System.Windows.Forms.TabPage AMSI;
        private System.Windows.Forms.TabPage Enumeration;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip TicketsSubMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem powerSploitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDModuleToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

