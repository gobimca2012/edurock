using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;
using System.Web;

namespace BusinessLogic
{
    public class WidgetHelper
    {
        public List<Widget> LeftColumn;
        public List<Widget> RightColumn;
        public Guid PageID
        {
            get;
            set;
        }
        public int LoginUserID
        {
            get;
            set;
        }
        public static bool IsEditMode()
        {
            if (HttpContext.Current.Request.Cookies[CookieName.WidgetEditMode.ToString()] != null)
            {
                if (HttpContext.Current.Request.Cookies[CookieName.WidgetEditMode.ToString()].Value == "true")
                {
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
        public void GetPage(int LoginUserID, PageTypeEnum pagetype)
        {            
            var data = new WidgetPageController().GetbyLoginUserID(LoginUserID, (int)pagetype, LoginUserID.ToString());
            if (data.Count > 0)
            {
                PageID = data[0].PageID;
            }
            else
            {
                PageID = Guid.NewGuid();
                new WidgetPageController().Add(PageID, LoginUserID, (int)pagetype,LoginUserID.ToString(), "new Page", DateTime.Now);
            }
            var widgets = new WidgetController().GetbyPageID(PageID);
            LeftColumn = (from p in widgets where p.WidgetColumn == 1 select p).ToList();
            RightColumn = (from p in widgets where p.WidgetColumn == 2 select p).ToList();
        }
        public void GetPage(string ContentID, PageTypeEnum pagetype)
        {
            var data = new WidgetPageController().GetbyContentID((int)pagetype, ContentID);
            if (data.Count > 0)
            {
                PageID = data[0].PageID;
                LoginUserID = data[0].LoginUserID;
            }
            else
            {
                PageID = Guid.NewGuid();
                LoginUserID = new UserAuthontication().LoggedInUserID;
                new WidgetPageController().Add(PageID, new UserAuthontication().LoggedInUserID, (int)pagetype, ContentID, "new Page", DateTime.Now);
            }
            var widgets = new WidgetController().GetbyPageID(PageID);
            LeftColumn = (from p in widgets where p.WidgetColumn == 1 select p).ToList();
            RightColumn = (from p in widgets where p.WidgetColumn == 2 select p).ToList();
        }
        public Guid AddHTMLWidget(Guid PageID, WidgetTypeEnum widgetType,int ColumnID)
        {
            Guid HtmlID = Guid.NewGuid();
            new HTMLWidgetController().Add(HtmlID, "", DateTime.Now);

            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "", (int)widgetType, HtmlID.ToString(), orderdata + 1, ColumnID, DateTime.Now);
            return WidgetID;
        }
        public Guid AddShoutLWidget(Guid PageID, WidgetTypeEnum widgetType, int ColumnID)
        {
            Guid HtmlID = Guid.NewGuid();
            new HTMLWidgetController().Add(HtmlID, "", DateTime.Now);

            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "", (int)widgetType, HtmlID.ToString(), orderdata + 1, ColumnID, DateTime.Now);
            return WidgetID;
        }
        public Guid AddWidget(Guid PageID, WidgetTypeEnum widgetType, string ContentID, int ColumnID)
        {            
            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "All Content", (int)widgetType, ContentID.ToString(), orderdata + 1, ColumnID, DateTime.Now);
            return WidgetID;
        }
        public Guid AddWidget(Guid PageID, WidgetTypeEnum widgetType, string ContentID, string WidgetTitle, int ColumnID)
        {
            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, WidgetTitle, (int)widgetType, ContentID.ToString(), orderdata + 1, ColumnID, DateTime.Now);
            return WidgetID;
        }
        public Guid AddHTMLWidget(Guid PageID)
        {
            Guid HtmlID = Guid.NewGuid();            
            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "", (int)WidgetTypeEnum.HTMLWidget, HtmlID.ToString(), orderdata + 1, 1, DateTime.Now);
            return WidgetID;
        }
        public void UpdateWidgetOrder(Guid WidgetID,int Order)
        {
            new WidgetController().UpdateByWidgetID(WidgetID, Order);
        }
    }
    public enum PageTypeEnum
    {
        ProfilePage = 0,
        InstitutePage=1,
        InsituteCoursePage=2
    }
    public enum WidgetTypeEnum
    {
        HTMLWidget = 0,
        Content=15,
        UserInfo=16,
        InstituteInfo=17,
        ShoutWidget=18
    }
    public enum WidgetColumnEnum
    {
        LeftColumn=1,
        RightColumn=2
    }

}
