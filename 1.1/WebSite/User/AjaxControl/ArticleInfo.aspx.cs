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

public partial class User_AjaxControl_ArticleInfo : AjaxPage
{

    private void FormValidation()
    {
        lnkUpdateArticle.EnableValidation = true;
        lnkAddArticle.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddArticle.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdateArticle.ClientID);
        objValidate.DrowDownMendatory(ddCource, "Please select Cource ", this.Page, "0");
        objValidate.DrowDownMendatory(ddSubject, "Please select Subject ", this.Page, "0");
        objValidate.Medatory(txtTitle, "Please enter Title", this.Page);
        


    }
    private void AddData()
    {
        try
        {

            Guid ArticleID = Guid.NewGuid();

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID) == "") { throw new Exception("Please Enter Title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter Description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (HtmlHelper.ControlValue(txtMetaDescription.ClientID) == "") { throw new Exception("Please Enter Meta Description"); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "0" || HtmlHelper.ControlValue(ddCource.ClientID) == "") { throw new Exception("Please select Cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if ((HtmlHelper.ControlValue(ddSubject.ClientID)) == "" || (HtmlHelper.ControlValue(ddSubject.ClientID)) == "0") { throw new Exception("Please Select Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            int Rating = 0;

            DateTime ModifiedDate = DateTime.Now;

            new ArticleController().Add(ArticleID, LoginUserID, Title, Description, MetaDescription, InstituteCourceID, InstituteSubjectID, Tag, Rating, ModifiedDate);
            Response.Redirect("~/User/AjaxControl/Article.aspx?arid=" + ArticleID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }
    public void PreventData()
    {


        txtTitle.Text = HtmlHelper.ControlValue(txtTitle.ClientID);

        txtDescription.Text = HtmlHelper.ControlValue(txtDescription.ClientID);

        txtMetaDescription.Text = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

        new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID)), HtmlHelper.ControlValue(ddSubject.ClientID));
        new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, HtmlHelper.ControlValue(ddCource.ClientID));

        txtTag.Text = HtmlHelper.ControlValue(txtTag.ClientID);


    }
    private void EditData()
    {
        try
        {

            Guid ArticleID = ID;

            int LoginUserID = new UserAuthontication().LoggedInUserID;


            string Title; if (HtmlHelper.ControlValue(txtTitle.ClientID) == "") { throw new Exception("Please Enter Title"); } Title = HtmlHelper.ControlValue(txtTitle.ClientID);

            string Description; if (HtmlHelper.ControlValue(txtDescription.ClientID) == "") { throw new Exception("Please enter Description"); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            string MetaDescription; if (HtmlHelper.ControlValue(txtMetaDescription.ClientID) == "") { throw new Exception("Please Enter Meta Description"); } MetaDescription = HtmlHelper.ControlValue(txtMetaDescription.ClientID);

            int InstituteCourceID; if (HtmlHelper.ControlValue(ddCource.ClientID) == "0" || HtmlHelper.ControlValue(ddCource.ClientID) == "") { throw new Exception("Please select Cource"); } InstituteCourceID = Convert.ToInt32(HtmlHelper.ControlValue(ddCource.ClientID));

            int InstituteSubjectID; if ((HtmlHelper.ControlValue(ddSubject.ClientID)) == "" || (HtmlHelper.ControlValue(ddSubject.ClientID)) == "0") { throw new Exception("Please Select Subject"); } InstituteSubjectID = Convert.ToInt32(HtmlHelper.ControlValue(ddSubject.ClientID));

            string Tag; if (false) { throw new Exception(""); } Tag = HtmlHelper.ControlValue(txtTag.ClientID);

            //int Rating; if (false) { throw new Exception(""); } Rating = Convert.ToInt32(HtmlHelper.ControlValue(ddRating.ClientID));

            DateTime ModifiedDate = DateTime.Now;

            new ArticleController().UpdateByArticleID(ArticleID, LoginUserID, Title, Description, MetaDescription, InstituteCourceID, InstituteSubjectID, Tag, ModifiedDate);

            Response.Redirect("~/User/AjaxControl/Article.aspx?arid=" + ArticleID.ToString());
        }
        catch (Exception ex)
        {
            PreventData();
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new ArticleController().GetbyArticleID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtTitle.Text = data.Title;

            txtDescription.Text = data.Description;

            txtMetaDescription.Text = data.MetaDescription;

            new InstituteSubjectController().BindInstituteSubject(ddSubject, Convert.ToInt32(data.InstituteCourceID.ToString()), data.InstituteSubjectID.ToString());
            new InstituteCourceController().BindInstituteCource(ddCource, new UserAuthontication().UserInstituteID, data.InstituteCourceID.ToString());

            txtTag.Text = data.Tag;


        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["arid"]);
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
        new JScripter.TinyMCE(this.Page).Create();
        if (Request.Params["arid"] != null)
        {
            AjaxState["arid"] = Request.Params["arid"];
            BindData();
            lnkAddArticle.Visible = false;
        }
        else
        {

            lnkUpdateArticle.Visible = false;
            new InstituteCourceController().BindInstituteCourceByLoginUserID(ddCource, new UserAuthontication().UserInstituteID,new UserAuthontication().LoggedInUserID);
        }
        ddCource.Attributes["onchange"] = string.Format("ddChange('#{0}','#{1}','{2}');", ddCource.ClientID, "ddrep", (ResolveUrl("~/User/Service.aspx") + "?icid="));
    }

}
