using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ApplicationDeployTools.App
{
    class PublDepyApp : IPublDepyApp
    {
        public string DoDeploy(string mainAppPath, string mainAppName, string website, string servername, string username, string password, string flag)
        {
            string zipPath = "";
            string parameterPath = "";
            try
            {
                if (flag == "deploy")
                {
                    zipPath = mainAppPath + "\\" + mainAppName + ".zip";
                }
                else
                {
                    zipPath = mainAppPath + "\\" + mainAppName + "\\obj\\Debug\\Package\\" + mainAppName + ".zip";
                }

                string line1 = "-source:package=\"" + zipPath + "\"";
                string line2 = "-dest:auto,computerName=\"https://" + servername + ":8172/MSDeploy.axd?site=" + website + "\",username=\"" + username + "\",password=\"" + password + "\",authtype=\"Basic\",includeAcls=\"False\"";
                string line3 = "-verb:sync -disableLink:AppPoolExtension -disableLink:ContentExtension -disableLink:CertificateExtension";

                if (flag == "deploy")
                {
                    parameterPath = mainAppPath + "\\" + mainAppName + ".SetParameters.xml";
                }
                else
                {
                    parameterPath = mainAppPath + "\\" + mainAppName + "\\obj\\Debug\\Package\\" + mainAppName + ".SetParameters.xml";
                }

                string line4 = "-setParamFile:\"" + parameterPath + "\"";
                string line5 = "-allowUntrusted";

                string finalComand = "/c MSDeploy.exe " + line1 + " " + line2 + " " + line3 + " " + line4 + " " + line5;

                ProcessStartInfo startInfo = new ProcessStartInfo("CMD.exe", finalComand);
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                Process deployProcess = Process.Start(startInfo);
                string errors = deployProcess.StandardError.ReadToEnd();
                if (errors != "")
                {
                    //MessageBox.Show(errors);
                    return errors;
                }
                else
                {
                    return "OK";
                }

            }
            catch (Exception e)
            {
                return "NO";
            }
        }

        public string DoPublish(string folderpath, string appName, string slnPath, string mainAppPath, string mainAppName, string relese)
        {
            //string publishProfilePath = folderpath + "\\" + appName + "\\Properties\\PublishProfiles\\" + appName + ".pubxml";
            string command = "/c msbuild " + slnPath + " /p:IncludeAppPool=true /p:Configuration=" + relese + " /p:DeployOnBuild=true";

            ProcessStartInfo startInfo = new ProcessStartInfo("CMD.exe", command);
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;
            Process publishProcess = Process.Start(startInfo);
            string errors = publishProcess.StandardError.ReadToEnd();
            if (errors != "")
            {
                return errors;
            }
            else
            {
                return "OK";
            }
        }

        public string EditXml(string folderpath, string appName, string relese, string website, string flag, string moduledepPath, string deplyAppName)
        {
            string xmlPath = "";
            XmlDocument doc = new XmlDocument();
            if (flag == "publish")
            {
                xmlPath = folderpath + "\\" + appName + "\\obj\\" + relese + "\\Package\\" + appName + ".SetParameters.xml";
            }
            else
            {
                xmlPath = folderpath + "\\" + appName + ".SetParameters.xml";
            }

            doc.Load(@"" + xmlPath + "");
            XmlElement root = doc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("setParameter");
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["name"].Value == "IIS Web Application Name")
                {
                    if (moduledepPath == "")
                    {
                        node.Attributes["value"].Value = website + "/" + appName;
                    }
                    else
                    {
                        node.Attributes["value"].Value = website + "/" + moduledepPath + "/" + deplyAppName;
                    }

                }
            }

            doc.Save(@"" + xmlPath + "");
            return "OK";
        }

        public string SetEnvironmentalVariable()
        {
            string buildStatus = "";
            string deployStatus = "";
            string msbuildPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319";
            string msdeployPath = @"C:\Program Files (x86)\IIS\Microsoft Web Deploy V3";
            try
            {
                if (Directory.Exists(msbuildPath))
                {
                    string[] strPaths = GetCurrentSystemPaths();
                    string strFoundPath = Array.Find(strPaths, new PathMatcherPredicate(msbuildPath).MatchPath);
                    if (strFoundPath == null)
                    {
                        // Path not found. We now add it in.
                        int iSize = strPaths.Length;
                        // We increment the strPaths array by one more element.
                        Array.Resize(ref strPaths, iSize + 1);
                        // Append strNewPath into the strPaths array.
                        strPaths[iSize] = msbuildPath;
                        // We construct the system path string by concatenating
                        // all elements from the strPaths array, separated by a ';'.
                        string strNewSystemPath = ConcatStringArray(ref strPaths);
                        // Replace the current system path with strNewSystemPath.
                        System.Environment.SetEnvironmentVariable("Path", strNewSystemPath, EnvironmentVariableTarget.Machine);
                        MessageBox.Show("MSBuild Added and verified...");
                    }
                    buildStatus = "OK";
                }
                else
                {
                    MessageBox.Show("MSBuild Not found in C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319.. Please check if the file exists and if not please download and try again!!");
                    buildStatus = "error";
                }

                if (Directory.Exists(msdeployPath))
                {
                    string[] strPaths = GetCurrentSystemPaths();
                    string strFoundPath = Array.Find(strPaths, new PathMatcherPredicate(msdeployPath).MatchPath);
                    if (strFoundPath == null)
                    {
                        int iSize = strPaths.Length;
                        Array.Resize(ref strPaths, iSize + 1);
                        strPaths[iSize] = msdeployPath;
                        string strNewSystemPath = ConcatStringArray(ref strPaths);
                        System.Environment.SetEnvironmentVariable("Path", strNewSystemPath, EnvironmentVariableTarget.Machine);
                        MessageBox.Show("MSDeploy Added and verified...");
                    }
                    deployStatus = "OK";
                }
                else
                {
                    MessageBox.Show("MS Web Deploy Not found or installed in C:\\Program Files (x86)\\IIS\\Microsoft Web Deploy V3.. Please check if it exists and if not please download and try again!!");
                    deployStatus = "error";
                }
                if(buildStatus=="OK" && deployStatus == "OK")
                {
                    return "OK";
                }else
                {
                    return "addingError";
                }
                
            }
            catch(Exception e)
            {
                return e.ToString();
            }

            
        }

        public string[] GetCurrentSystemPaths()
        {
            string strPath = System.Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            string[] split = strPath.Split(new Char[] { ';' });
            return split;
        }

        public string ConcatStringArray(ref string[] strArray)
        {
            int iSize = strArray.Length;
            int i = 0;
            string strRet = strArray[0];
            for (i = 1; i < iSize; i++)
            {
                strRet += String.Format(";{0:S}", strArray[i]);
            }
            return strRet;
        }
    }
}
