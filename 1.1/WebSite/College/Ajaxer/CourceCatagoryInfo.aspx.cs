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

public partial class College_Ajaxer_CourceCatagoryInfo : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void AddData()
    {
        try
        {

            string CatagoryName; if (false) { throw new Exception(""); } CatagoryName = HtmlHelper.ControlValue(txtCatagoryName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CatagoryType = (int)CatagoryTypeEnum.CollegeCourceCatagory;

            DateTime ModifiedDate = DateTime.Now;

            new CourceCatagoryController().Add(CatagoryName, new UserAuthontication().LoggedInUserID, Description, CatagoryType, ModifiedDate);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData()
    {

        string CatagoryName; if (false) { throw new Exception(""); } CatagoryName = HtmlHelper.ControlValue(txtCatagoryName.ClientID);

        string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

        int CatagoryType = (int)CatagoryTypeEnum.CollegeCourceCatagory;

        DateTime ModifiedDate = DateTime.Now;

        new CourceCatagoryController().UpdateByLoginUserID(CatagoryName, new UserAuthontication().LoggedInUserID, Description, CatagoryType, ModifiedDate);
    }

    private void BindData(int ID)
    {
        var dataBunch = new CourceCatagoryController().GetbyCourceCatagoryID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            txtCatagoryName.Text = data.CatagoryName;

            txtDescription.Text = data.Description;


        }
    }

    private Guid ID
    {
        get
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["id"] != null)
                {
                    return new Guid(Request.QueryString["id"]);
                }
                else
                {
                    return Guid.Empty;
                }
            }
            else
            {
                return Guid.Empty;
            }
        }



    }
    private bool IsEdit
    {
        get
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["id"] != null)
                {

                    //			ID = new Guid(Request.QueryString["id"]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }

    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
        Response.Redirect("~/College/Ajaxer/CourceCatagoryInfoView.aspx");
    }
}
