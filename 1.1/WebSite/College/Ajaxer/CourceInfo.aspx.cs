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

public partial class College_Ajaxer_CourceInfo : AjaxPage
{
    private void FormValidation()
    {
        lnkAddcource.EnableValidation = true;
        lnkUpdate.EnableValidation = true;
        JScripter.Validation objValidate = new JScripter.Validation(this.Page, lnkAddcource.ClientID);
        JScripter.Validation objValidate1 = new JScripter.Validation(this.Page, lnkUpdate.ClientID);
        objValidate.DrowDownMendatory(ddCatagory, "Please select Cource Catagory", this.Page, "0");
        objValidate.Medatory(txtCourceName, "Please enter Cource Name", this.Page);
        
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        FormValidation();
        if (Request.Params["cid"]!=null)
        {
            AjaxState["cid"] = Request.Params["cid"];
            BindData(ID);
        }
        else
        {
            new CourceCatagoryController().BindCourceCatagory(ddCatagory);
        }
    }
    private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["cid"]);
        }
    }

    private void AddData()
    {
        try
        {           

            int CourceCatagoryID; if (false) { throw new Exception(""); } CourceCatagoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCatagory.ClientID));

            string CourceName; if (false) { throw new Exception(""); } CourceName = HtmlHelper.ControlValue(txtCourceName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CourceType = (int)CourceTypeEnum.Business;

            DateTime Modifieddate = DateTime.Now;

            new CourceController().Add( CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully now you can add this cource to your institute.", "Cource ",CourceName);
            Response.Redirect("~/College/Ajaxer/InstituteCourceInfoView.aspx");
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
            int CourceCatagoryID; if (false) { throw new Exception(""); } CourceCatagoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCatagory.ClientID));

            string CourceName; if (false) { throw new Exception(""); } CourceName = HtmlHelper.ControlValue(txtCourceName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CourceType = (int)CourceTypeEnum.Business;

            DateTime Modifieddate = DateTime.Now;

            new CourceController().UpdateByCourceID(ID, CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
            Session[SessionName.SucessMessage.ToString()] = string.Format("{0} {1} hasbeen Updated Successfully", "Cource ", CourceName);
            Response.Redirect("~/College/Ajaxer/CourceInfoView.aspx");
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void BindData(int ID)
    {
        var dataBunch = new CourceController().GetbyCourceID(ID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];

            new CourceCatagoryController().BindCourceCatagory(ddCatagory, data.CourceCatagoryID.ToString());
            //ddCatagory.SelectedValue = data.CourceCatagoryID.ToString();

            txtCourceName.Text = data.CourceName;

            txtDescription.Text = data.Description;



        }
        //lnkUpdate.Parames.Add("cid", ID.ToString());
    }

    protected void AddAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
        
    }
    protected void UpdateAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        EditData();
        
    }
    


}
