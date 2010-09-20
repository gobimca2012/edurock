using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using BusinessLogic.Controller;
using BusinessLogic;
using System.Collections.Generic;

/// <summary>
/// Summary description for Shopping
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Shopping : System.Web.Services.WebService
{

    public Shopping()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public bool UpdatePortal(int InstituteID, string UserLimit, string SpaceLimit)
    {
        PortalSetting newposetting = new PortalSetting();
        newposetting.CourseHeader = "Space";
        newposetting.SubjectHeader = "Sub Space";
        newposetting.IsSelfRegistrationAllow = false;
        newposetting.UserLimit = UserLimit;
        newposetting.SpaceLimit = SpaceLimit;
        bool status=new PortalSettingHelper().Add(InstituteID, newposetting);
        return status;
    }
    [WebMethod]
    public bool CreateNewInstitute(string InstituteName,string Username, string Password, string email,int totalUser)
    {
        int LoginUserID=AddUserData(Username, Password, email);
        int ID=new InstituteController().Add(LoginUserID, InstituteName,totalUser, DateTime.Now, false);
        if (ID > 0)
        {
            new LoginUserController().DeletebyLoginUserID(LoginUserID);
            return true;
        }
        else
        {
            return false;
        }
    }
    private int AddUserData(string Username, string Password, string email)
    {
        int UserType = (int)UserTypeEnum.College;
        Dictionary<string, string> status = new LoginUserController().CreateUser(Username, Password, email, UserType);
        if (status["status"].Contains("success"))
        {
            return Convert.ToInt32(status["loginuserid"]);
        }
        else
        {
            return 0;
        }

    }
}

