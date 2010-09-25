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
using BusinessLogic.Controllers;

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
    public bool RenewInstitute(int InstituteID, string UserLimit, string SpaceLimit,int ValidityMonth)
    {
        var data = new PortalSettingController().GetbyInstituteID(InstituteID);
        if (data.Count > 0)
        {
            PortalSetting newposetting = new PortalSetting();
            newposetting =(PortalSetting) new XMLHelper().Deserialize(data[0].Settings, newposetting);
            newposetting.UserLimit = UserLimit;
            newposetting.SpaceLimit = SpaceLimit;
            newposetting.ValidityMonth = ValidityMonth.ToString();
            newposetting.ExpiryDate = Convert.ToDateTime(newposetting.ExpiryDate).AddMonths(ValidityMonth).ToString();
            bool status = new PortalSettingHelper().Add(InstituteID, newposetting);
            return status;
        }
        else
        {
            return false;
        }
        
    }
    [WebMethod]
    public int CreateNewInstitute(string InstituteName,string Username, string Password, string email,int totalUser,int TotalMonth)
    {
        int LoginUserID=AddUserData(Username, Password, email);
        if (LoginUserID > 0)
        {
            int ID = new InstituteController().Add(LoginUserID, InstituteName, totalUser, TotalMonth, DateTime.Now, false);
            new InstituteController().UpdateByFilePath(ID, LoginUserID, "~/Images/Inst.png");
            int instituteUserTypeID=new InstituteUserTypeController().Add(LoginUserID, ID, "Administrator", "", DateTime.Now);
            new InstituteUserInUserTypeController().Add(LoginUserID, LoginUserID, instituteUserTypeID, DateTime.Now);
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
    
    private int AddUserData(string Username, string Password, string email)
    {
        int UserType = (int)UserTypeEnum.College;
        Dictionary<string, string> status = new LoginUserController().CreateUser(Username, Password, email, UserType);

        if (status["status"].Contains("success"))
        {
            int loginUserId=Convert.ToInt32(status["loginuserid"]);
            new UserController().Add(loginUserId, Username);
            new UserController().UpdateProfilePic(loginUserId, "~/Images/DefaultAvtar.png");
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

