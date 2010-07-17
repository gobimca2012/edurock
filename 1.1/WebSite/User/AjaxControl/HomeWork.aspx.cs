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
    private void ControlManager(int LoginUserID)
    {
        if (new UserAuthontication().IsOwn(LoginUserID))
        {
            lnkEdit.Visible = true;
            
        }
    }
    private void BindData()
    {
        var dataBunch = new HomeWorkController().GetbyHomeWorkID(ID);
        if (dataBunch.Count > 0)
        {
            HomeWork data = dataBunch[0];
            if (data.HomeWorkID != null)
            {
                //lblHomeWorkID.InnerHtml = data.HomeWorkID.ToString();
            }

            if (data.LoginUserID != null)
            {
                //lblLoginUserID.InnerHtml = data.LoginUserID.ToString();
                ControlManager(data.LoginUserID);
                var dataUser = new UserController().GetbyLoginUserID(data.LoginUserID);
                if (dataUser.Count > 0)
                {
                    lnkTool.Text = dataUser[0].FirstName + " " + dataUser[0].LastName;
                    new JScripter.ToolTip(this.Page).AjaxToolTip(lnkTool, ResolveUrl("~/User/AjaxControl/Upop.aspx") + "?lid=" + data.LoginUserID.ToString(), "acont");
                }
            }

            if (data.Title != null)

                lblTitle.InnerHtml = data.Title.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.ShortDescription != null)

                lblShortDescription.InnerHtml = data.ShortDescription.ToString();

            if (data.InstituteCourceID != null)

                lblInstituteCourceID.InnerHtml =new InstituteCourceController().GetInstituteCourceName((int)data.InstituteCourceID);

            if (data.InstituteSubjectID != null)

                lblInstituteSubjectID.InnerHtml =new InstituteSubjectController().GetInstituteSubjectName((int)data.InstituteSubjectID);

            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml =CommonController.GetDate(Convert.ToDateTime( data.ModifiedDate.ToString()));
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
