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
using DataEntity;
using BusinessLogic;

public partial class College_Cource : AjaxPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsAjaxPostBack)
        {
            if (Request.Params["cid"] != null)
            {
                var data=(new CourceController().GetbyCourceID(Convert.ToInt32(Request.Params["cid"])));
                if (data.Count > 0)
                {
                    BindData(data[0]);
                }
            }
        }
    }
    private void BindData(Cource data)
		{
		
		if(data.CourceID!=null)
		
		lblCourceID.InnerHtml=data.CourceID.ToString();
		
		if(data.CourceCatagoryID!=null)
		
		lblCourceCatagoryID.InnerHtml=data.CourceCatagoryID.ToString();
		
		if(data.CourceName!=null)
		
		lblCourceName.InnerHtml=data.CourceName.ToString();
		
		if(data.Description!=null)
		
		lblDescription.InnerHtml=data.Description.ToString();
		
		if(data.CourceType!=null)
		
		lblCourceType.InnerHtml=data.CourceType.ToString();
		
		if(data.Modifieddate!=null)
		
		lblModifieddate.InnerHtml=data.Modifieddate.ToString();
		
		}
		
}
