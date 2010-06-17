using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using BusinessLogic;
using DataEntity;
public partial class CallBack :AjaxPage
{
    private int ExamID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["eid"]);
        }
    }
    private DateTime StartTime
    {
        get
        {
            if (Session[SessionName.ExamStartTime.ToString()] != null)
            {
                return Convert.ToDateTime(Session[SessionName.ExamStartTime.ToString()].ToString());
            }
            else
            {
                var data=new UserExamController().GetbyExamID(ExamID,new UserAuthontication().LoggedInUserID);
                if (data.Count > 0)
                {
                    if (data[0].StartTime != null)
                    {
                        return data[0].StartTime;
                    }
                    else
                    {

                        return DateTime.Now;
                    }
                }
                else
                {
                    return DateTime.Now;
                }
            }
        }
        set
        {
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["tm"] != null)
        {
            TimeSpan RemainingTime = (TimeSpan)(StartTime.AddHours(2) - DateTime.Now);
            string Time = RemainingTime.Hours.ToString() + ":" + RemainingTime.Minutes.ToString();
            Response.Write(Time);
        }
    }
}
