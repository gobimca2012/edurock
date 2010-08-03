GO
Declare @RightTotal as int,@WrongeTotal as int,@Marks as Decimal

SELECT     @RightTotal=Count(EXM_UserAnswer.EXM_QuestionID),@Marks=Avg(EXM_Question.Marks)
FROM         EXM_Answer INNER JOIN
                      EXM_UserAnswer ON EXM_Answer.EXM_AnswerID = EXM_UserAnswer.EXM_AnswerID INNER JOIN
                      EXM_Question ON EXM_UserAnswer.EXM_QuestionID = EXM_Question.EXM_QuestionID
GROUP BY EXM_UserAnswer.EXM_QuestionID, EXM_Answer.EXM_AnswerID, EXM_Answer.IsRight, EXM_Question.Q_Type, EXM_Question.Marks
HAVING      (EXM_Question.Q_Type = 2) AND (EXM_UserAnswer.EXM_QuestionID = '23') AND (EXM_Answer.IsRight = 1)
ORDER BY EXM_UserAnswer.EXM_QuestionID



SELECT     @WrongeTotal=Count(EXM_UserAnswer.EXM_QuestionID)
FROM         EXM_Answer INNER JOIN
                      EXM_UserAnswer ON EXM_Answer.EXM_AnswerID = EXM_UserAnswer.EXM_AnswerID INNER JOIN
                      EXM_Question ON EXM_UserAnswer.EXM_QuestionID = EXM_Question.EXM_QuestionID
GROUP BY EXM_UserAnswer.EXM_QuestionID, EXM_Answer.EXM_AnswerID, EXM_Answer.IsRight, EXM_Question.Q_Type, EXM_Question.Marks
HAVING      (EXM_Question.Q_Type = 2) AND (EXM_UserAnswer.EXM_QuestionID = '23') AND (EXM_Answer.IsRight = 0)
ORDER BY EXM_UserAnswer.EXM_QuestionID

if(@RightTotal-@WrongeTotal)>-1
BEGIN
Select @Marks
END
ELSE
BEGIN
Select 'bbb'
END

