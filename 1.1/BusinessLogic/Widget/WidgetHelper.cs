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
        public void GetPage(int LoginUserID,PageTypeEnum pagetype)
        {
            var data=new WidgetPageController().GetByLoginID(LoginUserID,(int) pagetype);            
            if (data.Count > 0)
            {
                PageID = data[0].PageID;    
            }
            else
            {
                PageID=Guid.NewGuid();
                new WidgetPageController().Add(PageID, LoginUserID, (int)pagetype, "new Page", DateTime.Now);
            }
            var widgets = new WidgetController().GetbyPageID(PageID);
            LeftColumn = (from p in widgets where p.WidgetColumn == 1 select p).ToList();
            RightColumn = (from p in widgets where p.WidgetColumn == 2 select p).ToList();
        }
        public Guid AddNewWidget(Guid PageID, WidgetTypeEnum widgetType)
        {
            Guid HtmlID=Guid.NewGuid();
            new HTMLWidgetController().Add(HtmlID, "", DateTime.Now);

            Guid WidgetID=Guid.NewGuid();
            new WidgetController().Add(WidgetID, PageID, "", (int)widgetType, HtmlID.ToString(), 1,1, DateTime.Now);
            return WidgetID;
        }
    }
    public enum PageTypeEnum
    {
        ProfilePage=0
    }
    public enum WidgetTypeEnum
    {
        HTMLWidget=0
    }

}
