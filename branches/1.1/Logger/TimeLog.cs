using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Web;
namespace Logger
{
    public class TimeLog
    {
        private TimeSpan _startTime;
        private string _LogTitle="";
        public TimeLog()
        {
            _startTime = DateTime.Now.TimeOfDay;
        }
        public TimeLog(string LogTitle)
        {
            _startTime = DateTime.Now.TimeOfDay;
            _LogTitle = LogTitle;
        }
        public void StopTime()
        {
            if (Convert.ToBoolean(ConfigurationSettings.AppSettings["EnableLog"].ToString()))
            {
                string FilePath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["logfile"]) + "/" + String.Format("{0:d-M-yyyy}", DateTime.Now) + "/TimeLog.txt";
                string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["logfile"]) + "/" + String.Format("{0:d-M-yyyy}", DateTime.Now) + "/";
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                //string fileLines=File.ReadAllText(FilePath);


                string fileLines = "";
                fileLines += "\r\n-------------------------------------  \r\n";
                fileLines += _LogTitle;
                fileLines += "\r\n";
                fileLines += (DateTime.Now.TimeOfDay - _startTime).ToString();
                fileLines += "\r\n-------------------------------------  \r\n";
                File.AppendAllText(FilePath, fileLines);
            }
        }
        public static bool ErrorWrite(string ErrorText,string ExectiptionMessage,string LineNumber)
        {
            if (Convert.ToBoolean(ConfigurationSettings.AppSettings["EnableLog"].ToString()))
            {
                string FilePath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["logfile"]) + "/" + String.Format("{0:d-M-yyyy}", DateTime.Now) + "/ErrorLog.txt";
                string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["logfile"]) + "/" + String.Format("{0:d-M-yyyy}", DateTime.Now) + "/";
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                //string fileLines=File.ReadAllText(FilePath);


                string fileLines = "";
                fileLines += "\r\n-------------------------------------  \r\n";
                fileLines += "Title :" + ErrorText;
                fileLines += "\r\n";
                fileLines += "Exectiption :" + ExectiptionMessage;
                fileLines += "\r\n";
                fileLines += "LineNumber :" + LineNumber;
                fileLines += "\r\n";
                fileLines += "Page URL :" + System.Web.HttpContext.Current.Request.RawUrl;
                fileLines += "\r\n-------------------------------------  \r\n";
                File.AppendAllText(FilePath, fileLines);
            }
            return true;
        }
    }
}
