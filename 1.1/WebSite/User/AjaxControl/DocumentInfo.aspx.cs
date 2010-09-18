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
    private void FormValidation()
    {
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddDocument.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateDocument.ClientID);
        objValidate.DrowDownMendatory(ddCource, "Please select Course ", this.Page, "0");
        objValidate.DrowDownMendatory(ddSubject, "Please select Subject ", this.Page, "0");
        objValidate.Medatory(txtName, "Please enter Title", this.Page);



    }
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

            string Name; if (HtmlHelper.ControlValue(txtName.ClientID) == "") { throw new Exception("Please enter Name"); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int Rating = 0;

            string FilePath; if (HtmlHelper.ControlValue("filePath") == "") { throw new Exception("Please select File"); } FilePath = HtmlHelper.ControlValue("filePath");

            int DocumentType = _DocumentType;

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "0" || HtmlHelper.ControlValue(ddCource.ClientID) == "") { throw new Exception("Please select course"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));
            int InstituteSubjectID; if (HtmlHelper.ControlValue("ddSubject") == "" || HtmlHelper.ControlValue("ddSubject") == "0") { throw new Exception("Please select Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue("ddSubject"));
            DateTime ModifiedDate = DateTime.Now;

            new DocumentController().Add(DocumentID, Name, Description, MetaDescription, Tag, LoginUserID, Rating, FilePath, DocumentType, InstituteCourceID, InstituteSubjectID, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} has been Added Successfully",  Name);
            Response.Redirect("~/User/AjaxControl/Document.aspx?did=" + DocumentID.ToString(), true);
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    public void PreventData()
    {

        txtName.Text = HtmlHelper.ControlValue(txtName.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtMetaDescription.Text = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

        txtTag.Text = HtmlHelper.ControlValue(txtTag.ClientID);

        new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID)), HtmlHelper.ControlValue(ddSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddCource.ClientID));





    }

    private void EditData()
    {
        try
        {
            Guid DocumentID = ID;

            string Name; if (HtmlHelper.ControlValue(txtName.ClientID) == "") { throw new Exception("Please enter Name"); } Name = HtmlHelper.ControlValue(txtName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (false) { throw new Exception(""); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            int Rating = 0;

            string FilePath; if (HtmlHelper.ControlValue("filePath") == "") { throw new Exception("Please select File"); } FilePath = HtmlHelper.ControlValue("filePath");

            int DocumentType = _DocumentType;

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "0" || HtmlHelper.ControlValue(ddCource.ClientID) == "") { throw new Exception("Please select course"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));
            int InstituteSubjectID; if (HtmlHelper.ControlValue("ddSubject") == "" || HtmlHelper.ControlValue("ddSubject") == "0") { throw new Exception("Please select Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue("ddSubject"));

            DateTime ModifiedDate = DateTime.Now;

            new DocumentController().UpdateByDocumentID(DocumentID, Name, Description, MetaDescription, Tag, LoginUserID, Rating, FilePath, DocumentType, ModifiedDate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} has been Updated Successfully", Name);
            Response.Redirect("~/User/AjaxControl/Document.aspx?did=" + DocumentID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
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
                new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
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
        FormValidation();
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
            objPopUp.IframePopUp(lnkFilePopUp, ResolveUrl("~/User/UploadPhoto.aspx") + "?uptype=" + _DocumentType.ToString(), "ipop", "600", "600", ResolveUrl("~/User/AjaxControl/UploadResponse.aspx"), "#popupresponce");
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
                new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);

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
