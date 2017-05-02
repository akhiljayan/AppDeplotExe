namespace ApplicationDeployTools
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.RadioButton();
            this.release = new System.Windows.Forms.RadioButton();
            this.publish = new System.Windows.Forms.Button();
            this.appPath = new System.Windows.Forms.TextBox();
            this.appLocalPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moduleInfo = new System.Windows.Forms.Label();
            this.moduleLbl = new System.Windows.Forms.Label();
            this.moduleText = new System.Windows.Forms.TextBox();
            this.moduleDeploy = new System.Windows.Forms.CheckBox();
            this.projectRoot = new System.Windows.Forms.TextBox();
            this.rootPath = new System.Windows.Forms.Button();
            this.deploy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.websiteName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.serPassword = new System.Windows.Forms.TextBox();
            this.serUsername = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.setPool = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.poolsCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.appCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sitesCombo = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.currentVirtualPath = new System.Windows.Forms.Label();
            this.moveBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pathToMove = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.appCombo2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sitesCombo2 = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.createAppPool = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.startpoolbool = new System.Windows.Forms.CheckBox();
            this.mngdPipeline = new System.Windows.Forms.ComboBox();
            this.netClr = new System.Windows.Forms.ComboBox();
            this.newPoolName = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.virtualDir = new System.Windows.Forms.RadioButton();
            this.application = new System.Windows.Forms.RadioButton();
            this.virPath = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.saveAppVirtDir = new System.Windows.Forms.Button();
            this.appVirDirName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.poolsCombo3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.siteCombo3 = new System.Windows.Forms.ComboBox();
            this.openZipFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.slashLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.deployAppName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 200);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(931, 438);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.debug);
            this.tabPage1.Controls.Add(this.release);
            this.tabPage1.Controls.Add(this.publish);
            this.tabPage1.Controls.Add(this.appPath);
            this.tabPage1.Controls.Add(this.appLocalPath);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.applicationName);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publish";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Publish";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(406, 228);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(57, 17);
            this.debug.TabIndex = 20;
            this.debug.TabStop = true;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            // 
            // release
            // 
            this.release.AutoSize = true;
            this.release.Location = new System.Drawing.Point(327, 228);
            this.release.Name = "release";
            this.release.Size = new System.Drawing.Size(64, 17);
            this.release.TabIndex = 19;
            this.release.TabStop = true;
            this.release.Text = "Release";
            this.release.UseVisualStyleBackColor = true;
            // 
            // publish
            // 
            this.publish.Location = new System.Drawing.Point(239, 319);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(328, 61);
            this.publish.TabIndex = 18;
            this.publish.Text = "Publish";
            this.publish.UseVisualStyleBackColor = true;
            this.publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // appPath
            // 
            this.appPath.Enabled = false;
            this.appPath.Location = new System.Drawing.Point(271, 162);
            this.appPath.Name = "appPath";
            this.appPath.Size = new System.Drawing.Size(328, 20);
            this.appPath.TabIndex = 17;
            // 
            // appLocalPath
            // 
            this.appLocalPath.Location = new System.Drawing.Point(129, 162);
            this.appLocalPath.Name = "appLocalPath";
            this.appLocalPath.Size = new System.Drawing.Size(136, 23);
            this.appLocalPath.TabIndex = 16;
            this.appLocalPath.Text = "Browse to .sln file";
            this.appLocalPath.UseVisualStyleBackColor = true;
            this.appLocalPath.Click += new System.EventHandler(this.AppLocalPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Application Name";
            // 
            // applicationName
            // 
            this.applicationName.Location = new System.Drawing.Point(271, 126);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(328, 20);
            this.applicationName.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.slashLabel);
            this.tabPage2.Controls.Add(this.appNameLabel);
            this.tabPage2.Controls.Add(this.deployAppName);
            this.tabPage2.Controls.Add(this.moduleInfo);
            this.tabPage2.Controls.Add(this.moduleLbl);
            this.tabPage2.Controls.Add(this.moduleText);
            this.tabPage2.Controls.Add(this.moduleDeploy);
            this.tabPage2.Controls.Add(this.projectRoot);
            this.tabPage2.Controls.Add(this.rootPath);
            this.tabPage2.Controls.Add(this.deploy);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.serverName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.websiteName);
            this.tabPage2.Controls.Add(this.username);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.serPassword);
            this.tabPage2.Controls.Add(this.serUsername);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deploy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moduleInfo
            // 
            this.moduleInfo.AutoSize = true;
            this.moduleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleInfo.Location = new System.Drawing.Point(204, 317);
            this.moduleInfo.Name = "moduleInfo";
            this.moduleInfo.Size = new System.Drawing.Size(362, 13);
            this.moduleInfo.TabIndex = 42;
            this.moduleInfo.Text = "( seperate module, folder or virtual dir inside a modele by a forward slash - / )" +
    "";
            this.moduleInfo.Visible = false;
            // 
            // moduleLbl
            // 
            this.moduleLbl.AutoSize = true;
            this.moduleLbl.Location = new System.Drawing.Point(33, 297);
            this.moduleLbl.Name = "moduleLbl";
            this.moduleLbl.Size = new System.Drawing.Size(168, 13);
            this.moduleLbl.TabIndex = 41;
            this.moduleLbl.Text = "Module, Folder or Virtual Dir Name";
            this.moduleLbl.Visible = false;
            // 
            // moduleText
            // 
            this.moduleText.Location = new System.Drawing.Point(207, 294);
            this.moduleText.Name = "moduleText";
            this.moduleText.Size = new System.Drawing.Size(232, 20);
            this.moduleText.TabIndex = 40;
            this.moduleText.Visible = false;
            // 
            // moduleDeploy
            // 
            this.moduleDeploy.AutoSize = true;
            this.moduleDeploy.Location = new System.Drawing.Point(238, 243);
            this.moduleDeploy.Name = "moduleDeploy";
            this.moduleDeploy.Size = new System.Drawing.Size(232, 17);
            this.moduleDeploy.TabIndex = 39;
            this.moduleDeploy.Text = "Deploy Inside a Module, Folder or Virtual Dir";
            this.moduleDeploy.UseVisualStyleBackColor = true;
            this.moduleDeploy.CheckStateChanged += new System.EventHandler(this.moduleDeploy_Checked);
            // 
            // projectRoot
            // 
            this.projectRoot.Enabled = false;
            this.projectRoot.Location = new System.Drawing.Point(238, 53);
            this.projectRoot.Name = "projectRoot";
            this.projectRoot.Size = new System.Drawing.Size(328, 20);
            this.projectRoot.TabIndex = 38;
            // 
            // rootPath
            // 
            this.rootPath.Location = new System.Drawing.Point(90, 50);
            this.rootPath.Name = "rootPath";
            this.rootPath.Size = new System.Drawing.Size(142, 23);
            this.rootPath.TabIndex = 37;
            this.rootPath.Text = "Select package zip file";
            this.rootPath.UseVisualStyleBackColor = true;
            this.rootPath.Click += new System.EventHandler(this.rootPath_Click);
            // 
            // deploy
            // 
            this.deploy.Location = new System.Drawing.Point(238, 352);
            this.deploy.Name = "deploy";
            this.deploy.Size = new System.Drawing.Size(328, 61);
            this.deploy.TabIndex = 36;
            this.deploy.Text = "Deploy";
            this.deploy.UseVisualStyleBackColor = true;
            this.deploy.Click += new System.EventHandler(this.deploy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Deploy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Server Name";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(238, 91);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(328, 20);
            this.serverName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Deploy under Website Name";
            // 
            // websiteName
            // 
            this.websiteName.Location = new System.Drawing.Point(238, 207);
            this.websiteName.Name = "websiteName";
            this.websiteName.Size = new System.Drawing.Size(328, 20);
            this.websiteName.TabIndex = 31;
            this.websiteName.Text = "Default Web Site";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(143, 133);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 13);
            this.username.TabIndex = 30;
            this.username.Text = "Server Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(143, 173);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 13);
            this.password.TabIndex = 29;
            this.password.Text = "Server Password";
            // 
            // serPassword
            // 
            this.serPassword.Location = new System.Drawing.Point(238, 170);
            this.serPassword.Name = "serPassword";
            this.serPassword.PasswordChar = '*';
            this.serPassword.Size = new System.Drawing.Size(328, 20);
            this.serPassword.TabIndex = 28;
            // 
            // serUsername
            // 
            this.serUsername.Location = new System.Drawing.Point(238, 130);
            this.serUsername.Name = "serUsername";
            this.serUsername.Size = new System.Drawing.Size(328, 20);
            this.serUsername.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.setPool);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.poolsCombo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.appCombo);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.sitesCombo);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage App Pools";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(260, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Manage App Pools";
            // 
            // setPool
            // 
            this.setPool.Location = new System.Drawing.Point(239, 291);
            this.setPool.Name = "setPool";
            this.setPool.Size = new System.Drawing.Size(275, 64);
            this.setPool.TabIndex = 6;
            this.setPool.Text = "Save Changes";
            this.setPool.UseVisualStyleBackColor = true;
            this.setPool.Click += new System.EventHandler(this.setPool_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Set Application Pool ";
            // 
            // poolsCombo
            // 
            this.poolsCombo.FormattingEnabled = true;
            this.poolsCombo.Location = new System.Drawing.Point(412, 200);
            this.poolsCombo.Name = "poolsCombo";
            this.poolsCombo.Size = new System.Drawing.Size(276, 21);
            this.poolsCombo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Select Application";
            // 
            // appCombo
            // 
            this.appCombo.FormattingEnabled = true;
            this.appCombo.Location = new System.Drawing.Point(87, 200);
            this.appCombo.Name = "appCombo";
            this.appCombo.Size = new System.Drawing.Size(290, 21);
            this.appCombo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select a Web Site";
            // 
            // sitesCombo
            // 
            this.sitesCombo.FormattingEnabled = true;
            this.sitesCombo.Location = new System.Drawing.Point(87, 145);
            this.sitesCombo.Name = "sitesCombo";
            this.sitesCombo.Size = new System.Drawing.Size(290, 21);
            this.sitesCombo.TabIndex = 0;
            this.sitesCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.currentVirtualPath);
            this.tabPage4.Controls.Add(this.moveBtn);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.pathToMove);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.appCombo2);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.sitesCombo2);
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(723, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Move App to Diffrent Directory";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(262, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 25);
            this.label16.TabIndex = 37;
            this.label16.Text = "Move Applications";
            // 
            // currentVirtualPath
            // 
            this.currentVirtualPath.AutoSize = true;
            this.currentVirtualPath.Location = new System.Drawing.Point(77, 159);
            this.currentVirtualPath.Name = "currentVirtualPath";
            this.currentVirtualPath.Size = new System.Drawing.Size(0, 13);
            this.currentVirtualPath.TabIndex = 11;
            // 
            // moveBtn
            // 
            this.moveBtn.Location = new System.Drawing.Point(215, 319);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(275, 64);
            this.moveBtn.TabIndex = 10;
            this.moveBtn.Text = "Move";
            this.moveBtn.UseVisualStyleBackColor = true;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Server path to where App to be moved:";
            // 
            // pathToMove
            // 
            this.pathToMove.Location = new System.Drawing.Point(80, 219);
            this.pathToMove.Name = "pathToMove";
            this.pathToMove.Size = new System.Drawing.Size(548, 20);
            this.pathToMove.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Select Application";
            // 
            // appCombo2
            // 
            this.appCombo2.FormattingEnabled = true;
            this.appCombo2.Location = new System.Drawing.Point(368, 134);
            this.appCombo2.Name = "appCombo2";
            this.appCombo2.Size = new System.Drawing.Size(260, 21);
            this.appCombo2.TabIndex = 6;
            this.appCombo2.SelectedIndexChanged += new System.EventHandler(this.appcombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Select a Web Site";
            // 
            // sitesCombo2
            // 
            this.sitesCombo2.FormattingEnabled = true;
            this.sitesCombo2.Location = new System.Drawing.Point(80, 134);
            this.sitesCombo2.Name = "sitesCombo2";
            this.sitesCombo2.Size = new System.Drawing.Size(260, 21);
            this.sitesCombo2.TabIndex = 4;
            this.sitesCombo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.createAppPool);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.startpoolbool);
            this.tabPage6.Controls.Add(this.mngdPipeline);
            this.tabPage6.Controls.Add(this.netClr);
            this.tabPage6.Controls.Add(this.newPoolName);
            this.tabPage6.Location = new System.Drawing.Point(204, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(723, 430);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Create a New App Pool";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(172, 30);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(312, 25);
            this.label23.TabIndex = 39;
            this.label23.Text = "Create New Application Pool";
            // 
            // createAppPool
            // 
            this.createAppPool.Location = new System.Drawing.Point(236, 300);
            this.createAppPool.Name = "createAppPool";
            this.createAppPool.Size = new System.Drawing.Size(275, 64);
            this.createAppPool.TabIndex = 14;
            this.createAppPool.Text = "Create App Pool";
            this.createAppPool.UseVisualStyleBackColor = true;
            this.createAppPool.Click += new System.EventHandler(this.createAppPool_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(269, 181);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Managed Pipeline Mode";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(385, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = ".NET CLR Version";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Name";
            // 
            // startpoolbool
            // 
            this.startpoolbool.AutoSize = true;
            this.startpoolbool.Location = new System.Drawing.Point(269, 243);
            this.startpoolbool.Name = "startpoolbool";
            this.startpoolbool.Size = new System.Drawing.Size(127, 17);
            this.startpoolbool.TabIndex = 3;
            this.startpoolbool.Text = "Start Application Pool";
            this.startpoolbool.UseVisualStyleBackColor = true;
            // 
            // mngdPipeline
            // 
            this.mngdPipeline.FormattingEnabled = true;
            this.mngdPipeline.Location = new System.Drawing.Point(269, 197);
            this.mngdPipeline.Name = "mngdPipeline";
            this.mngdPipeline.Size = new System.Drawing.Size(221, 21);
            this.mngdPipeline.TabIndex = 2;
            // 
            // netClr
            // 
            this.netClr.FormattingEnabled = true;
            this.netClr.Location = new System.Drawing.Point(388, 121);
            this.netClr.Name = "netClr";
            this.netClr.Size = new System.Drawing.Size(222, 21);
            this.netClr.TabIndex = 1;
            // 
            // newPoolName
            // 
            this.newPoolName.Location = new System.Drawing.Point(140, 121);
            this.newPoolName.Name = "newPoolName";
            this.newPoolName.Size = new System.Drawing.Size(221, 20);
            this.newPoolName.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.virtualDir);
            this.tabPage5.Controls.Add(this.application);
            this.tabPage5.Controls.Add(this.virPath);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.saveAppVirtDir);
            this.tabPage5.Controls.Add(this.appVirDirName);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.poolsCombo3);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.siteCombo3);
            this.tabPage5.Location = new System.Drawing.Point(204, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(723, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Create Application or Virtual Directory";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // virtualDir
            // 
            this.virtualDir.AutoSize = true;
            this.virtualDir.Location = new System.Drawing.Point(401, 250);
            this.virtualDir.Name = "virtualDir";
            this.virtualDir.Size = new System.Drawing.Size(99, 17);
            this.virtualDir.TabIndex = 42;
            this.virtualDir.TabStop = true;
            this.virtualDir.Text = "Virtual Directory";
            this.virtualDir.UseVisualStyleBackColor = true;
            // 
            // application
            // 
            this.application.AutoSize = true;
            this.application.Location = new System.Drawing.Point(289, 250);
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(77, 17);
            this.application.TabIndex = 41;
            this.application.TabStop = true;
            this.application.Text = "Application";
            this.application.UseVisualStyleBackColor = true;
            // 
            // virPath
            // 
            this.virPath.Location = new System.Drawing.Point(401, 203);
            this.virPath.Name = "virPath";
            this.virPath.Size = new System.Drawing.Size(247, 20);
            this.virPath.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(398, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "Virtual Path";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(177, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(402, 25);
            this.label17.TabIndex = 38;
            this.label17.Text = "Create Application/Virtual Directories";
            // 
            // saveAppVirtDir
            // 
            this.saveAppVirtDir.Location = new System.Drawing.Point(246, 303);
            this.saveAppVirtDir.Name = "saveAppVirtDir";
            this.saveAppVirtDir.Size = new System.Drawing.Size(275, 64);
            this.saveAppVirtDir.TabIndex = 13;
            this.saveAppVirtDir.Text = "Create";
            this.saveAppVirtDir.UseVisualStyleBackColor = true;
            this.saveAppVirtDir.Click += new System.EventHandler(this.saveAppVirtDir_Click);
            // 
            // appVirDirName
            // 
            this.appVirDirName.Location = new System.Drawing.Point(401, 144);
            this.appVirDirName.Name = "appVirDirName";
            this.appVirDirName.Size = new System.Drawing.Size(247, 20);
            this.appVirDirName.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Set Application Pool ";
            // 
            // poolsCombo3
            // 
            this.poolsCombo3.FormattingEnabled = true;
            this.poolsCombo3.Location = new System.Drawing.Point(106, 203);
            this.poolsCombo3.Name = "poolsCombo3";
            this.poolsCombo3.Size = new System.Drawing.Size(260, 21);
            this.poolsCombo3.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Application/Virtual Directory Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Select a Web Site";
            // 
            // siteCombo3
            // 
            this.siteCombo3.FormattingEnabled = true;
            this.siteCombo3.Location = new System.Drawing.Point(106, 144);
            this.siteCombo3.Name = "siteCombo3";
            this.siteCombo3.Size = new System.Drawing.Size(260, 21);
            this.siteCombo3.TabIndex = 6;
            // 
            // openZipFileDialog
            // 
            this.openZipFileDialog.FileName = "openZipFileDialog";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(442, 296);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 13);
            this.slashLabel.TabIndex = 64;
            this.slashLabel.Text = "/";
            this.slashLabel.Visible = false;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Location = new System.Drawing.Point(457, 277);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(93, 13);
            this.appNameLabel.TabIndex = 63;
            this.appNameLabel.Text = "Application Name:";
            this.appNameLabel.Visible = false;
            // 
            // deployAppName
            // 
            this.deployAppName.Location = new System.Drawing.Point(460, 293);
            this.deployAppName.Name = "deployAppName";
            this.deployAppName.Size = new System.Drawing.Size(154, 20);
            this.deployAppName.TabIndex = 62;
            this.deployAppName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Application Publish & deploy";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button publish;
        private System.Windows.Forms.TextBox appPath;
        private System.Windows.Forms.Button appLocalPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox applicationName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox websiteName;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox serPassword;
        private System.Windows.Forms.TextBox serUsername;
        private System.Windows.Forms.RadioButton debug;
        private System.Windows.Forms.RadioButton release;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deploy;
        private System.Windows.Forms.TextBox projectRoot;
        private System.Windows.Forms.Button rootPath;
        private System.Windows.Forms.OpenFileDialog openZipFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sitesCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox appCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox poolsCombo;
        private System.Windows.Forms.Button setPool;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox appCombo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sitesCombo2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pathToMove;
        private System.Windows.Forms.Button moveBtn;
        private System.Windows.Forms.Label currentVirtualPath;
        private System.Windows.Forms.CheckBox moduleDeploy;
        private System.Windows.Forms.Label moduleInfo;
        private System.Windows.Forms.Label moduleLbl;
        private System.Windows.Forms.TextBox moduleText;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox appVirDirName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox poolsCombo3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox siteCombo3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox virPath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button saveAppVirtDir;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button createAppPool;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox startpoolbool;
        private System.Windows.Forms.ComboBox mngdPipeline;
        private System.Windows.Forms.ComboBox netClr;
        private System.Windows.Forms.TextBox newPoolName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton virtualDir;
        private System.Windows.Forms.RadioButton application;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.TextBox deployAppName;
    }
}

