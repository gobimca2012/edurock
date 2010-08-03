using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using DataEntity;

namespace BusinessLogic
{
    public class ButtonVisibilityHelper
    {
        public GetInstituteUserFeatureAccessResult Access;
        public ButtonVisibilityHelper(int LoginUserID)
        {
            if (HttpContext.Current.Session[SessionName.InstituteAccess.ToString()] == null)
            {
                Access = new GetInstituteUserFeatureAccessResult();
                Access.CanAddArticle = false;
                Access.CanAddAudio = false;
                Access.CanAddCource = false;
                Access.CanAddDocument = false;
                Access.CanAddEvent = false;
                Access.CanAddExam = false;
                Access.CanAddHomeWork = false;
                Access.CanAddImage = false;
                Access.CanAddQuestion = false;
                Access.CanAddSubject = false;
                Access.CanAddUser = false;
                Access.CanAddVideo = false;

                var data = new InstituteUserController().GetInstituteUserFeatureAccess(LoginUserID);
                foreach (GetInstituteUserFeatureAccessResult dd in data)
                {
                    if (dd.CanAddArticle != null)
                        if ((bool)dd.CanAddArticle)
                        {
                            Access.CanAddArticle = dd.CanAddArticle;
                        }
                    if (dd.CanAddAudio != null)
                        if ((bool)dd.CanAddAudio)
                        {
                            Access.CanAddAudio = dd.CanAddAudio;
                        }
                    if (dd.CanAddCource != null)
                        if ((bool)dd.CanAddCource)
                        {
                            Access.CanAddCource = dd.CanAddCource;
                        }
                    if (dd.CanAddDocument != null)
                        if ((bool)dd.CanAddDocument)
                        {
                            Access.CanAddDocument = dd.CanAddDocument;
                        }
                    if (dd.CanAddEvent != null)
                        if ((bool)dd.CanAddEvent)
                        {
                            Access.CanAddEvent = dd.CanAddEvent;
                        }
                    if (dd.CanAddExam != null)
                        if ((bool)dd.CanAddExam)
                        {
                            Access.CanAddExam = dd.CanAddExam;
                        }
                    if (dd.CanAddHomeWork != null)
                        if ((bool)dd.CanAddHomeWork)
                        {
                            Access.CanAddHomeWork = dd.CanAddHomeWork;
                        }
                    if (dd.CanAddImage != null)
                        if ((bool)dd.CanAddImage)
                        {
                            Access.CanAddImage = dd.CanAddImage;
                        }
                    if (dd.CanAddQuestion != null)
                        if ((bool)dd.CanAddQuestion)
                        {
                            Access.CanAddQuestion = dd.CanAddQuestion;
                        }

                    if (dd.CanAddSubject != null)
                        if ((bool)dd.CanAddSubject)
                        {
                            Access.CanAddSubject = dd.CanAddSubject;
                        }
                    if (dd.CanAddUser != null)
                        if ((bool)dd.CanAddUser)
                        {
                            Access.CanAddUser = dd.CanAddUser;
                        }
                    if (dd.CanAddVideo != null)
                        if ((bool)dd.CanAddVideo)
                        {
                            Access.CanAddVideo = dd.CanAddVideo;
                        }
                }


            }
            else
            {
                Access = (GetInstituteUserFeatureAccessResult)HttpContext.Current.Session[SessionName.InstituteAccess.ToString()];
            }

        }
    }
}
