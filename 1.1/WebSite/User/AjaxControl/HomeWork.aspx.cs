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

public partial class User_AjaxControl_HomeWork : AjaxPage
{

    private void BindData()
    {
        var dataBunch = new HomeWorkController().GetbyHomeWorkID(ID);
        if (dataBunch.Count > 0)
        {
            HomeWork data = dataBunch[0];
            if (data.HomeWorkID != null)

                lblHomeWorkID.InnerHtml = data.HomeWorkID.ToString();

            if (data.LoginUserID != null)

                lblLoginUserID.InnerHtml = data.LoginUserID.ToString();

            if (data.Title != null)

                lblTitle.InnerHtml = data.Title.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.ShortDescription != null)

                lblShortDescription.InnerHtml = data.ShortDescription.ToString();

            if (data.InstituteCourceID != null)

                lblInstituteCourceID.InnerHtml = data.InstituteCourceID.ToString();

            if (data.InstituteSubjectID != null)

                lblInstituteSubjectID.InnerHtml = data.InstituteSubjectID.ToString();

            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();
        }

    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["hwid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["hwid"] != null)
        {
            AjaxState["hwid"] = Request.Params["hwid"];
        }
        BindData();
        MakeLinks();
    }
    private void MakeLinks()
    {
        lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/HomeWorkInfo.aspx") + "?hwid=" + ID.ToString();
    }

}
