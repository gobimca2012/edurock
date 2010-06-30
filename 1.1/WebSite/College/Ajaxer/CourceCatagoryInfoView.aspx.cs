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

public partial class College_Ajaxer_CourceCatagoryInfoView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        TotalPage = new CourceCatagoryController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID).Count / PageSize;
        BindList();
    }
    private int PageNumber
    {
        get
        {
            if (ViewState["PageNumber"] != null)
                return Convert.ToInt32(ViewState["PageNumber"].ToString());
            else
            {
                lnkPrev.Visible = false;
                return 0;
            }
        }
        set
        {
            ViewState["PageNumber"] = value;
        }
    }
    private int TotalPage
    {
        get
        {
            if (ViewState["TotalPage"] != null)
                return Convert.ToInt32(ViewState["TotalPage"].ToString());
            else
            {

                return 0;
            }
        }
        set
        {
            ViewState["TotalPage"] = value;
        }
    }
    private int PageSize = 20;


    private void BindList()
    {
        ListCourceCatagory.DataSource = new CourceCatagoryController().GetbyLoginUserID(new UserAuthontication().LoggedInUserID,PageSize, PageNumber);
        ListCourceCatagory.DataBind();
    }
    protected void Prev_Click(object sender, EventArgs e)
    {
        if (PageNumber > 0)
        {
            PageNumber = PageNumber - 1;
            if (PageNumber == 0)
            {
                lnkPrev.Visible = false;
            }
        }
        BindList();
        if (PageNumber < TotalPage)
        {
            lnkNext.Visible = false;
        }
        else
        {
            lnkNext.Visible = true;
        }
        if (PageNumber < 1)
        {
            lnkPrev.Visible = false;
        }
        else
        {
            lnkPrev.Visible = true; ;
        }
    }
    protected void Next_Click(object sender, EventArgs e)
    {

        PageNumber = PageNumber + 1;

        BindList();
    }

    protected void ListCourceCatagoryOnItemDataBound(object sender, ListViewItemEventArgs e)
    {
        ListViewDataItem currentItem = (ListViewDataItem)e.Item;
        string CourceCatagoryID = ListCourceCatagory.DataKeys[currentItem.DataItemIndex]["CourceCatagoryID"].ToString();


    }




}
