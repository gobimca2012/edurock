using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace BusinessLogic.Controllers
{

    public class CustomerController
    {
        public NewUserResponseDTO RegisterNewCustomer(RegisterCustomerDTO registerCustomer)
        {
            NewUserResponseDTO newUser = new LoginUserController().RegisterNewCustomer(registerCustomer);
            if (newUser.UserID != null)
            {


                int instituteId = new InstituteController().Add(newUser.UserID.Value, registerCustomer.InstituteName, registerCustomer.TotalUser, registerCustomer.ValidMonth, "selfcramreg", registerCustomer.Username, DateTime.Now, false);
                new InstituteController().UpdateByFilePath(instituteId, newUser.UserID.Value, "~/Images/Inst.png");
                new CourceCatagoryController().Add("All", newUser.UserID.Value, "", (int)CatagoryTypeEnum.BusinessIndustry, DateTime.Now);
                int instituteUserTypeID = new InstituteUserTypeController().Add(newUser.UserID.Value, instituteId, "Administrator", "", DateTime.Now);
                new InstituteUserInUserTypeController().Add(newUser.UserID.Value, newUser.UserID.Value, instituteUserTypeID, DateTime.Now);
                if (instituteId == 0)
                {
                    new LoginUserController().DeletebyLoginUserID(newUser.UserID.Value);

                }


            }
            return newUser;

        }

    }
}
