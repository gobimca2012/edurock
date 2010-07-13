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

public partial class User_AjaxControl_DocumentInfo : AjaxPage
{

    private int _DocumentType
    {
        get
        {
            return Convert.ToInt16(AjaxState["dtype"]);
        }
    }
    private int InstituteCourceID
    {
        get
        {
            return Convert.ToInt32(AjaxState["icid"]);
        }
    }
    private void AddData()
    {
        try
        {

            Guid DocumentID = Guid.NewGuid();

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int Rating = 0;

            string FilePath; if (false) { throw new Exception(""); } FilePath = HtmlHelper.ControlValue("filePath");

            int DocumentType = _DocumentType;

            int InstituteCourceID; if (false) { throw new Exception(""); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));
            int InstituteSubjectID; if (false) { throw new Exception(""); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue("ddSubject"));
            DateTime ModifiedDate = DateTime.Now;

            new DocumentController().Add(DocumentID, Name, Description, MetaDescription, Tag, LoginUserID, Rating, FilePath, DocumentType, InstituteCourceID, InstituteSubjectID, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/Document.aspx?did=" + DocumentID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {
        try
        {

            Guid DocumentID = ID;

            string Name; if (false) { throw new Exception(""); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int Rating = 0;

            string FilePath; if (false) { throw new Exception(""); } FilePath = HtmlHelper.ControlValue("filePath");

            int DocumentType = _DocumentType;

            DateTime ModifiedDate = DateTime.Now;

            new DocumentController().UpdateByDocumentID(DocumentID, Name, Description, MetaDescription, Tag, LoginUserID, Rating, FilePath, DocumentType, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/Document.aspx?did=" + DocumentID.ToString());
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new DocumentController().GetbyDocumentID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            txtName.Text = data.Name;

            txtDescription.Text = data.Description;

            txtMetaDescription.Text = data.MetaDescription;

            txtTag.Text = data.Tag;
            img.ImageUrl = ResolveUrl(data.FilePath);
            filePath.Value = data.FilePath;
            if (data.DocumentCources.Count > 0)
            {
                new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, data.DocumentCources[0].InstituteCourceID.ToString());
                new InstituteSubjectController().BindInstituteSubject(ddSubject, data.DocumentCources[0].InstituteCourceID, data.DocumentCources[0].SubjectID.ToString());
            }
            else
            {
                new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID);
            }
        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["did"]);
        }
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();

    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsEventChange)
        {

        }
        else
        {
            JScripter.PopUp objPopUp = new JScripter.PopUp(this.Page, false);

            if (Request.Params["icid"] != null)
            {
                AjaxState["icid"] = Request.Params["icid"];

            }

            if (Request.Params["dtype"] != null)
            {
                AjaxState["dtype"] = Request.Params["dtype"];
            }
            objPopUp.IframePopUp(lnkFilePopUp, ResolveUrl("~/User/UploadPhoto.aspx") + "?uptype=" + _DocumentType.ToString(), "ipop", "500", "500", ResolveUrl("~/User/AjaxControl/UploadResponse.aspx"), "#popupresponce");
            //objPopUp.IframePopUp(lnkFilePopUp, ResolveUrl("~/User/UploadPhoto.aspx")+"?uptype="+_DocumentType.ToString(), "#ipop");
            if (Request.Params["did"] != null)
            {
                AjaxState["did"] = Request.Params["did"];
                BindData();
                lnkAddDocument.Visible = false;

            }
            else
            {
                //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
                lnkUpdateDocument.Visible = false;
                newAdd.Visible = false;
                new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID);

            }

        }
        //this.DropDownPostBack(ddCource, "#contentbox", "#dropdownP");
        ddCource.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddCource.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?icid="));
        //string script = string.Format("$('#{0}').BindDD('#{1}','{2}');", ddCource.ClientID, ddSubject.ClientID,( ResolveUrl("~/User/Service.aspx") + "/GetSubject").Replace(".aspx",""));
        //JScripter.JScripter.InjectScript(script, this.Page);
    }
    protected override void OnAjaxDropDownChange(string e)
    {

        base.OnAjaxDropDownChange(e);
    }


}
