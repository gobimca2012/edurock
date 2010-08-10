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

public partial class College_Ajaxer_InstituteUser : AjaxPage
{
    public int _InstituteID
    {
        get
        {
            return Convert.ToInt32(Request.Params["iid"]);
        }

    }
    protected override void OnLoad(EventArgs e)
    {
        IsLogginMandatory = false;
        Binddata();
        JScripter.Effect objEffect = new JScripter.Effect(this.Page, false);
        objEffect.Collapspanel("#instituteuserboxtrigger", "#instituteuserbox");
        base.OnLoad(e);
    }
    
    private void Binddata()
    {

        var data = new UserController().GetUser(0,_InstituteID);
        ListUser.DataSource = data;
        ListUser.DataBind();
    }
}
