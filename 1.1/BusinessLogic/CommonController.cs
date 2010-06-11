using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataEntity;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;
namespace BusinessLogic
{
    public class CommonController
    {
        public static Control GetControl(string VirtualPath)
        {
            Page page =(Page)HttpContext.Current.Handler;
            Control uc =
      (Control)page.LoadControl(page.ResolveUrl(VirtualPath));
            return uc;

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
            return Date.ToString("MM.dd.yyyy");
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
            else
            {
                return "";
            }
        }
    }
}
