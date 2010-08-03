using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataEntity;
namespace BusinessLogic
{
    public class CollegeBasePage:BasePage
    {
        protected CollegeBasePage()
        {
            if (!new UserAuthontication().IsLoggedIn)
            {
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}
