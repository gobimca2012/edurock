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

public partial class User_AjaxControl_MessageInfo : AjaxPage
{


    private void AddData()
    {
        try
        {

            Guid MessageID = Guid.NewGuid();

            string Subject; if (false) { throw new Exception(""); } Subject = HtmlHelper.ControlValue(txtSubject.ClientID);

            string MessageText; if (false) { throw new Exception(""); } MessageText = HtmlHelper.ControlValue(txtMessageText.ClientID);

            var data=new LoginUserController().GetbyUsername(HtmlHelper.ControlValue(txtUsername.ClientID));
            if (data.Count == 0)
            {
                throw new Exception("Please enter Correct Username");
            }

            int ToLoginUserID = data[0].LoginUserID;

            int FromLoginUserID = new UserAuthontication().LoggedInUserID;

            
            DateTime ModifiedDate = DateTime.Now;

            new MessageController().MessageAdd(MessageID, Subject, MessageText, ToLoginUserID, FromLoginUserID, ModifiedDate);
            Response.Redirect("~/Admin/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }





    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["mid"]);
        }
    }
    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();

    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["mid"] != null)
        {
            AjaxState["mid"] = Request.Params["mid"];
           
            lnkAddMessage.Visible = false;
        }
        else
        {
            
            lnkUpdateMessage.Visible = false;
        }
    }

}
