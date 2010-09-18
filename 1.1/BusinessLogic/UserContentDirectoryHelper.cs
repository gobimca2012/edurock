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
                string temp = filepath.Substring(0, filepath.IndexOf(ConfigurationSettings.AppSettings["PhysicalFolder"]) + ConfigurationSettings.AppSettings["PhysicalFolder"].Length);
                filepath = filepath.Replace(temp, "~");
                
                UserFiles dfile=new UserFiles();
                dfile.FilePath = filepath;
                dfile.Imagepath = filepath;
                data.Add(dfile);
            }
            return data;
        }
        public static List<UserFiles> GetAllUserDocument(string UserName)
        {
            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Document/" + UserName + "/");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string[] AllFiles = Directory.GetFileSystemEntries(FolderPath);
            List<UserFiles> data = new List<UserFiles>();
            for (int i = 0; i < AllFiles.Length; i++)
            {
                string filepath = AllFiles[i];
                string temp = filepath.Substring(0, filepath.IndexOf(ConfigurationSettings.AppSettings["PhysicalFolder"]) + ConfigurationSettings.AppSettings["PhysicalFolder"].Length);
                filepath = filepath.Replace(temp, "~");

                UserFiles dfile = new UserFiles();
                dfile.FilePath = filepath;
                dfile.Imagepath = ConfigurationSettings.AppSettings["DocumentIcon"].ToString();
                data.Add(dfile);
            }
            return data;
        }
        public static List<UserFiles> GetAllUserAudio(string UserName)
        {
            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Audio/" + UserName + "/");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string[] AllFiles = Directory.GetFileSystemEntries(FolderPath);
            List<UserFiles> data = new List<UserFiles>();
            for (int i = 0; i < AllFiles.Length; i++)
            {
                string filepath = AllFiles[i];
                string temp = filepath.Substring(0, filepath.IndexOf(ConfigurationSettings.AppSettings["PhysicalFolder"]) + ConfigurationSettings.AppSettings["PhysicalFolder"].Length);
                filepath = filepath.Replace(temp, "~");

                UserFiles dfile = new UserFiles();
                dfile.FilePath = filepath;
                dfile.Imagepath = ConfigurationSettings.AppSettings["AudioIcon"].ToString();
                data.Add(dfile);
            }
            return data;
        }
    }
}
