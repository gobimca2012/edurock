﻿using System;
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

public partial class User_UserControl_UserToolTipLink1_1 : System.Web.UI.UserControl
{
    public int LoginUserID
    {
        get;
        set;
    }
    public int EditorLoginUserID
    {
        get;
        set;
    }
    public DateTime ModifiedDate
    {
        get;
        set;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (EditorLoginUserID > 0)
        {
            var dataUser = new UserController().GetbyLoginUserID(EditorLoginUserID);
            if (dataUser.Count > 0)
            {
                lnkETool.Text =  dataUser[0].FirstName + " " + dataUser[0].LastName;
                new JScripter.ToolTip(this.Page).AjaxToolTip(lnkETool, ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + LoginUserID.ToString(), "acont");
                lnkETool.Visible = true;
                lnke.Visible = true;
            }
        }
        else
        {
            var dataUser = new UserController().GetbyLoginUserID(LoginUserID);
            if (dataUser.Count > 0)
            {
                lnkTool.Text =  dataUser[0].FirstName + " " + dataUser[0].LastName;
                new JScripter.ToolTip(this.Page).AjaxToolTip(lnkTool, ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + LoginUserID.ToString(), "acont");
                lnkTool.Visible = true;
                lnkc.Visible = true;
            }
        }
        

        if (ModifiedDate != null)
        {
            lblDate.InnerText = CommonController.GetDate(ModifiedDate);
        }
    }
}