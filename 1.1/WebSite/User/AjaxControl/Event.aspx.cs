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

public partial class User_AjaxControl_Event : AjaxPage
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
        var dataBunch = new EventController().GetbyEventID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];
            
                
                

            if (data.LoginUserID != null)
            {
                ControlManager(data.LoginUserID);
                FullViewSideInfo1.LoginUserID = data.LoginUserID;
                FullViewSideInfo1.ModifiedDate =(DateTime) data.ModifiedDate;
                FullViewSideInfo1.CourceID =(int) data.InstituteCourceID;
                FullViewSideInfo1.SubjectID = (int)data.InstituteSubjectID;
            }
            if (data.Title != null)

                lblTitle.InnerHtml = data.Title.ToString();

            if (data.Description != null)

                lblDescription.InnerHtml = data.Description.ToString();

            if (data.MetaDescription != null)

                lblMetaDescription.InnerHtml = data.MetaDescription.ToString();

            if (data.StartDate != null)

                lblStartDate.InnerHtml = data.StartDate.ToString();

            if (data.EndDate != null)

                lblEndDate.InnerHtml = data.EndDate.ToString();

            //if (data.InstituteCourceID != null)

            //    lblInstituteCourceID.InnerHtml = data.InstituteCourceID.ToString();

            //if (data.InstituteSubjectID != null)

            //    lblInstituteSubjectID.InnerHtml = data.InstituteSubjectID.ToString();

            if (data.Tag != null)

                lblTag.InnerHtml = data.Tag.ToString();

            if (data.ContactPerson != null)

                lblContactPerson.InnerHtml = data.ContactPerson.ToString();

            if (data.ContactEmail != null)

                lblContactEmail.InnerHtml = data.ContactEmail.ToString();

            if (data.ContactPhone != null)

                lblContactPhone.InnerHtml = data.ContactPhone.ToString();

            //if (data.ModifiedDate != null)

            //    lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();
        }

    }

    private Guid ID
    {
        get
        {
            lnkEdit.NavigateUrl = ResolveUrl("~/User/AjaxControl/EventInfo.aspx") + "?evid=" + Request.Params["evid"];
            return new Guid(Request.Params["evid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData();
        
    }

}
