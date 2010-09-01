using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Web;
using BusinessLogic.Entity;

namespace BusinessLogic
{
    public class UserContentDirectoryHelper
    {
        public static List<UserFiles> GetAllUserImage(string UserName)
        {
            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Image/"+UserName+"/");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string[] AllFiles = Directory.GetFileSystemEntries(FolderPath);
            List<UserFiles> data = new List<UserFiles>();
            for(int i=0;i<AllFiles.Length;i++)
            {
                string filepath = AllFiles[i];
                filepath = filepath.Replace(ConfigurationSettings.AppSettings["WebSitePhysicalPath"], "~");
                UserFiles dfile=new UserFiles();
                dfile.FilePath = filepath;
                data.Add(dfile);
            }
            return data;
        }
    }
}
