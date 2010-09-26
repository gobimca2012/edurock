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

public partial class College_Ajaxer_InstituteCourceInfoView : AjaxPage
{


    public HtmlHelper _HtmlHelper = new HtmlHelper();
    private int LoginUserID
    {
        get
        {
            if (Request.Params["usid"] != null)
            {
                return Convert.ToInt32(Request.Params["usid"]);
            }
            else
            {
                return 0;
            }
        }
    }

    private int TotalPage;
    private int PageSize = 100;

    protected void Page_Load(object sender, EventArgs e)
    {

        {
            BindList();
          
        }

    }
    private void BindList()
    {
        //ListInstituteCource.DataSource = new InstituteCourceController().GetByCourceUserID(new UserAuthontication().UserInstituteID, new UserAuthontication().LoggedInUserID);
        ListInstituteCource.DataSource = new InstituteCourceController().GetInstituteCourseByLoginUserViewAccess(new UserAuthontication().LoggedInUserID, new UserAuthontication().UserInstituteID);
        ListInstituteCource.DataBind();
    }
 
    protected override void OnAjaxListViewCommand(AjaxListViewCommandArg e)
    {
        if (e.Command.Contains("delete"))
        {

            BindList();
        }
        base.OnAjaxListViewCommand(e);
    }

    protected void ListInstituteCourceOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string InstituteCourceID = ListInstituteCource.DataKeys[currentItem.DataItemIndex]["InstituteCourceID"].ToString();
        AjaxControl.HyperLink lnkFullvIew = (AjaxControl.HyperLink)currentItem.FindControl("lnkFullvIew");
        if (lnkFullvIew != null)
        {
            if(LoginUserID>0)
            lnkFullvIew.NavigateUrl = ResolveUrl("~/User/AjaxControl/Lander.aspx") + "?usid=" + LoginUserID.ToString() + "&icid=" + InstituteCourceID;
            else
                lnkFullvIew.NavigateUrl = ResolveUrl("~/User/AjaxControl/Lander.aspx") + "?icid=" + InstituteCourceID;
        }
            



    }



}
