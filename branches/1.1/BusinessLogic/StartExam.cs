using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace BusinessLogic
{
    public class StartExam
    {
        
        public StartExam(int ExamID)
        {
            this.ExamID = ExamID;

        }
        private int ExamID
        {
            get;
            set;
        }
        private List<EXM_QuestionController> QuestionList
        {
            get
            {
                if (HttpContext.Current.Session[SessionName.ExamList.ToString()] != null)
                {
                    var data = new EXM_QuestionController().GetbyExamID(ExamID);
                    HttpContext.Current.Session[SessionName.ExamList.ToString()] = data;
                }
                return (List<EXM_QuestionController>)HttpContext.Current.Session[SessionName.ExamList.ToString()];
            }
        }
        public EXM_QuestionController CurrentQuestion
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EXM_QuestionController NextQuestion
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SaveAnswer(int AnswerID)
        {
            
        }

        public void LoadQuestion()
        {
            throw new System.NotImplementedException();
        }
    }
}
