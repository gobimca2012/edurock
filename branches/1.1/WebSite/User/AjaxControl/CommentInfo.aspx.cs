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

public partial class User_AjaxControl_CommentInfo : AjaxPage
{

    private string _ContentID
    {
        get
        {
            return AjaxState["conid"];
        }
    }
    private int _ContentType
    {
        get
        {
            return Convert.ToInt32(AjaxState["ctype"]);
        }
    }
    private void AddData()
    {
        try
        {

            Guid CommentID = Guid.NewGuid();

            string ContentID = _ContentID;

            int ContentType = _ContentType;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string CommentText; if (HtmlHelper.ControlValue(txtCommentText.ClientID)=="") { throw new Exception("Please enter Comment"); } CommentText = HtmlHelper.ControlValue(txtCommentText.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new CommentController().Add(CommentID, ContentID, ContentType, LoginUserID, CommentText, ModifiedDate);
            objLoader.LoadPage("#comment", ResolveUrl("~/User/AjaxControl/CommentInfoView.aspx") + "?conid=" + _ContentID + "&ctype=" + _ContentType.ToString());
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

            Guid CommentID = ID;

            string ContentID = _ContentID;


            int ContentType = _ContentType;

            int LoginUserID = new UserAuthontication().LoggedInUserID;

            string CommentText; if (false) { throw new Exception(""); } CommentText = HtmlHelper.ControlValue(txtCommentText.ClientID);

            DateTime ModifiedDate = DateTime.Now;

            new CommentController().UpdateByCommentID(CommentID, ContentID, ContentType, LoginUserID, CommentText, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new CommentController().GetbyCommentID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            
            
            txtCommentText.Text = data.CommentText;

        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(AjaxState["cmid"]);
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
        if (Request.Params["ctype"] != null)
        {
            AjaxState["ctype"] = Request.Params["ctype"];
        }
        if (Request.Params["conid"] != null)
        {
            AjaxState["conid"] = Request.Params["conid"];
        }
        if (Request.Params["cmid"] != null)
        {
            AjaxState["cmid"] = Request.Params["cmid"];
            BindData();
            lnkAddComment.Visible = false;
        }
        else
        {
            
            lnkUpdateComment.Visible = false;
        }
    }

}
