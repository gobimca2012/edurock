using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using BusinessLogic.Controllers;

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
        
    }
    public class PortalSettingHelper
    {
        public PortalSetting Get()
        {

            var data=new BusinessLogic.Controllers.PortalSettingController().GetbyInstituteID(new UserAuthontication().InstituteID);
            if (data.Count > 0)
            {
                XElement settings = data[0].Settings;
                PortalSetting pdata = new PortalSetting();
                var obj = (PortalSetting)new XMLHelper().Deserialize(settings,pdata);
                return obj;
            }
            else
            {
                return null;
            }
        }
        public void Add(PortalSetting obj)
        {
            XElement psetting= new XMLHelper().Serialize(obj);
            new PortalSettingController().Add(Guid.NewGuid(), new UserAuthontication().InstituteID, psetting, DateTime.Now);
        }
    }
}
