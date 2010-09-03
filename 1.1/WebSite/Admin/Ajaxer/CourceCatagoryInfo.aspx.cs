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

public partial class Admin_Ajaxer_CourceCatagoryInfo : AjaxPage
{


    private void AddData()
    {
        try
        {



            string CatagoryName; if (false) { throw new Exception(""); } CatagoryName = HtmlHelper.ControlValue(txtCatagoryName.ClientID);

            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CatagoryType = (int)CatagoryTypeEnum.CollegeCourceCatagory;

            DateTime ModifiedDate = DateTime.Now;

             new CourceCatagoryController().Add(CatagoryName, LoginUserID, Description, CatagoryType, ModifiedDate);
            Response.Redirect("~/Admin/Ajaxer/CourceCatagoryInfoView.aspx");
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


            string CatagoryName; if (false) { throw new Exception(""); } CatagoryName = HtmlHelper.ControlValue(txtCatagoryName.ClientID);

            int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CatagoryType = (int)CatagoryTypeEnum.CollegeCourceCatagory;

            DateTime ModifiedDate = DateTime.Now;

            new CourceCatagoryController().UpdateByCourceCatagoryID(ID, CatagoryName, LoginUserID, Description, CatagoryType, ModifiedDate);

            Response.Redirect("~/Admin/Ajaxer/CourceCatagoryInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData()
    {
        var dataBunch = new CourceCatagoryController().GetbyCourceCatagoryID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];



            txtCatagoryName.Text = data.CatagoryName;


            txtDescription.Text = data.Description;

        }
    }

    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["ccid"]);
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
        if (Request.Params["ccid"] != null)
        {
            AjaxState["ccid"] = Request.Params["ccid"];
            BindData();
        }
        else
        {
            //new CourceCatagoryController().BindCourceCatagory(ddCatagory);
        }
    }

}
