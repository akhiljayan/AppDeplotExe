namespace ApplicationDeployTools
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.RadioButton();
            this.release = new System.Windows.Forms.RadioButton();
            this.publish = new System.Windows.Forms.Button();
            this.appPath = new System.Windows.Forms.TextBox();
            this.appLocalPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.applicationName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.moduleInfo = new System.Windows.Forms.Label();
            this.moduleLbl = new System.Windows.Forms.Label();
            this.moduleText = new System.Windows.Forms.TextBox();
            this.moduleDeploy = new System.Windows.Forms.CheckBox();
            this.projectRoot = new System.Windows.Forms.TextBox();
            this.rootPath = new System.Windows.Forms.Button();
            this.deploy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.websiteName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.serPassword = new System.Windows.Forms.TextBox();
            this.serUsername = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openZipFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.deployAppName = new System.Windows.Forms.TextBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 200);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 497);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.debug);
            this.tabPage1.Controls.Add(this.release);
            this.tabPage1.Controls.Add(this.publish);
            this.tabPage1.Controls.Add(this.appPath);
            this.tabPage1.Controls.Add(this.appLocalPath);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.applicationName);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 489);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Publish                ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Publish";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(405, 250);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(57, 17);
            this.debug.TabIndex = 28;
            this.debug.TabStop = true;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            // 
            // release
            // 
            this.release.AutoSize = true;
            this.release.Location = new System.Drawing.Point(326, 250);
            this.release.Name = "release";
            this.release.Size = new System.Drawing.Size(64, 17);
            this.release.TabIndex = 27;
            this.release.TabStop = true;
            this.release.Text = "Release";
            this.release.UseVisualStyleBackColor = true;
            // 
            // publish
            // 
            this.publish.Location = new System.Drawing.Point(238, 341);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(328, 61);
            this.publish.TabIndex = 26;
            this.publish.Text = "Publish";
            this.publish.UseVisualStyleBackColor = true;
            this.publish.Click += new System.EventHandler(this.publish_Click);
            // 
            // appPath
            // 
            this.appPath.Enabled = false;
            this.appPath.Location = new System.Drawing.Point(270, 184);
            this.appPath.Name = "appPath";
            this.appPath.Size = new System.Drawing.Size(328, 20);
            this.appPath.TabIndex = 25;
            // 
            // appLocalPath
            // 
            this.appLocalPath.Location = new System.Drawing.Point(128, 184);
            this.appLocalPath.Name = "appLocalPath";
            this.appLocalPath.Size = new System.Drawing.Size(136, 23);
            this.appLocalPath.TabIndex = 24;
            this.appLocalPath.Text = "Browse to .sln file";
            this.appLocalPath.UseVisualStyleBackColor = true;
            this.appLocalPath.Click += new System.EventHandler(this.appLocalPath_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Application Name";
            // 
            // applicationName
            // 
            this.applicationName.Location = new System.Drawing.Point(270, 148);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(328, 20);
            this.applicationName.TabIndex = 22;
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
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.serverName);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.websiteName);
            this.tabPage2.Controls.Add(this.username);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.serPassword);
            this.tabPage2.Controls.Add(this.serUsername);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 489);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deploy                ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // moduleInfo
            // 
            this.moduleInfo.AutoSize = true;
            this.moduleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleInfo.Location = new System.Drawing.Point(223, 383);
            this.moduleInfo.Name = "moduleInfo";
            this.moduleInfo.Size = new System.Drawing.Size(362, 13);
            this.moduleInfo.TabIndex = 58;
            this.moduleInfo.Text = "( seperate module, folder or virtual dir inside a modele by a forward slash - / )" +
    "";
            this.moduleInfo.Visible = false;
            // 
            // moduleLbl
            // 
            this.moduleLbl.AutoSize = true;
            this.moduleLbl.Location = new System.Drawing.Point(52, 363);
            this.moduleLbl.Name = "moduleLbl";
            this.moduleLbl.Size = new System.Drawing.Size(168, 13);
            this.moduleLbl.TabIndex = 57;
            this.moduleLbl.Text = "Module, Folder or Virtual Dir Name";
            this.moduleLbl.Visible = false;
            // 
            // moduleText
            // 
            this.moduleText.Location = new System.Drawing.Point(226, 360);
            this.moduleText.Name = "moduleText";
            this.moduleText.Size = new System.Drawing.Size(213, 20);
            this.moduleText.TabIndex = 56;
            this.moduleText.Visible = false;
            // 
            // moduleDeploy
            // 
            this.moduleDeploy.AutoSize = true;
            this.moduleDeploy.Location = new System.Drawing.Point(271, 278);
            this.moduleDeploy.Name = "moduleDeploy";
            this.moduleDeploy.Size = new System.Drawing.Size(232, 17);
            this.moduleDeploy.TabIndex = 55;
            this.moduleDeploy.Text = "Deploy Inside a Module, Folder or Virtual Dir";
            this.moduleDeploy.UseVisualStyleBackColor = true;
            this.moduleDeploy.CheckStateChanged += new System.EventHandler(this.moduleDeploy_Checked);
            // 
            // projectRoot
            // 
            this.projectRoot.Enabled = false;
            this.projectRoot.Location = new System.Drawing.Point(271, 88);
            this.projectRoot.Name = "projectRoot";
            this.projectRoot.Size = new System.Drawing.Size(328, 20);
            this.projectRoot.TabIndex = 54;
            // 
            // rootPath
            // 
            this.rootPath.Location = new System.Drawing.Point(123, 85);
            this.rootPath.Name = "rootPath";
            this.rootPath.Size = new System.Drawing.Size(142, 23);
            this.rootPath.TabIndex = 53;
            this.rootPath.Text = "Select package zip file";
            this.rootPath.UseVisualStyleBackColor = true;
            this.rootPath.Click += new System.EventHandler(this.rootPath_Click);
            // 
            // deploy
            // 
            this.deploy.Location = new System.Drawing.Point(271, 420);
            this.deploy.Name = "deploy";
            this.deploy.Size = new System.Drawing.Size(328, 61);
            this.deploy.TabIndex = 52;
            this.deploy.Text = "Deploy";
            this.deploy.UseVisualStyleBackColor = true;
            this.deploy.Click += new System.EventHandler(this.deploy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Deploy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Server Name";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(271, 126);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(328, 20);
            this.serverName.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Deploy under Website Name";
            // 
            // websiteName
            // 
            this.websiteName.Location = new System.Drawing.Point(271, 242);
            this.websiteName.Name = "websiteName";
            this.websiteName.Size = new System.Drawing.Size(328, 20);
            this.websiteName.TabIndex = 47;
            this.websiteName.Text = "Default Web Site";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(176, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 13);
            this.username.TabIndex = 46;
            this.username.Text = "Server Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(176, 208);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(87, 13);
            this.password.TabIndex = 45;
            this.password.Text = "Server Password";
            // 
            // serPassword
            // 
            this.serPassword.Location = new System.Drawing.Point(271, 205);
            this.serPassword.Name = "serPassword";
            this.serPassword.PasswordChar = '*';
            this.serPassword.Size = new System.Drawing.Size(328, 20);
            this.serPassword.TabIndex = 44;
            // 
            // serUsername
            // 
            this.serUsername.Location = new System.Drawing.Point(271, 165);
            this.serUsername.Name = "serUsername";
            this.serUsername.Size = new System.Drawing.Size(328, 20);
            this.serUsername.TabIndex = 43;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(726, 489);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Connect to Server";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.domainName);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Location = new System.Drawing.Point(82, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 338);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password: ";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(177, 161);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(264, 20);
            this.passwordTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username: ";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(177, 113);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(264, 20);
            this.usernameTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domain Name: ";
            // 
            // domainName
            // 
            this.domainName.Location = new System.Drawing.Point(177, 67);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(264, 20);
            this.domainName.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(177, 227);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(264, 45);
            this.connect.TabIndex = 0;
            this.connect.Text = "Open Application";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openZipFileDialog
            // 
            this.openZipFileDialog.FileName = "openZipFileDialog";
            // 
            // deployAppName
            // 
            this.deployAppName.Location = new System.Drawing.Point(460, 360);
            this.deployAppName.Name = "deployAppName";
            this.deployAppName.Size = new System.Drawing.Size(154, 20);
            this.deployAppName.TabIndex = 59;
            this.deployAppName.Visible = false;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Location = new System.Drawing.Point(457, 344);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(93, 13);
            this.appNameLabel.TabIndex = 60;
            this.appNameLabel.Text = "Application Name:";
            this.appNameLabel.Visible = false;
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(442, 363);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 13);
            this.slashLabel.TabIndex = 61;
            this.slashLabel.Text = "/";
            this.slashLabel.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Application Publish & deploy";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox domainName;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label moduleInfo;
        private System.Windows.Forms.Label moduleLbl;
        private System.Windows.Forms.TextBox moduleText;
        private System.Windows.Forms.CheckBox moduleDeploy;
        private System.Windows.Forms.TextBox projectRoot;
        private System.Windows.Forms.Button rootPath;
        private System.Windows.Forms.Button deploy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox websiteName;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox serPassword;
        private System.Windows.Forms.TextBox serUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton debug;
        private System.Windows.Forms.RadioButton release;
        private System.Windows.Forms.Button publish;
        private System.Windows.Forms.TextBox appPath;
        private System.Windows.Forms.Button appLocalPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox applicationName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.OpenFileDialog openZipFileDialog;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.TextBox deployAppName;
    }
}