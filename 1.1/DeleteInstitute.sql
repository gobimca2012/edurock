GO
Declare @InstituteID as int
set @InstituteID=20


DELETE FROM Answer
FROM         Answer INNER JOIN
                      LoginUser ON Answer.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM AnswerState
FROM         AnswerState INNER JOIN
                      LoginUser ON AnswerState.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM Article
FROM         Article INNER JOIN
                      LoginUser ON Article.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM Comment
FROM         Comment INNER JOIN
                      LoginUser ON Comment.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)



DELETE FROM DocumentCource
FROM         DocumentCource INNER JOIN
                      [Document] ON DocumentCource.DocumentID = [Document].DocumentID INNER JOIN
                      LoginUser ON [Document].LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM [Document]
FROM         [Document] INNER JOIN
                      LoginUser ON [Document].LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM Event
FROM         Event INNER JOIN
                      LoginUser ON Event.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)


DELETE FROM Exam
FROM         Exam INNER JOIN
                      LoginUser ON Exam.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM EXM_Answer
FROM         EXM_Answer INNER JOIN
                      EXM_Question ON EXM_Answer.EXM_QuestionID = EXM_Question.EXM_QuestionID INNER JOIN
                      Exam ON EXM_Question.ExamID = Exam.ExamID INNER JOIN
                      LoginUser ON Exam.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM EXM_Question
FROM         EXM_Question INNER JOIN
                      Exam ON EXM_Question.ExamID = Exam.ExamID INNER JOIN
                      LoginUser ON Exam.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM EXM_UserAnswer
FROM         EXM_UserAnswer INNER JOIN
                      LoginUser ON EXM_UserAnswer.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM HomeWork
FROM         HomeWork INNER JOIN
                      LoginUser ON HomeWork.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)


DELETE FROM InstituteConfiguration
FROM         Institute INNER JOIN
                      InstituteConfiguration ON Institute.InstituteID = InstituteConfiguration.InstituteID
WHERE     (Institute.InstituteID = @InstituteID)

DELETE FROM InstituteSubject
FROM         InstituteCource INNER JOIN
                      InstituteSubject ON InstituteCource.InstituteCourceID = InstituteSubject.InstituteCourceID
WHERE     (InstituteCource.InstituteID = @InstituteID)

DELETE FROM InstituteCourceUser
FROM         InstituteCourceUser INNER JOIN
                      LoginUser ON InstituteCourceUser.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM InstituteUserInUserType
FROM         InstituteUserInUserType INNER JOIN
                      InstituteUser ON InstituteUserInUserType.InstituteUserID = InstituteUser.InstituteUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)


DELETE FROM InstituteUserTypeAccess
FROM         InstituteUserType INNER JOIN
                      InstituteUserTypeAccess ON InstituteUserType.InstituteUserTypeID = InstituteUserTypeAccess.InstituteUserTypeID
WHERE     (InstituteUserType.InstituteID = @InstituteID)

DELETE FROM Question
FROM         Question INNER JOIN
                      LoginUser ON Question.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM QuestionStatus
FROM         QuestionStatus INNER JOIN
                      Question ON QuestionStatus.QuestionStatusID = Question.QuestionStatusID INNER JOIN
                      LoginUser ON Question.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM QuestionType
FROM         QuestionType INNER JOIN
                      LoginUser ON QuestionType.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM UserEducation
WHERE     (InstituteID = @InstituteID)

DELETE FROM [User]
FROM         [User] INNER JOIN
                      LoginUser ON [User].LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM UserExam
FROM         UserExam INNER JOIN
                      LoginUser ON UserExam.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM Widget
FROM         Widget INNER JOIN
                      WidgetPage ON Widget.PageID = WidgetPage.PageID INNER JOIN
                      LoginUser ON WidgetPage.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

DELETE FROM WidgetPage
FROM         Widget INNER JOIN
                      WidgetPage ON Widget.PageID = WidgetPage.PageID INNER JOIN
                      LoginUser ON WidgetPage.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      InstituteUser ON LoginUser.LoginUserID = InstituteUser.LoginUserID
WHERE     (InstituteUser.InstituteID = @InstituteID)

delete from InstituteUser where InstituteID=@InstituteID
delete from InstituteSubject where InstituteCourceID IN (select InstituteCourceID from InstituteCource where InstituteID=@InstituteID)
delete from PortalSetting where InstituteID=@InstituteID
delete from InstituteCource where InstituteID=@InstituteID
delete from Institute where InstituteID=@InstituteID
