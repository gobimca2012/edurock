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

public partial class User_UserControl_UserBox : System.Web.UI.UserControl
{
    public int LoginUserID
    {
        get;
        set;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        var dataUser = new UserController().GetbyLoginUserID(LoginUserID);
        if (dataUser.Count > 0)
        {
            lnkTool.Text = dataUser[0].FirstName + " " + dataUser[0].LastName;
            img.ImageUrl=ImageHelper.ResolveURL(dataUser[0].PhotoPath);
            new JScripter.ToolTip(this.Page).AjaxToolTip(lnkTool, ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + LoginUserID.ToString(), "acont");
        }

    }
}
