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

public partial class College_Widget_WidgetPage : WidgetContainner
{
    private int LoginUserID
    {
        get
        {
            if (Request.Params["usid"] != null)
                return Convert.ToInt32(Request.Params["usid"]);
            else
                return new UserAuthontication().LoggedInUserID;
        }
    }
  
    
    protected override void OnLoad(EventArgs e)
    {
        LeftColumnID = "#widgetLeft";
        RightColumnID = "#widgetright";
        base.OnLoad(e);
    }
    protected override void GetWidgetsPageData(out WidgetHelper widgetData)
    {
        widgetData = new WidgetHelper();
        widgetData.GetPage(new UserAuthontication().InstituteID.ToString(), PageTypeEnum.InstitutePage);
    }

   
    protected override void CreateControls(Guid pageID)
    {
        if (new UserAuthontication().UserType != UserTypeEnum.College)
        {
            lnkEdit.Visible = false;
            divEdit.Visible = false;
            divwidmanager.Visible = false;
        }
        else
        {
            lnkEdit.NavigateUrl = ResolveUrl("~/college/widget/WidgetPage.aspx") + "?icid=" + new UserAuthontication().LoggedInUserID.ToString() + "&ed=e";
        }
        if (IsEditable)
        {
            JScripter.DragNDrop DragNDropScripter = new JScripter.DragNDrop(this.Page, false);
            DragNDropScripter.MakeColumnDragNDrop(LeftColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            DragNDropScripter.MakeColumnDragNDrop(RightColumnID, "dl", ResolveUrl("~/User/Action.aspx"));
            objLoader.LoadPage("#widgetmanager", ResolveUrl("~/college/widget/WidgetManager.aspx") + "?wpid=" + pageID.ToString());
            if (lnkEdit.Visible)
            {
                lnkEdit.NavigateUrl = ResolveUrl("~/college/widget/WidgetPage.aspx") + "?usid=" + new UserAuthontication().LoggedInUserID.ToString();
                lnkEdit.Text = "Priview";
            }
        }
    }
}
