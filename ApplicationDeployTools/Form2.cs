using ApplicationDeployTools.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDeployTools
{
    public partial class Form2 : Form
    {
        public string mainAppName;
        public string mainAppPath;
        IPublDepyApp appInter = null;
        public Form2()
        {
            InitializeComponent();
            appInter = new PublDepyApp();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string pathStatus = appInter.SetEnvironmentalVariable();
            if(pathStatus != "OK")
            {
                if (pathStatus == "addingError")
                {
                    MessageBox.Show("There was a problem in adding the Environmental variables... Please check if following are installed in proper directories.. \n 1). Microsoft Build (MSBuild.exe) : \n\t C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319 \n\n\n 2). MS Web Deploy (msdeploy.exe) : \n\t C:\\Program Files (x86)\\IIS\\Microsoft Web Deploy V3");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(pathStatus);
                    MessageBox.Show("Please Run as Administrator!!!");
                    this.Close();
                }
            }
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush textBrush;
            TabPage tabPage = tabControl1.TabPages[e.Index];
            Rectangle tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }
            Font tabFont = new Font("Arial", (float)15.0, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(tabPage.Text, tabFont, textBrush, tabBounds, new StringFormat(stringFlags));
        }

        private void publish_Click(object sender, EventArgs e)
        {
            string appName = applicationName.Text;
            string slnPath = appPath.Text;
            string slnName = openFileDialog.SafeFileName;
            appName = slnName.Remove(slnName.Length - 4, 4);
            int appSlnLength = slnName.Length + 1;
            string folderpath = slnPath.Remove(slnPath.Length - appSlnLength, appSlnLength);

            mainAppName = appName;
            mainAppPath = folderpath;

            string servername = serverName.Text;
            string username = serUsername.Text;
            string password = serPassword.Text;
            string website = websiteName.Text;

            string relese = "Debug";
            if (release.Checked == true)
            {
                relese = "Release";
            }

            if (debug.Checked == true)
            {
                relese = "Debug";
            }
            string status = appInter.DoPublish(folderpath, appName, slnPath, mainAppPath, mainAppName, relese);
            if (status == "OK")
            {
                MessageBox.Show("Application Published..");
            }
            else
            {
                MessageBox.Show(status);
                MessageBox.Show("Error occured while publishing.");
            }
            //publish.Enabled = false;
        }

        private void deploy_Click(object sender, EventArgs e)
        {
            string xmlEditStatus = "OK";
            string depStatus = "";
            string moduledepPath = "";
            string servername = serverName.Text.Trim();
            string username = serUsername.Text.Trim();
            string password = serPassword.Text.Trim();
            string website = websiteName.Text.Trim();
            string deplyAppName = "";

            string zipFilePath = projectRoot.Text;
            string zipFileName = openZipFileDialog.SafeFileName;
            string appName = zipFileName.Remove(zipFileName.Length - 4, 4);
            int appZipLength = zipFileName.Length + 1;
            string folderpath = zipFilePath.Remove(zipFilePath.Length - appZipLength, appZipLength);

            if (moduleDeploy.Checked)
            {
                moduledepPath = moduleText.Text.Trim();
                deplyAppName = deployAppName.Text.Trim();
            }
            else
            {
                moduledepPath = "";
                deplyAppName = "";
            }

            string flag = "deploy";

            xmlEditStatus = appInter.EditXml(folderpath, appName, "", website, flag, moduledepPath, deplyAppName);

            if (xmlEditStatus == "OK")
            {
                depStatus = appInter.DoDeploy(folderpath, appName, website, servername, username, password, flag);
            }
            else
            {
                depStatus = "Error While changeing App Property..";
            }
            if (depStatus == "OK")
            {
                MessageBox.Show("Application Deployed..");
            }
            else
            {
                MessageBox.Show(depStatus);
                MessageBox.Show("Error occured while Deploying..");
            }
            //deploy.Enabled = false;
        }

        private void appLocalPath_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            appPath.Text = filePath;
        }

        private void rootPath_Click(object sender, EventArgs e)
        {
            openZipFileDialog.ShowDialog();
            string filePath = openZipFileDialog.FileName;
            projectRoot.Text = filePath;
        }

        private void connect_Click_1(object sender, EventArgs e)
        {
            string domain = domainName.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(username, password, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            try
            {
                string[] check = client.GetAllPools();
                this.Hide();
                Form1 mainForm = new Form1(username, password, domain);
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While connecting.. Credentials entred might be wrong!!!");
            }
        }

        private void moduleDeploy_Checked(object sender, EventArgs e)
        {
            if (moduleDeploy.Checked)
            {
                moduleLbl.Visible = true;
                moduleInfo.Visible = true;
                moduleText.Visible = true;
                appNameLabel.Visible = true;
                deployAppName.Visible = true;
                slashLabel.Visible = true;
            }
            else
            {
                moduleLbl.Visible = false;
                moduleInfo.Visible = false;
                moduleText.Visible = false;
                appNameLabel.Visible = false;
                deployAppName.Visible = false;
                slashLabel.Visible = false;
            }
        }
    }
}
