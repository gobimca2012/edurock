SELECT     EXM_Answer.Answer, EXM_Answer.EXM_QuestionID, EXM_Answer.EXM_AnswerID, EXM_UserAnswer.EXM_AnswerText, 
                      EXM_UserAnswer.LoginUserID, LoginUser.Username
FROM         EXM_UserAnswer INNER JOIN
                      EXM_Answer ON EXM_UserAnswer.EXM_QuestionID = EXM_Answer.EXM_QuestionID AND 
                      EXM_UserAnswer.EXM_UserAnswerID = EXM_Answer.EXM_AnswerID INNER JOIN
                      LoginUser ON EXM_UserAnswer.LoginUserID = LoginUser.LoginUserID
WHERE     (EXM_Answer.IsRight = 1) AND (LoginUser.Username = 'rohan')



SELECT     EXM_UserAnswerID, LoginUserID, EXM_QuestionID, EXM_AnswerID, EXM_AnswerText, ModifiedDate
FROM         EXM_UserAnswer
WHERE     (LoginUserID = '2')
ORDER BY EXM_QuestionID


SELECT     EXM_Answer.EXM_AnswerID, EXM_Answer.EXM_QuestionID, EXM_Answer.Answer, EXM_Answer.IsRight, EXM_Answer.ModifiedDate, 
                      Exam.ExamID
FROM         Exam INNER JOIN
                      EXM_Question ON Exam.ExamID = EXM_Question.ExamID INNER JOIN
                      EXM_Answer ON EXM_Question.EXM_QuestionID = EXM_Answer.EXM_QuestionID
WHERE     (Exam.ExamID = '29') AND (EXM_Answer.IsRight = 1)
ORDER BY EXM_Answer.EXM_QuestionID

