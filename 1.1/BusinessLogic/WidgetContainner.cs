using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class WidgetContainner:AjaxPage
    {
        protected string LeftColumnID
        {
            get;
            set;
        }
        protected string RightColumnID
        {
            get;
            set;
        }
        protected string GetWidgetBoxID(Guid WidgetID)
        {
            string ID = string.Format("foo_{0}", WidgetID.ToString().Replace("-", ""));
            return ID;
        }
    }
}
