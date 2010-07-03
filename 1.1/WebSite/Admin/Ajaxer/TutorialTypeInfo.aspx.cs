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

public partial class Admin_Ajaxer_TutorialTypeInfo : AjaxPage
{
    
		
		private void AddData()
		{	
		try
		{
				
		
				
		string Name;if(false){throw new Exception("");}Name = HtmlHelper.ControlValue(txtName.ClientID);

        int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

        DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;
		
		new TutorialTypeController().Add(Name,LoginUserID,ModifiedDate);
        Response.Redirect("~/Admin/Ajaxer/TutorialTypeView.aspx");
		}		
		catch(Exception ex)
        {
                divMessage.InnerHtml="<div class='error'>"+ex.Message+"</div>";
         }
		 }
		
		private void EditData()
		{		
		try
		{
				
		
				
		string Name;if(false){throw new Exception("");}Name = HtmlHelper.ControlValue(txtName.ClientID);

        int LoginUserID; if (false) { throw new Exception(""); } LoginUserID = new UserAuthontication().LoggedInUserID;

        DateTime ModifiedDate; if (false) { throw new Exception(""); } ModifiedDate = DateTime.Now;
		
		new TutorialTypeController().UpdateByTutorialTypeID(ID,Name,LoginUserID,ModifiedDate);

        Response.Redirect("~/Admin/Ajaxer/TutorialTypeView.aspx");
		}		
		catch(Exception ex)
        {
                divMessage.InnerHtml="<div class='error'>"+ex.Message+"</div>";
         }
		}
		
		private void BindData()
		{
		    var dataBunch = new TutorialTypeController().GetbyTutorialTypeID(ID);
			if (dataBunch.Count > 0)
			{
				var data=dataBunch[0];
					
				
						
				txtName.Text=data.Name;				
						
				
						
			}
		}
		
	private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["tid"]);
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
        if (Request.Params["tid"] != null)
        {
            AjaxState["tid"] = Request.Params["tid"];
            BindData();
			lnkAddcource.Visible = false;
        }
        else
        {
            lnkUpdate.Visible = false;
        }
    }
	
}
