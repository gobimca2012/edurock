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

public partial class User_AjaxControl_Message : AjaxPage
{

    private void BindData(Guid ID)
    {
        var dataBunch = new MessageController().GetFullMessage(ID);

        if (dataBunch.Count > 0)
        {
            GetFullMessageResult data;
            data = dataBunch[0];

            if (data.MessageID != null)

                lblMessageID.InnerHtml = data.MessageID.ToString();

            if (data.Subject != null)

                lblSubject.InnerHtml = data.Subject.ToString();

            if (data.MessageText != null)

                lblMessageText.InnerHtml = data.MessageText.ToString();

            if (data.ToLoginUserID != null)

                lblToLoginUserID.InnerHtml = data.ToFullName.ToString();

            if (data.FromLoginUserID != null)

                lblFromLoginUserID.InnerHtml = data.FromFullName.ToString();

            if (data.FromProfilePic != null)
            {
                ImgFrom.ImageUrl=ImageHelper.ResolveURL(data.FromProfilePic);
            }
            if (data.ToProfilePic != null)
            {
                ImgTo.ImageUrl=ImageHelper.ResolveURL(data.ToProfilePic);
            }



            if (data.ModifiedDate != null)

                lblModifiedDate.InnerHtml = data.ModifiedDate.ToString();
        }
    }

    private Guid ID
    {
        get
        {
            return new Guid(Request.Params["mid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        BindData(ID);
    }

}
