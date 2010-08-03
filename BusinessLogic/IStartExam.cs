using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IStartExam
    {
        DataEntity.EXM_Question ExamQuestions
        {
            get;
            set;
        }

        int CurrentQuestion
        {
            get;
            set;
        }

        int StudentLoginID
        {
            get;
            set;
        }

         void SaveAnswer();

         void GetCurrentQuestion();
    }
}
