using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataEntity;

using System.Web;
using System.Web.UI.WebControls;
using System.Configuration;
using System.IO;
using Common;
using System.Web.UI;
namespace BusinessLogic
{
    public class CommonController
    {
        public static Control GetControl(string VirtualPath)
        {
            Page page = (Page)HttpContext.Current.Handler;
            Control uc =
      (Control)page.LoadControl(page.ResolveUrl(VirtualPath));
            return uc;

        }
        public static string GetTime(DateTime Date1, DateTime Date2)
        {
            return (Date1.Subtract(Date2)).ToString();
        }
        public static void BindQuestionType(System.Web.UI.WebControls.DropDownList dd)
        {

            ListItem newItem1 = new ListItem();
            newItem1.Text = "Single Choice";
            newItem1.Value = "1";
            dd.Items.Add(newItem1);
            ListItem newItem2 = new ListItem();
            newItem2.Text = "Multiple Choice";
            newItem2.Value = "2";
            dd.Items.Add(newItem2);
            ListItem newItem3 = new ListItem();
            newItem3.Text = "Single Fill in the Blank";
            newItem3.Value = "0";
            dd.Items.Add(newItem3);
            ListItem newItem4 = new ListItem();
            newItem4.Text = "Multiple Fill in The Blank";
            newItem4.Value = "0";
            dd.Items.Add(newItem4);
            ListItem newItem = new ListItem();
            newItem.Text = "Select";
            newItem.Value = "0";
            dd.Items.Add(newItem);
        }
        public static string GetDate(DateTime Date)
        {
            return Date.ToString(" dddd, dd MMMM yyyy");
        }
        public static string GetRemainningDays(DateTime Date)
        {
            TimeSpan dd = Date.Subtract(DateTime.Now);
            return dd.Days.ToString();
        }
        public static string GetQuestionType(int QuestionType)
        {
            if (QuestionType == 1)
            {
                return "Single Choice";
            }
            else if (QuestionType == 2)
            {
                return "Multiple Choice";
            }
            else if (QuestionType == 3)
            {
                return "Single Fill in the Blank";
            }
            else
            {
                return "";
            }
        }
        public static string GetValueFromRequestparam(string ControlID)
        {
            var data = (from p in HttpContext.Current.Request.Params.AllKeys where p.Contains(ControlID) select p).ToList();
            if (data.Count > 0)
            {
                return HttpContext.Current.Request.Params[data[0]];
            }
            else
            {
                return "";
            }
        }
        public static void BindMonth(DropDownList dd)
        {
            int year = DateTime.Now.Year;
            ListItem new_Item = new ListItem();
            new_Item.Text = "Month";
            new_Item.Value = "0";
            dd.Items.Add(new_Item);
            for (int month = 1; month < 13; month++)
            {
                ListItem li = new ListItem();
                //li.Text = new DateTime(year, month, 1).ToString("{0:dddd, MMMM d, yyyy}");//dtfi.GetMonthName(month);
                li.Text = new DateTime(year, month, 1).ToString("MMMM");//dtfi.GetMonthName(month);
                li.Value = month.ToString();
                dd.Items.Add(li);
            }
            // dd.SelectedValue = DateTime.Now.Month.ToString();
        }
        public static void BindYear(DropDownList dd)
        {
            ListItem new_Item = new ListItem();
            new_Item.Text = "Year";
            new_Item.Value = "0";
            dd.Items.Add(new_Item);
            for (int i = DateTime.Now.Year; i > 1900; i--)
            {
                ListItem new_Itemf = new ListItem();
                new_Itemf.Text = i.ToString();
                new_Itemf.Value = i.ToString();
                dd.Items.Add(new_Itemf);
            }
        }
        public static void BindDay(DropDownList dd)
        {
            ListItem new_Item = new ListItem();
            new_Item.Text = "Days";
            new_Item.Value = "0";
            dd.Items.Add(new_Item);
            for (int i = 1; i <= 31; i++)
            {
                ListItem new_Itemf = new ListItem();
                new_Itemf.Text = i.ToString();
                new_Itemf.Value = i.ToString();
                dd.Items.Add(new_Itemf);
            }
        }
        public static DateTime GetDate(int day, int month, int Year)
        {
            return new DateTime(Year, month, day);
        }
        public string UploadImage(FileUpload fl)
        {

            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Image/");
            FolderPath += new UserAuthontication().LoggedInUserName + "/";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string FilePath = FolderPath + "/" + fl.FileName;
            string ReturnFilePath = ConfigurationSettings.AppSettings["Repository"] + "/Image/" + new UserAuthontication().LoggedInUserName + "/" + fl.FileName;
            fl.SaveAs(FilePath);
            return ReturnFilePath;
        }
        public static string GetFileNameFromFilePath(string FilePath)
        {
            int startIndex=FilePath.LastIndexOf('\\')+2;
            string repath=FilePath.Substring(startIndex, FilePath.Length - startIndex);
            return repath;
        }
        public string UploadAudio(FileUpload fl)
        {

            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Audio/");
            FolderPath += new UserAuthontication().LoggedInUserName + "/";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string FilePath = FolderPath + "/" + fl.FileName;
            string ReturnFilePath = ConfigurationSettings.AppSettings["Repository"] + "/Audio/" + new UserAuthontication().LoggedInUserName + "/" + fl.FileName;
            fl.SaveAs(FilePath);
            return ReturnFilePath;
        }
        public string UploadVideo(FileUpload fl)
        {

            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Video/");
            FolderPath += new UserAuthontication().LoggedInUserName + "/";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string FilePath = FolderPath + "/" + fl.FileName;
            string ReturnFilePath = ConfigurationSettings.AppSettings["Repository"] + "/Video/" + new UserAuthontication().LoggedInUserName + "/" + fl.FileName;
            fl.SaveAs(FilePath);
            return ReturnFilePath;
        }
        public string UploadDocument(FileUpload fl)
        {

            string FolderPath = HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["Repository"] + "/Document/");
            FolderPath += new UserAuthontication().LoggedInUserName + "/";
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string FilePath = FolderPath + "/" + fl.FileName;
            string ReturnFilePath = ConfigurationSettings.AppSettings["Repository"] + "/Document/" + new UserAuthontication().LoggedInUserName + "/" + fl.FileName;
            fl.SaveAs(FilePath);
            return ReturnFilePath;
        }
    }
}
