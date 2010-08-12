using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntity;

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
        public void GetPage(int LoginUserID, PageTypeEnum pagetype)
        {
            var data = new WidgetPageController().GetbyLoginUserID(LoginUserID, (int)pagetype);
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
        public Guid AddHTMLWidget(Guid PageID, WidgetTypeEnum widgetType)
        {
            Guid HtmlID = Guid.NewGuid();
            new HTMLWidgetController().Add(HtmlID, "", DateTime.Now);

            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "", (int)widgetType, HtmlID.ToString(), orderdata + 1, 1, DateTime.Now);
            return WidgetID;
        }
        public Guid AddWidget(Guid PageID, WidgetTypeEnum widgetType,string ContentID)
        {            
            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, "All Content", (int)widgetType, ContentID.ToString(), orderdata + 1, 1, DateTime.Now);
            return WidgetID;
        }
        public Guid AddWidget(Guid PageID, WidgetTypeEnum widgetType, string ContentID,string WidgetTitle)
        {
            Guid WidgetID = Guid.NewGuid();
            int orderdata = new WidgetController().WidgetOrderGetbyPageID(PageID);
            new WidgetController().Add(WidgetID, PageID, WidgetTitle, (int)widgetType, ContentID.ToString(), orderdata + 1, 1, DateTime.Now);
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
    }
    public enum PageTypeEnum
    {
        ProfilePage = 0
    }
    public enum WidgetTypeEnum
    {
        HTMLWidget = 0,
        Content=15,
        UserInfo=16
    }

}
