using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using BusinessLogic.Controllers;
using System.Web;

namespace BusinessLogic.Controller
{
    public class PortalSetting
    {
        public string CourseHeader
        {
            get;
            set;
        }
        public string SubjectHeader
        {
            get;
            set;
        }
        public bool IsSelfRegistrationAllow
        {
            get;
            set;
        }
        public string UserLimit
        {
            get;
            set;
        }
        public string SpaceLimit
        {
            get;
            set;
        }
        
    }
    public class PortalSettingHelper
    {
        public PortalSetting Get()
        {
            if (HttpContext.Current.Session[SessionName.PortalSetting.ToString()] == null)
            {
                var data = new BusinessLogic.Controllers.PortalSettingController().GetbyInstituteID(new UserAuthontication().InstituteID);
                if (data.Count > 0)
                {
                    XElement settings = data[0].Settings;
                    PortalSetting pdata = new PortalSetting();
                    var obj = (PortalSetting)new XMLHelper().Deserialize(settings, pdata);
                    HttpContext.Current.Session[SessionName.PortalSetting.ToString()] = obj;
                    return obj;
                }
                else
                {
                    PortalSetting datap = new PortalSetting();
                    datap.CourseHeader = "Course";
                    datap.SubjectHeader = "Subject";
                    return datap;
                }
            }
            else
            {
                return (PortalSetting)HttpContext.Current.Session[SessionName.PortalSetting.ToString()];
            }
        }
        public void Add(PortalSetting obj)
        {
            //HttpContext.Current.Session.Remove(SessionName.PortalSetting.ToString());
            XElement psetting= new XMLHelper().Serialize(obj);
            new PortalSettingController().Add(Guid.NewGuid(), new UserAuthontication().InstituteID, psetting, DateTime.Now);
        }
        public bool Add(int InstituteID,PortalSetting obj)
        {
            //HttpContext.Current.Session.Remove(SessionName.PortalSetting.ToString());
            XElement psetting = new XMLHelper().Serialize(obj);
            bool Status=new PortalSettingController().Add(Guid.NewGuid(), InstituteID, psetting, DateTime.Now);
            return Status;
        }
    }
}
