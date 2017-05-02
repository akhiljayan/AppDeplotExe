using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using ApplicationDeployTools.ServiceReference1;
using System.Security.Principal;
using ApplicationDeployTools.App;

namespace ApplicationDeployTools
{
    public partial class Form1 : Form
    {

        public string mainAppName;
        public string mainAppPath;
        IPublDepyApp appInter = null;
        public string uname { get; set; }
        public string pass { get; set; }
        public string domain { get; set; }

        
        public Form1(string uname, string pass, string domain)
        {
            this.uname = uname;
            this.pass = pass;
            this.domain = domain;

            InitializeComponent();
            appInter = new PublDepyApp();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            sitesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            appCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            poolsCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            sitesCombo2.DropDownStyle = ComboBoxStyle.DropDownList;
            appCombo2.DropDownStyle = ComboBoxStyle.DropDownList;

            netClr.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] netvers = { "v4.0", "v2.0" };
            netClr.DataSource = netvers;
            mngdPipeline.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] pip = { "Integrated", "Clasic" };
            mngdPipeline.DataSource = pip;

            siteCombo3.DropDownStyle = ComboBoxStyle.DropDownList;
            poolsCombo3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            string[] ds = client.GetAllSites();
            string[] pools = client.GetAllPools();
            sitesCombo.DataSource = ds;
            sitesCombo2.DataSource = ds;
            siteCombo3.DataSource = ds;
            poolsCombo3.DataSource = pools;
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

        private void AppLocalPath_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            appPath.Text = filePath;
        }

        private void Publish_Click(object sender, EventArgs e)
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
            if(release.Checked == true)
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
                //editXml(folderpath, appName, relese, "", "publish");
                MessageBox.Show("Application Published..");
            }
            else
            {
                MessageBox.Show(status);
                MessageBox.Show("Error occured while publishing.");
            }

            publish.Enabled = false;
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
            deploy.Enabled = false;
        }
               
        private void rootPath_Click(object sender, EventArgs e)
        {
            openZipFileDialog.ShowDialog();
            string filePath = openZipFileDialog.FileName;
            projectRoot.Text = filePath;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSite = sitesCombo.SelectedValue.ToString();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            //ApplicationApplicationDeployToolss.ServiceReference1.Service1Client obj = new ApplicationApplicationDeployToolss.ServiceReference1.Service1Client();
            string[] ds = client.GetAppBySite(selectedSite);
            appCombo.DataSource = ds;

            string[] pools = client.GetAllPools();
            poolsCombo.DataSource = pools;
        }

        private void appcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedApp = appCombo2.SelectedValue.ToString();
            string selectedSite = sitesCombo2.SelectedValue.ToString();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            string virtualPath = client.GetAppVirtualPath(selectedApp, selectedSite);
            currentVirtualPath.Text = "Current Path of " + selectedApp + "=> " + virtualPath.Replace("%SystemDrive%", "C:");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSite = sitesCombo2.SelectedValue.ToString();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            string[] ds = client.GetAppBySite(selectedSite);
            appCombo2.DataSource = ds;
        }

        private void setPool_Click(object sender, EventArgs e)
        {
            string status = "";
            string appName = appCombo.SelectedValue.ToString();
            string pool = poolsCombo.SelectedValue.ToString();
            string site = sitesCombo.SelectedValue.ToString();
            if (appName != "" && pool != "")
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
                client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
                status = client.SetAppPool(pool, appName, site);
            }
            else
            {
                status = "error";
            }

            if (status != "OK")
            {
                MessageBox.Show("Error occured while changing pool");
            }
            else
            {
                MessageBox.Show("Application pool for " + appName + " changes successfully");
                setPool.Enabled = false;
            }
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            string site = sitesCombo2.SelectedValue.ToString();
            string app = appCombo2.SelectedValue.ToString();
            string path = pathToMove.Text;

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            string status = client.MoveChangeAppPath(app, path, site);
            if (status == "OK")
            {
                MessageBox.Show("Application Moved");
                moveBtn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Some error occured");
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

        private void createAppPool_Click(object sender, EventArgs e)
        {
            bool flag;
            string poolName = newPoolName.Text.Trim();
            string netclr = netClr.SelectedValue.ToString();
            string pipeline = mngdPipeline.SelectedValue.ToString();
            if (startpoolbool.Checked)
            {
                flag = true;
            }else
            {
                flag = false;
            }

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            string result = client.CreateNewPool(poolName, netclr, pipeline, flag);
            if(result == "OK")
            {
                MessageBox.Show("App Pool Created");
            }
            else
            {
                MessageBox.Show("Some Error Occured");
            }
            
        }

        private void saveAppVirtDir_Click(object sender, EventArgs e)
        {
            string appvir = "virtual";
            string site = siteCombo3.SelectedValue.ToString();
            string pool = poolsCombo3.SelectedValue.ToString();
            string name = appVirDirName.Text.Trim();
            string virtualPath = virPath.Text.Trim();
            if (application.Checked == true)
            {
                appvir = "app";
            }

            if (virtualDir.Checked == true)
            {
                appvir = "virtual";
            }

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential(uname, pass, domain);
            client.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            string result = client.CreateAppVir(site, pool, name, virtualPath, appvir);
            if (result == "OK")
            {
                MessageBox.Show("Done !!!");
            }
            else
            {
                MessageBox.Show("Some Error Occured");
            }
        }

    }
}
