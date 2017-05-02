using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeployTools.App
{
    interface IPublDepyApp
    {
        string DoPublish(string folderpath, string appName, string slnPath, string mainAppPath, string mainAppName, string relese);

        string DoDeploy(string mainAppPath, string mainAppName, string website, string servername, string username, string password, string flag);

        string EditXml(string folderpath, string appName, string relese, string website, string flag, string moduledepPath, string deplyAppName);

        string SetEnvironmentalVariable();
    }
}
