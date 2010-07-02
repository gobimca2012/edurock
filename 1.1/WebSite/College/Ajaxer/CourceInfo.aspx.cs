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

public partial class College_Ajaxer_InstituteCourceInfo : AjaxPage
{
    private int CourceID
    {
        get
        {
            return Convert.ToInt32(Request.QueryString["cid"]);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        new CourceCatagoryController().BindCourceCatagory(ddCourceCatagory);
    }

    private void AddData()
    {
        try
        {   

            int CourceCatagoryID; if (false) { throw new Exception(""); } CourceCatagoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCourceCatagory.ClientID));

            string CourceName; if (false) { throw new Exception(""); } CourceName = HtmlHelper.ControlValue(txtCourceName.ClientID);

            string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

            int CourceType = (int)CourceTypeEnum.Business;

            DateTime Modifieddate = DateTime.Now;

            new CourceController().Add(CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
        }
        catch (Exception ex)
        {
            divMessage.InnerHtml = "<div class='error'>" + ex.Message + "</div>";
        }
    }

    private void EditData(Guid ID)
    {
        
        int CourceCatagoryID; if (false) { throw new Exception(""); } CourceCatagoryID = Convert.ToInt32(HtmlHelper.ControlValue(ddCourceCatagory.ClientID));

        string CourceName; if (false) { throw new Exception(""); } CourceName = HtmlHelper.ControlValue(txtCourceName.ClientID);

        string Description; if (false) { throw new Exception(""); } Description = HtmlHelper.ControlValue(txtDescription.ClientID);

        int CourceType = (int)CourceTypeEnum.Business;

        DateTime Modifieddate = DateTime.Now;

        new CourceController().UpdateByCourceID(CourceID, CourceCatagoryID, CourceName, Description, CourceType, Modifieddate);
    }

    private void BindData()
    {
        var dataBunch = new CourceController().GetbyCourceID(CourceID);
        if (dataBunch.Count > 0)
        {
            var data = dataBunch[0];           

            ddCourceCatagory.SelectedValue = data.CourceCatagoryID.ToString();

            txtCourceName.Text = data.CourceName;

            txtDescription.Text = data.Description;
            

            

        }
    }




    protected void AddCourceAjaxClick(object sender, AjaxControl.AjaxEventArg e)
    {
        AddData();
    }
}
