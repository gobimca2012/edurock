using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Diagnostics;
using DataEntity;
namespace BusinessLogic
{
    public class UserAuthontication
    {
        public string LoggedInUserName
        {
            get
            {
                string LoginID = "";
                if (HttpContext.Current.Session["LoggedInUserID"] != null)
                {
                    LoginID = HttpContext.Current.Session["LoggedInUserID"].ToString();
                }
                else if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
                {
                    if (HttpContext.Current.Request.Cookies["LoggedInUserID"].Value != "")
                    {
                        LoginID = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                    }
                    //HttpContext.Current.Session["LoggedInUserID"] = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                }
                if (LoginID != null && LoginID != "")
                {
                    LoginUserController objLogin = new LoginUserController();
                    var data = objLogin.GetbyLoginUserID(Convert.ToInt32(LoginID));
                    if (data.Count > 0)
                    {
                        return data[0].Username;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        public string LoggedInEmail
        {
            get
            {
                string LoginID = "";
                if (HttpContext.Current.Session["LoggedInUserID"] != null)
                {
                    LoginID = HttpContext.Current.Session["LoggedInUserID"].ToString();
                }
                else if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
                {
                    if (HttpContext.Current.Request.Cookies["LoggedInUserID"].Value != "")
                    {
                        LoginID = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                    }
                    //HttpContext.Current.Session["LoggedInUserID"] = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                }
                if (LoginID != null && LoginID != "")
                {
                    LoginUserController objLogin = new LoginUserController();
                    var data = objLogin.GetbyLoginUserID(Convert.ToInt32(LoginID));
                    if (data.Count > 0)
                    {
                        //return data[0].Email;
                        return "";
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        public int LoggedInUserID
        {
            get
            {
                if (HttpContext.Current.Session["LoggedInUserID"] != null)
                {
                    return Convert.ToInt32(HttpContext.Current.Session["LoggedInUserID"].ToString());
                }
                else if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
                {
                    if (HttpContext.Current.Request.Cookies["LoggedInUserID"].Value != "")
                    {
                        HttpContext.Current.Session["LoggedInUserID"] = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                        return Convert.ToInt32(HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString());
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            set
            {
            }
        }
        public Guid AdminLoginID
        {
            get
            {
                if (HttpContext.Current.Session["LoggedInUserID"] != null)
                {
                    return new Guid(HttpContext.Current.Session["LoggedInUserID"].ToString());
                }
                else if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
                {
                    if (HttpContext.Current.Request.Cookies["LoggedInUserID"].Value != "")
                    {
                        HttpContext.Current.Session["LoggedInUserID"] = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
                        return new Guid(HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString());
                    }
                    else
                    {
                        return Guid.Empty;
                    }
                }
                else
                {
                    return Guid.Empty;
                }
            }
            set
            {
            }
        }
        //public bool IsLoggedIn
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session["LoggedInUserID"] != null)
        //        {
        //            return true;
        //        }
        //        else if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
        //        {
        //            if (HttpContext.Current.Request.Cookies["LoggedInUserID"].Value != "")
        //            {
        //                HttpContext.Current.Session["LoggedInUserID"] = HttpContext.Current.Request.Cookies["LoggedInUserID"].Value.ToString();
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
        public UserTypeEnum UserType
        {
            get
            {
                var data=new LoginUserController().GetbyLoginUserID(LoggedInUserID);
                if (data.Count > 0)
                {
                    if (data[0].UserType == (int)UserTypeEnum.College)
                    {
                        return UserTypeEnum.College;
                    }
                    else
                    {
                        return UserTypeEnum.Student;
                    }
                }
                return UserTypeEnum.Annoumus;
            }
        }

        public bool IsLoggedIn
        {
            get
            {
                if (HttpContext.Current.Session["LoggedInUserID"] != null)
                {
                    return true;
                }
                else if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    LoginUserController objLogin = new LoginUserController();
                    string name = HttpContext.Current.User.Identity.Name;
                    var data = objLogin.GetbyUsername(name);
                    if (data.Count > 0)
                    {
                        HttpContext.Current.Session["LoggedInUserID"] = data[0].LoginUserID;
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool LogOut()
        {
            try
            {
                HttpContext.Current.Session.RemoveAll();
                HttpContext.Current.Session.Remove("LoggedInUserID");
                if (HttpContext.Current.Request.Cookies["LoggedInUserID"] != null)
                {
                    HttpContext.Current.Response.Cookies["LoggedInUserID"].Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Current.Response.Cookies.Remove("LoggedInUserID");
                    HttpContext.Current.Response.Cookies["LoggedInUserID"].Value = "";
                    HttpContext.Current.Request.Cookies["LoggedInUserID"].Value = "";
                }
                HttpContext.Current.Session.Abandon();
                //Sitecore.Security.Authentication.AuthenticationManager.Logout();
                return true;
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return false;
            }
        }
        public LoginUser Login(string Username, bool IsRemember)
        {
            HttpContext.Current.Session["LoggedInUserID"] = Username;
            LoginUserController objLogin = new LoginUserController();
            var UserData = objLogin.GetbyUsername(Username.Trim().ToLower());
            LoginUser Logindata = UserData[0];
            LoginUser loginUserData;
            if (UserData.Count > 0)
            {
                loginUserData = UserData[0];
                if (IsRemember)
                {
                    HttpCookie loginCookie = new HttpCookie("LoggedInUserID");
                    loginCookie.Value = loginUserData.LoginUserID.ToString();
                    HttpContext.Current.Response.Cookies.Add(loginCookie);
                    loginCookie.Expires = DateTime.Now.AddYears(1);
                    HttpContext.Current.Session["LoggedInUserID"] = loginUserData.LoginUserID.ToString();
                    return Logindata;
                }
                else if (!IsRemember)
                {
                    HttpContext.Current.Session["LoggedInUserID"] = loginUserData.LoginUserID.ToString();
                    return Logindata;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            return null;
        }
        public bool ChangePassword(string OlderPassword, string Newpassword)
        {
            System.Web.Security.MembershipUser MemUser = System.Web.Security.Membership.GetUser(HttpContext.Current.User.Identity.Name);
            return MemUser.ChangePassword(OlderPassword, Newpassword);
        }
        public Boolean ApprovedUser(int LoginUserID)
        {
            try
            {
                var data = new LoginUserController().GetbyLoginUserID(LoginUserID);
                if (data.Count > 0)
                {
                    string UName =  data[0].Username;
                    System.Web.Security.MembershipUser MemUser = System.Web.Security.Membership.GetUser(UName);
                    MemUser.IsApproved = true;
                    System.Web.Security.Membership.UpdateUser(MemUser);
                    //new LoginUserController().UpdateByLoginUserID(LoginUserID false);
                }
                return true;
            }
            catch (Exception ee)
            {
                return false;
            }
        }
        public string RetrivePassword(string Username)
        {
            var data = new LoginUserController().GetbyUsername(Username);
            if (data.Count > 0)
            {
                string UName = data[0].Username;
                System.Web.Security.MembershipUser MemUser = System.Web.Security.Membership.GetUser(UName);
                string Password = MemUser.GetPassword();
                EmailController objEmail = new EmailController();
                string MessageBody = objEmail.TemplateEmail("Forgotpassword.txt");
                MessageBody = MessageBody.Replace("$username$", Username);
                MessageBody = MessageBody.Replace("$password$", Password);
                string emailaddress = MemUser.Email;
                objEmail.EmailSend(SettingProvider.AdminEmail(), MemUser.Email, MessageBody, "Musester Forgot password");
                return emailaddress;
            }
            else
            {
                return "";
            }
        }



        public  LoginUser ValidateUser(string Username, string Password)
        {
            try
            {
                if (Membership.ValidateUser(Username, Password))
                //if (new LoginUserController().CheckUserPassword(Username, Password))
                {
                    HttpContext.Current.Session["Authonticat"] = Username;
                    HttpCookie loginCookie = new HttpCookie("Authonticat");
                    HttpContext.Current.Response.Cookies.Add(loginCookie);
                    loginCookie.Expires = DateTime.Now.AddYears(1);
                    loginCookie.Value = Username;// GetLoginByUsername(userName);
                    LoginUser logindata= Login(Username, false);
                    return logindata;
                }
                else
                {
                    return null; ;
                }

            }
            catch
            {
                return null;
            }
        }

    }
}
