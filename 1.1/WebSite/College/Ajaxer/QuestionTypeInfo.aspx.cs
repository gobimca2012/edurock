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

public partial class Admin_Ajaxer_QuestionTypeInfo : AjaxPage
{
    
		
		private void AddData()
		{	
		try
		{
				
				
		string QuestionTypeTnext;if(false){throw new Exception("");}QuestionTypeTnext = HtmlHelper.ControlValue(txtQuestionTypeTnext.ClientID);

        int LoginUserID = new UserAuthontication().LoggedInUserID;

        DateTime ModifiedDate = DateTime.Now;
		
		new QuestionTypeController().Add(QuestionTypeTnext,LoginUserID,ModifiedDate);
        Response.Redirect("~/College/Ajaxer/QuestionTypeInfoView.aspx");
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

            int QuestionTypeID = ID;
				
		string QuestionTypeTnext;if(false){throw new Exception("");}QuestionTypeTnext = HtmlHelper.ControlValue(txtQuestionTypeTnext.ClientID);

        int LoginUserID = new UserAuthontication().LoggedInUserID;

        DateTime ModifiedDate = DateTime.Now;
		
		new QuestionTypeController().UpdateByQuestionTypeID(QuestionTypeID,QuestionTypeTnext,LoginUserID,ModifiedDate);

        Response.Redirect("~/College/Ajaxer/QuestionTypeInfoView.aspx");
		}		
		catch(Exception ex)
        {
                divMessage.InnerHtml="<div class='error'>"+ex.Message+"</div>";
         }
		}
		
		private void BindData()
		{
		    var dataBunch = new QuestionTypeController().GetbyQuestionTypeID(ID);
			if (dataBunch.Count > 0)
			{
				var data=dataBunch[0];
					
				
						
				txtQuestionTypeTnext.Text=data.QuestionTypeTnext;				
						
						
			}
		}
		
	private int ID
    {
        get
        {
            return Convert.ToInt32(AjaxState["qtypeid"]);
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
        if (Request.Params["qtypeid"]!=null)
        {
		    AjaxState["qtypeid"] = Request.Params["qtypeid"];
            BindData();
			lnkAddQuestionType.Visible = false;
        }
        else
        {
            
			lnkUpdateQuestionType.Visible = false;
        }
    }
	
}
