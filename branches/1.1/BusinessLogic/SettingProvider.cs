using System;using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;
namespace BusinessLogic
{
    public class SettingProvider
    {
        public static string AdminEmail()
        {
            return ConfigurationSettings.AppSettings["AdminEmail"];
        }
        public static string MusesterNumberPrifix()
        {
            return ConfigurationSettings.AppSettings["MusesterNumberPrefix"];
        }
        public static Boolean IsLoggerEnable()
        {
            return Convert.ToBoolean(ConfigurationSettings.AppSettings["IsLoggerEnable"]);
        }
        public static Boolean IsSiteCoreLoggerEnable()
        {
            return Convert.ToBoolean(ConfigurationSettings.AppSettings["IsSiteCoreLoggerEnable"]);
        }
        public static string SMTPHostIP()
        {
            return ConfigurationSettings.AppSettings["SMTPserver"];
        }
        public static string EmailTemplateVirtualPath()
        {
            return ConfigurationSettings.AppSettings["EmailTempletePath"];
        }
        public static string EmailTemplateAbsulutePath()
        {
            return HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["EmailTempletePath"]);
        }
        public static Boolean IsUserConformationon()
        {
            return Convert.ToBoolean(ConfigurationSettings.AppSettings["IsUserConformationON"]);
        }
        public static string SitePrefixurl()
        {
            return ConfigurationSettings.AppSettings["SitePrefixUrl"];
        }
        public static string DefaultAlbumName()
        {
            return "Home";
        }
        public static int GetMyWorkSizeLimit()
        {
            return Convert.ToInt32(ConfigurationSettings.AppSettings["RepositorySize"]); 
        }
    }
}
