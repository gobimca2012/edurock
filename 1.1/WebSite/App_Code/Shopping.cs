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
    public int CreateNewInstitute(string InstituteName,string Username, string Password, string email,int totalUser,int TotalMonth)
    {
        int LoginUserID=AddUserData(Username, Password, email);
        if (LoginUserID > 0)
        {
            int ID = new InstituteController().Add(LoginUserID, InstituteName, totalUser, TotalMonth, DateTime.Now, false);
            if (ID == 0)
            {
                new LoginUserController().DeletebyLoginUserID(LoginUserID);
                return -3;
            }
            else
            {
                return ID;
            }
        }
        else
        {
            return LoginUserID;
        }
    }
    [WebMethod]
    public void RenewInstitute(string InstituteID, int totalUser, int TotalMonth)
    {
        
    }
    private int AddUserData(string Username, string Password, string email)
    {
        int UserType = (int)UserTypeEnum.College;
        Dictionary<string, string> status = new LoginUserController().CreateUser(Username, Password, email, UserType);
        if (status["status"].Contains("success"))
        {
            return Convert.ToInt32(status["loginuserid"]);
        }
        else if (status["status"].Contains("duplicateusername"))
        {
            return -1;
        }
        else if (status["status"].Contains("duplicateemail"))
        {
            return -2;
        }
        else
        {
            return 0;
        }

    }
}

