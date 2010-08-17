/****** Object:  ForeignKey [FK_Answer_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Answer_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Answer]'))
ALTER TABLE [dbo].[Answer] DROP CONSTRAINT [FK_Answer_LoginUser]
GO
/****** Object:  ForeignKey [FK_Answer_Question]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Answer_Question]') AND parent_object_id = OBJECT_ID(N'[dbo].[Answer]'))
ALTER TABLE [dbo].[Answer] DROP CONSTRAINT [FK_Answer_Question]
GO
/****** Object:  ForeignKey [FK_Article_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Article_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Article]'))
ALTER TABLE [dbo].[Article] DROP CONSTRAINT [FK_Article_LoginUser]
GO
/****** Object:  ForeignKey [FK__aspnet_Me__Appli__3B75D760]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Me__Appli__3B75D760]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
ALTER TABLE [dbo].[aspnet_Membership] DROP CONSTRAINT [FK__aspnet_Me__Appli__3B75D760]
GO
/****** Object:  ForeignKey [FK__aspnet_Me__UserI__3C69FB99]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Me__UserI__3C69FB99]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
ALTER TABLE [dbo].[aspnet_Membership] DROP CONSTRAINT [FK__aspnet_Me__UserI__3C69FB99]
GO
/****** Object:  ForeignKey [FK__aspnet_Pa__Appli__6D0D32F4]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pa__Appli__6D0D32F4]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]'))
ALTER TABLE [dbo].[aspnet_Paths] DROP CONSTRAINT [FK__aspnet_Pa__Appli__6D0D32F4]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__PathI__72C60C4A]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__PathI__72C60C4A]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers]'))
ALTER TABLE [dbo].[aspnet_PersonalizationAllUsers] DROP CONSTRAINT [FK__aspnet_Pe__PathI__72C60C4A]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__PathI__76969D2E]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__PathI__76969D2E]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] DROP CONSTRAINT [FK__aspnet_Pe__PathI__76969D2E]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__UserI__778AC167]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__UserI__778AC167]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] DROP CONSTRAINT [FK__aspnet_Pe__UserI__778AC167]
GO
/****** Object:  ForeignKey [FK__aspnet_Pr__UserI__5070F446]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pr__UserI__5070F446]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Profile]'))
ALTER TABLE [dbo].[aspnet_Profile] DROP CONSTRAINT [FK__aspnet_Pr__UserI__5070F446]
GO
/****** Object:  ForeignKey [FK__aspnet_Ro__Appli__59FA5E80]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Ro__Appli__59FA5E80]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]'))
ALTER TABLE [dbo].[aspnet_Roles] DROP CONSTRAINT [FK__aspnet_Ro__Appli__59FA5E80]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__Appli__2B3F6F97]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__Appli__2B3F6F97]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
ALTER TABLE [dbo].[aspnet_Users] DROP CONSTRAINT [FK__aspnet_Us__Appli__2B3F6F97]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__RoleI__5EBF139D]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__RoleI__5EBF139D]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]'))
ALTER TABLE [dbo].[aspnet_UsersInRoles] DROP CONSTRAINT [FK__aspnet_Us__RoleI__5EBF139D]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__UserI__5DCAEF64]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__UserI__5DCAEF64]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]'))
ALTER TABLE [dbo].[aspnet_UsersInRoles] DROP CONSTRAINT [FK__aspnet_Us__UserI__5DCAEF64]
GO
/****** Object:  ForeignKey [FK_Comment_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Comment_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Comment]'))
ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_Comment_LoginUser]
GO
/****** Object:  ForeignKey [FK_Cource_CourceCatagory]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Cource_CourceCatagory]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cource]'))
ALTER TABLE [dbo].[Cource] DROP CONSTRAINT [FK_Cource_CourceCatagory]
GO
/****** Object:  ForeignKey [FK_Document_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Document_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Document]'))
ALTER TABLE [dbo].[Document] DROP CONSTRAINT [FK_Document_LoginUser]
GO
/****** Object:  ForeignKey [FK_DocumentCource_Document]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DocumentCource_Document]') AND parent_object_id = OBJECT_ID(N'[dbo].[DocumentCource]'))
ALTER TABLE [dbo].[DocumentCource] DROP CONSTRAINT [FK_DocumentCource_Document]
GO
/****** Object:  ForeignKey [FK_Event_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Event_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Event]'))
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [FK_Event_LoginUser]
GO
/****** Object:  ForeignKey [FK_Exam_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Exam_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Exam]'))
ALTER TABLE [dbo].[Exam] DROP CONSTRAINT [FK_Exam_LoginUser]
GO
/****** Object:  ForeignKey [FK_EXM_Answer_EXM_Question]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXM_Answer_EXM_Question]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXM_Answer]'))
ALTER TABLE [dbo].[EXM_Answer] DROP CONSTRAINT [FK_EXM_Answer_EXM_Question]
GO
/****** Object:  ForeignKey [FK_EXM_Question_Exam]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXM_Question_Exam]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXM_Question]'))
ALTER TABLE [dbo].[EXM_Question] DROP CONSTRAINT [FK_EXM_Question_Exam]
GO
/****** Object:  ForeignKey [FK_Institute_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Institute_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Institute]'))
ALTER TABLE [dbo].[Institute] DROP CONSTRAINT [FK_Institute_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteCource_Cource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCource_Cource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCource]'))
ALTER TABLE [dbo].[InstituteCource] DROP CONSTRAINT [FK_InstituteCource_Cource]
GO
/****** Object:  ForeignKey [FK_InstituteCource_Institute]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCource_Institute]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCource]'))
ALTER TABLE [dbo].[InstituteCource] DROP CONSTRAINT [FK_InstituteCource_Institute]
GO
/****** Object:  ForeignKey [FK_InstituteCourceUser_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCourceUser_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]'))
ALTER TABLE [dbo].[InstituteCourceUser] DROP CONSTRAINT [FK_InstituteCourceUser_InstituteCource]
GO
/****** Object:  ForeignKey [FK_InstituteCourceUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCourceUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]'))
ALTER TABLE [dbo].[InstituteCourceUser] DROP CONSTRAINT [FK_InstituteCourceUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteSubject_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteSubject_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteSubject]'))
ALTER TABLE [dbo].[InstituteSubject] DROP CONSTRAINT [FK_InstituteSubject_InstituteCource]
GO
/****** Object:  ForeignKey [FK_InstituteUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUser]'))
ALTER TABLE [dbo].[InstituteUser] DROP CONSTRAINT [FK_InstituteUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteUserInUserType_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteUserInUserType_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUserInUserType]'))
ALTER TABLE [dbo].[InstituteUserInUserType] DROP CONSTRAINT [FK_InstituteUserInUserType_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_InstituteTypeRight_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteTypeRight_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUserTypeAccess]'))
ALTER TABLE [dbo].[InstituteUserTypeAccess] DROP CONSTRAINT [FK_InstituteTypeRight_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_Instructor_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Instructor_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[Instructor]'))
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [FK_Instructor_InstituteCource]
GO
/****** Object:  ForeignKey [FK_LoginUser_aspnet_Users]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LoginUser_aspnet_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoginUser]'))
ALTER TABLE [dbo].[LoginUser] DROP CONSTRAINT [FK_LoginUser_aspnet_Users]
GO
/****** Object:  ForeignKey [FK_Message_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Message_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Message]'))
ALTER TABLE [dbo].[Message] DROP CONSTRAINT [FK_Message_LoginUser]
GO
/****** Object:  ForeignKey [FK_OrderItem_Order]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderItem_Order]
GO
/****** Object:  ForeignKey [FK_Payment_Order]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment] DROP CONSTRAINT [FK_Payment_Order]
GO
/****** Object:  ForeignKey [FK_Question_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Question_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_LoginUser]
GO
/****** Object:  ForeignKey [FK_Question_QuestionType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Question_QuestionType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question] DROP CONSTRAINT [FK_Question_QuestionType]
GO
/****** Object:  ForeignKey [FK_ShareGroup_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareGroup_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareGroup]'))
ALTER TABLE [dbo].[ShareGroup] DROP CONSTRAINT [FK_ShareGroup_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_ShareGroup_Share]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareGroup_Share]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareGroup]'))
ALTER TABLE [dbo].[ShareGroup] DROP CONSTRAINT [FK_ShareGroup_Share]
GO
/****** Object:  ForeignKey [FK_ShareUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareUser]'))
ALTER TABLE [dbo].[ShareUser] DROP CONSTRAINT [FK_ShareUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_ShareUser_Share]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareUser_Share]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareUser]'))
ALTER TABLE [dbo].[ShareUser] DROP CONSTRAINT [FK_ShareUser_Share]
GO
/****** Object:  ForeignKey [FK_Tutorial_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tutorial_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tutorial]'))
ALTER TABLE [dbo].[Tutorial] DROP CONSTRAINT [FK_Tutorial_LoginUser]
GO
/****** Object:  ForeignKey [FK_Tutorial_TutorialType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tutorial_TutorialType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tutorial]'))
ALTER TABLE [dbo].[Tutorial] DROP CONSTRAINT [FK_Tutorial_TutorialType]
GO
/****** Object:  ForeignKey [FK_User_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_LoginUser]
GO
/****** Object:  ForeignKey [FK_UserEducation_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserEducation_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserEducation]'))
ALTER TABLE [dbo].[UserEducation] DROP CONSTRAINT [FK_UserEducation_LoginUser]
GO
/****** Object:  ForeignKey [FK_UserExam_Exam]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserExam_Exam]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExam]'))
ALTER TABLE [dbo].[UserExam] DROP CONSTRAINT [FK_UserExam_Exam]
GO
/****** Object:  ForeignKey [FK_UserExam_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserExam_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExam]'))
ALTER TABLE [dbo].[UserExam] DROP CONSTRAINT [FK_UserExam_LoginUser]
GO
/****** Object:  ForeignKey [FK_Widget_Page]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Widget_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[Widget]'))
ALTER TABLE [dbo].[Widget] DROP CONSTRAINT [FK_Widget_Page]
GO
/****** Object:  Default [DF__aspnet_Ap__Appli__286302EC]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Ap__Appli__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Applications]'))
Begin
ALTER TABLE [dbo].[aspnet_Applications] DROP CONSTRAINT [DF__aspnet_Ap__Appli__286302EC]

End
GO
/****** Object:  Default [DF__aspnet_Me__Passw__3D5E1FD2]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Me__Passw__3D5E1FD2]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
Begin
ALTER TABLE [dbo].[aspnet_Membership] DROP CONSTRAINT [DF__aspnet_Me__Passw__3D5E1FD2]

End
GO
/****** Object:  Default [DF__aspnet_Pa__PathI__6E01572D]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Pa__PathI__6E01572D]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]'))
Begin
ALTER TABLE [dbo].[aspnet_Paths] DROP CONSTRAINT [DF__aspnet_Pa__PathI__6E01572D]

End
GO
/****** Object:  Default [DF__aspnet_Perso__Id__75A278F5]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Perso__Id__75A278F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
Begin
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] DROP CONSTRAINT [DF__aspnet_Perso__Id__75A278F5]

End
GO
/****** Object:  Default [DF__aspnet_Ro__RoleI__5AEE82B9]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Ro__RoleI__5AEE82B9]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]'))
Begin
ALTER TABLE [dbo].[aspnet_Roles] DROP CONSTRAINT [DF__aspnet_Ro__RoleI__5AEE82B9]

End
GO
/****** Object:  Default [DF__aspnet_Us__UserI__2C3393D0]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__UserI__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] DROP CONSTRAINT [DF__aspnet_Us__UserI__2C3393D0]

End
GO
/****** Object:  Default [DF__aspnet_Us__Mobil__2D27B809]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__Mobil__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] DROP CONSTRAINT [DF__aspnet_Us__Mobil__2D27B809]

End
GO
/****** Object:  Default [DF__aspnet_Us__IsAno__2E1BDC42]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__IsAno__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] DROP CONSTRAINT [DF__aspnet_Us__IsAno__2E1BDC42]

End
GO
/****** Object:  Default [DF_LoginUser_UserId]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_LoginUser_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoginUser]'))
Begin
ALTER TABLE [dbo].[LoginUser] DROP CONSTRAINT [DF_LoginUser_UserId]

End
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_FindState]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_FindState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAdministration_FindState]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetSharedState]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_ResetSharedState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetSharedState]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_DeleteAllState]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_DeleteAllState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAdministration_DeleteAllState]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[UserExamResult]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamResult]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[UserExamResult]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteProfiles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_DeleteProfiles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_DeleteProfiles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_CreateRole]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_CreateRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Roles_CreateRole]
GO
/****** Object:  StoredProcedure [dbo].[GetShareGroup]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetShareGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetShareGroup]
GO
/****** Object:  StoredProcedure [dbo].[GetGroupObjectAccess]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetGroupObjectAccess]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetGroupObjectAccess]
GO
/****** Object:  StoredProcedure [dbo].[GetExamResultByLoginUserIDDumi]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamResultByLoginUserIDDumi]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetExamResultByLoginUserIDDumi]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_SetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_SetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationPerUser_SetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_GetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_GetPageSettings]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationPerUser_GetPageSettings]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_CreateUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_CreateUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_CreateUser]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_GetCountOfState]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_GetCountOfState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAdministration_GetCountOfState]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetUserState]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_ResetUserState]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetUserState]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_SetProperties]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_SetProperties]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_SetProperties]
GO
/****** Object:  StoredProcedure [dbo].[GetUserObjectAccess]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserObjectAccess]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserObjectAccess]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestion]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetQuestion]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionByQuestionID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionByQuestionID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetQuestionByQuestionID]
GO
/****** Object:  StoredProcedure [dbo].[GetAnswerByQuestionID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAnswerByQuestionID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetAnswerByQuestionID]
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionByLoginUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetQuestionByLoginUserID]
GO
/****** Object:  StoredProcedure [dbo].[GetShareUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetShareUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetShareUser]
GO
/****** Object:  StoredProcedure [dbo].[GetExamsResultByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamsResultByLoginUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetExamsResultByLoginUserID]
GO
/****** Object:  StoredProcedure [dbo].[GetExamResultByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamResultByLoginUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetExamResultByLoginUserID]
GO
/****** Object:  StoredProcedure [dbo].[ExamUserByExamID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamUserByExamID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ExamUserByExamID]
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_User]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_User]'))
DROP VIEW [dbo].[vw_aspnet_WebPartState_User]
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Shared]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_Shared]'))
DROP VIEW [dbo].[vw_aspnet_WebPartState_Shared]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Paths_CreatePath]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Paths_CreatePath]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Paths_CreatePath]
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Paths]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_Paths]'))
DROP VIEW [dbo].[vw_aspnet_WebPartState_Paths]
GO
/****** Object:  UserDefinedFunction [dbo].[GetQuestionStatus]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetQuestionStatus]
GO
/****** Object:  View [dbo].[vw_aspnet_UsersInRoles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_UsersInRoles]'))
DROP VIEW [dbo].[vw_aspnet_UsersInRoles]
GO
/****** Object:  UserDefinedFunction [dbo].[GetInstituteSubjectName]    Script Date: 08/14/2010 17:31:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteSubjectName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetInstituteSubjectName]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAnswerStatus]    Script Date: 08/14/2010 17:31:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAnswerStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetAnswerStatus]
GO
/****** Object:  View [dbo].[vw_aspnet_Roles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Roles]'))
DROP VIEW [dbo].[vw_aspnet_Roles]
GO
/****** Object:  View [dbo].[vw_aspnet_Profiles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Profiles]'))
DROP VIEW [dbo].[vw_aspnet_Profiles]
GO
/****** Object:  StoredProcedure [dbo].[GetCourceByInstituteID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCourceByInstituteID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetCourceByInstituteID]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_RegisterSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_RegisterSchemaVersion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_RegisterSchemaVersion]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_CheckSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_CheckSchemaVersion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_CheckSchemaVersion]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UnRegisterSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UnRegisterSchemaVersion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UnRegisterSchemaVersion]
GO
/****** Object:  UserDefinedFunction [dbo].[GetMultiChoiceMark]    Script Date: 08/14/2010 17:31:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetMultiChoiceMark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetMultiChoiceMark]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSingleChoiceMark]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSingleChoiceMark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetSingleChoiceMark]
GO
/****** Object:  UserDefinedFunction [dbo].[GetExamTotalmark]    Script Date: 08/14/2010 17:31:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamTotalmark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetExamTotalmark]
GO
/****** Object:  View [dbo].[vw_aspnet_MembershipUsers]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_MembershipUsers]'))
DROP VIEW [dbo].[vw_aspnet_MembershipUsers]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByUserId]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByUserId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetUserByUserId]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_CreateUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users_CreateUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Users_CreateUser]
GO
/****** Object:  View [dbo].[vw_aspnet_Users]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Users]'))
DROP VIEW [dbo].[vw_aspnet_Users]
GO
/****** Object:  StoredProcedure [dbo].[GetHTMLWidgetByWidgetID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetHTMLWidgetByWidgetID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetHTMLWidgetByWidgetID]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetUsersInRoles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_GetUsersInRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_GetUsersInRoles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_AddUsersToRoles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_AddUsersToRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_AddUsersToRoles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_IsUserInRole]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_IsUserInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_IsUserInRole]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetRolesForUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_GetRolesForUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_GetRolesForUser]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_DeleteRole]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_DeleteRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Roles_DeleteRole]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_RoleExists]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_RoleExists]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Roles_RoleExists]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByEmail]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_FindUsersByEmail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_FindUsersByEmail]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByName]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_FindUsersByName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_FindUsersByName]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetNumberOfUsersOnline]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetNumberOfUsersOnline]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetNumberOfUsersOnline]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetAllUsers]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetAllUsers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetAllUsers]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProperties]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetProperties]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_GetProperties]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProfiles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetProfiles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_GetProfiles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteInactiveProfiles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_DeleteInactiveProfiles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Profile_DeleteInactiveProfiles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_GetAllRoles]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_GetAllRoles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Roles_GetAllRoles]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_FindUsersInRole]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_FindUsersInRole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_UsersInRoles_FindUsersInRole]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Personalization_GetApplicationId]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Personalization_GetApplicationId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Personalization_GetApplicationId]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ResetPassword]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_ResetPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_ResetPassword]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_SetPassword]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_SetPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_SetPassword]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPassword]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetPassword]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetPassword]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUserInfo]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UpdateUserInfo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_UpdateUserInfo]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UnlockUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UnlockUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_UnlockUser]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UpdateUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_UpdateUser]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByEmail]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByEmail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetUserByEmail]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPasswordWithFormat]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetPasswordWithFormat]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetPasswordWithFormat]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByName]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Membership_GetUserByName]
GO
/****** Object:  View [dbo].[vw_aspnet_Applications]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Applications]'))
DROP VIEW [dbo].[vw_aspnet_Applications]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_DeleteUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users_DeleteUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Users_DeleteUser]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_AnyDataInTables]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_AnyDataInTables]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_AnyDataInTables]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Applications_CreateApplication]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Applications_CreateApplication]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Applications_CreateApplication]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableView]    Script Date: 08/14/2010 17:31:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableView]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableView]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableDelete]    Script Date: 08/14/2010 17:31:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableDelete]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableDelete]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableEdit]    Script Date: 08/14/2010 17:31:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableEdit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableEdit]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableAdd]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableAdd]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableAdd]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableDeleteGroup]    Script Date: 08/14/2010 17:31:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableDeleteGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableDeleteGroup]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableViewGroup]    Script Date: 08/14/2010 17:31:03 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableViewGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableViewGroup]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableAddGroup]    Script Date: 08/14/2010 17:31:01 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableAddGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableAddGroup]
GO
/****** Object:  UserDefinedFunction [dbo].[EnableEditGroup]    Script Date: 08/14/2010 17:31:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableEditGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[EnableEditGroup]
GO
/****** Object:  StoredProcedure [dbo].[GetTutorial]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTutorial]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetTutorial]
GO
/****** Object:  StoredProcedure [dbo].[GetInstituteUserFeatureAccess]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteUserFeatureAccess]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInstituteUserFeatureAccess]
GO
/****** Object:  StoredProcedure [dbo].[GetUserByInsituteCourceID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserByInsituteCourceID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserByInsituteCourceID]
GO
/****** Object:  StoredProcedure [dbo].[GetInstituteByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteByLoginUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInstituteByLoginUserID]
GO
/****** Object:  StoredProcedure [dbo].[GetContent]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetContent]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetContent]
GO
/****** Object:  StoredProcedure [dbo].[GetUserContent]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserContent]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserContent]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_WebEvent_LogEvent]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_WebEvent_LogEvent]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_WebEvent_LogEvent]
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUser]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUser]
GO
/****** Object:  UserDefinedFunction [dbo].[GetInstituteCourceName]    Script Date: 08/14/2010 17:31:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteCourceName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetInstituteCourceName]
GO
/****** Object:  StoredProcedure [dbo].[GetUserRelatedContentSearch]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRelatedContentSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserRelatedContentSearch]
GO
/****** Object:  StoredProcedure [dbo].[GetUserRelatedContent]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRelatedContent]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetUserRelatedContent]
GO
/****** Object:  StoredProcedure [dbo].[GetInboxMessage]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInboxMessage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetInboxMessage]
GO
/****** Object:  StoredProcedure [dbo].[GetSentMessage]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSentMessage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetSentMessage]
GO
/****** Object:  StoredProcedure [dbo].[GetFullMessage]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFullMessage]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetFullMessage]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalMarksByExamAndUserExamID]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTotalMarksByExamAndUserExamID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetTotalMarksByExamAndUserExamID]
GO
/****** Object:  Table [dbo].[aspnet_PersonalizationAllUsers]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_PersonalizationAllUsers]
GO
/****** Object:  Table [dbo].[Widget]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Widget]') AND type in (N'U'))
DROP TABLE [dbo].[Widget]
GO
/****** Object:  Table [dbo].[InstituteUserTypeAccess]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserTypeAccess]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteUserTypeAccess]
GO
/****** Object:  Table [dbo].[ShareGroup]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShareGroup]') AND type in (N'U'))
DROP TABLE [dbo].[ShareGroup]
GO
/****** Object:  Table [dbo].[InstituteUserInUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserInUserType]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteUserInUserType]
GO
/****** Object:  Table [dbo].[EXM_Answer]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_Answer]') AND type in (N'U'))
DROP TABLE [dbo].[EXM_Answer]
GO
/****** Object:  Table [dbo].[EXM_Question]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_Question]') AND type in (N'U'))
DROP TABLE [dbo].[EXM_Question]
GO
/****** Object:  Table [dbo].[DocumentCource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DocumentCource]') AND type in (N'U'))
DROP TABLE [dbo].[DocumentCource]
GO
/****** Object:  Table [dbo].[aspnet_UsersInRoles]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_UsersInRoles]
GO
/****** Object:  Table [dbo].[aspnet_Profile]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Profile]
GO
/****** Object:  Table [dbo].[aspnet_PersonalizationPerUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_PersonalizationPerUser]
GO
/****** Object:  Table [dbo].[aspnet_Roles]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Roles]
GO
/****** Object:  Table [dbo].[aspnet_Paths]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Paths]
GO
/****** Object:  Table [dbo].[aspnet_Membership]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Membership]
GO
/****** Object:  Table [dbo].[Tutorial]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tutorial]') AND type in (N'U'))
DROP TABLE [dbo].[Tutorial]
GO
/****** Object:  Table [dbo].[InstituteUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUser]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteUser]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[Document]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Document]') AND type in (N'U'))
DROP TABLE [dbo].[Document]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Event]') AND type in (N'U'))
DROP TABLE [dbo].[Event]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Article]') AND type in (N'U'))
DROP TABLE [dbo].[Article]
GO
/****** Object:  Table [dbo].[ShareUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShareUser]') AND type in (N'U'))
DROP TABLE [dbo].[ShareUser]
GO
/****** Object:  Table [dbo].[UserEducation]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserEducation]') AND type in (N'U'))
DROP TABLE [dbo].[UserEducation]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Message]') AND type in (N'U'))
DROP TABLE [dbo].[Message]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comment]') AND type in (N'U'))
DROP TABLE [dbo].[Comment]
GO
/****** Object:  Table [dbo].[UserExam]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExam]') AND type in (N'U'))
DROP TABLE [dbo].[UserExam]
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type in (N'U'))
DROP TABLE [dbo].[Exam]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Answer]') AND type in (N'U'))
DROP TABLE [dbo].[Answer]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type in (N'U'))
DROP TABLE [dbo].[Question]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem]') AND type in (N'U'))
DROP TABLE [dbo].[OrderItem]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Payment]') AND type in (N'U'))
DROP TABLE [dbo].[Payment]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Instructor]') AND type in (N'U'))
DROP TABLE [dbo].[Instructor]
GO
/****** Object:  Table [dbo].[InstituteCourceUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteCourceUser]
GO
/****** Object:  Table [dbo].[InstituteSubject]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteSubject]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteSubject]
GO
/****** Object:  Table [dbo].[InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteCource]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteCource]
GO
/****** Object:  Table [dbo].[Institute]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Institute]') AND type in (N'U'))
DROP TABLE [dbo].[Institute]
GO
/****** Object:  Table [dbo].[LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
DROP TABLE [dbo].[LoginUser]
GO
/****** Object:  Table [dbo].[aspnet_Users]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Users]
GO
/****** Object:  Table [dbo].[Cource]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cource]') AND type in (N'U'))
DROP TABLE [dbo].[Cource]
GO
/****** Object:  Table [dbo].[Share]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Share]') AND type in (N'U'))
DROP TABLE [dbo].[Share]
GO
/****** Object:  Table [dbo].[QuestionType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionType]') AND type in (N'U'))
DROP TABLE [dbo].[QuestionType]
GO
/****** Object:  Table [dbo].[QuestionStatus]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionStatus]') AND type in (N'U'))
DROP TABLE [dbo].[QuestionStatus]
GO
/****** Object:  Table [dbo].[AnswerState]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnswerState]') AND type in (N'U'))
DROP TABLE [dbo].[AnswerState]
GO
/****** Object:  Table [dbo].[College]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[College]') AND type in (N'U'))
DROP TABLE [dbo].[College]
GO
/****** Object:  Table [dbo].[CourceCatagory]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourceCatagory]') AND type in (N'U'))
DROP TABLE [dbo].[CourceCatagory]
GO
/****** Object:  Table [dbo].[TutorialType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TutorialType]') AND type in (N'U'))
DROP TABLE [dbo].[TutorialType]
GO
/****** Object:  Table [dbo].[SystemConfiguration]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemConfiguration]') AND type in (N'U'))
DROP TABLE [dbo].[SystemConfiguration]
GO
/****** Object:  Table [dbo].[WidgetPage]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WidgetPage]') AND type in (N'U'))
DROP TABLE [dbo].[WidgetPage]
GO
/****** Object:  Table [dbo].[InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserType]') AND type in (N'U'))
DROP TABLE [dbo].[InstituteUserType]
GO
/****** Object:  Table [dbo].[aspnet_SchemaVersions]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_SchemaVersions]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_SchemaVersions]
GO
/****** Object:  Table [dbo].[HTMLWidget]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HTMLWidget]') AND type in (N'U'))
DROP TABLE [dbo].[HTMLWidget]
GO
/****** Object:  Table [dbo].[aspnet_Applications]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Applications]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_Applications]
GO
/****** Object:  Table [dbo].[Editor]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editor]') AND type in (N'U'))
DROP TABLE [dbo].[Editor]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RemoveAllRoleMembers]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Setup_RemoveAllRoleMembers]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Setup_RemoveAllRoleMembers]
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RestorePermissions]    Script Date: 08/14/2010 17:31:06 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Setup_RestorePermissions]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[aspnet_Setup_RestorePermissions]
GO
/****** Object:  Table [dbo].[Ratting]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ratting]') AND type in (N'U'))
DROP TABLE [dbo].[Ratting]
GO
/****** Object:  Table [dbo].[HomeWork]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomeWork]') AND type in (N'U'))
DROP TABLE [dbo].[HomeWork]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
DROP TABLE [dbo].[Order]
GO
/****** Object:  UserDefinedFunction [dbo].[GetProfilePic]    Script Date: 08/14/2010 17:31:05 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProfilePic]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetProfilePic]
GO
/****** Object:  Table [dbo].[aspnet_WebEvent_Events]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_WebEvent_Events]') AND type in (N'U'))
DROP TABLE [dbo].[aspnet_WebEvent_Events]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFullName]    Script Date: 08/14/2010 17:31:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFullName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[GetFullName]
GO
/****** Object:  Table [dbo].[EXM_UserAnswer]    Script Date: 08/14/2010 17:31:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_UserAnswer]') AND type in (N'U'))
DROP TABLE [dbo].[EXM_UserAnswer]
GO
/****** Object:  Schema [aspnet_Membership_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_BasicAccess')
DROP SCHEMA [aspnet_Membership_BasicAccess]
GO
/****** Object:  Schema [aspnet_Membership_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_FullAccess')
DROP SCHEMA [aspnet_Membership_FullAccess]
GO
/****** Object:  Schema [aspnet_Membership_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_ReportingAccess')
DROP SCHEMA [aspnet_Membership_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Personalization_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_BasicAccess')
DROP SCHEMA [aspnet_Personalization_BasicAccess]
GO
/****** Object:  Schema [aspnet_Personalization_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_FullAccess')
DROP SCHEMA [aspnet_Personalization_FullAccess]
GO
/****** Object:  Schema [aspnet_Personalization_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_ReportingAccess')
DROP SCHEMA [aspnet_Personalization_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Profile_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_BasicAccess')
DROP SCHEMA [aspnet_Profile_BasicAccess]
GO
/****** Object:  Schema [aspnet_Profile_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_FullAccess')
DROP SCHEMA [aspnet_Profile_FullAccess]
GO
/****** Object:  Schema [aspnet_Profile_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_ReportingAccess')
DROP SCHEMA [aspnet_Profile_ReportingAccess]
GO
/****** Object:  Schema [aspnet_Roles_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_BasicAccess')
DROP SCHEMA [aspnet_Roles_BasicAccess]
GO
/****** Object:  Schema [aspnet_Roles_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_FullAccess')
DROP SCHEMA [aspnet_Roles_FullAccess]
GO
/****** Object:  Schema [aspnet_Roles_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_ReportingAccess')
DROP SCHEMA [aspnet_Roles_ReportingAccess]
GO
/****** Object:  Schema [aspnet_WebEvent_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_WebEvent_FullAccess')
DROP SCHEMA [aspnet_WebEvent_FullAccess]
GO
/****** Object:  Role [aspnet_Membership_BasicAccess]    Script Date: 08/14/2010 17:31:06 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Membership_BasicAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_BasicAccess' AND type = 'R')
DROP ROLE [aspnet_Membership_BasicAccess]
GO
/****** Object:  Role [aspnet_Membership_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Membership_FullAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_FullAccess' AND type = 'R')
DROP ROLE [aspnet_Membership_FullAccess]
GO
/****** Object:  Role [aspnet_Membership_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Membership_ReportingAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_ReportingAccess' AND type = 'R')
DROP ROLE [aspnet_Membership_ReportingAccess]
GO
/****** Object:  Role [aspnet_Personalization_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Personalization_BasicAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_BasicAccess' AND type = 'R')
DROP ROLE [aspnet_Personalization_BasicAccess]
GO
/****** Object:  Role [aspnet_Personalization_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Personalization_FullAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_FullAccess' AND type = 'R')
DROP ROLE [aspnet_Personalization_FullAccess]
GO
/****** Object:  Role [aspnet_Personalization_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Personalization_ReportingAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_ReportingAccess' AND type = 'R')
DROP ROLE [aspnet_Personalization_ReportingAccess]
GO
/****** Object:  Role [aspnet_Profile_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Profile_BasicAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_BasicAccess' AND type = 'R')
DROP ROLE [aspnet_Profile_BasicAccess]
GO
/****** Object:  Role [aspnet_Profile_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Profile_FullAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_FullAccess' AND type = 'R')
DROP ROLE [aspnet_Profile_FullAccess]
GO
/****** Object:  Role [aspnet_Profile_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Profile_ReportingAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_ReportingAccess' AND type = 'R')
DROP ROLE [aspnet_Profile_ReportingAccess]
GO
/****** Object:  Role [aspnet_Roles_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Roles_BasicAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_BasicAccess' AND type = 'R')
DROP ROLE [aspnet_Roles_BasicAccess]
GO
/****** Object:  Role [aspnet_Roles_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Roles_FullAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_FullAccess' AND type = 'R')
DROP ROLE [aspnet_Roles_FullAccess]
GO
/****** Object:  Role [aspnet_Roles_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_Roles_ReportingAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_ReportingAccess' AND type = 'R')
DROP ROLE [aspnet_Roles_ReportingAccess]
GO
/****** Object:  Role [aspnet_WebEvent_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
DECLARE @RoleName sysname
set @RoleName = N'aspnet_WebEvent_FullAccess'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from dbo.sysusers 
	where uid in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_WebEvent_FullAccess' AND type = 'R')
DROP ROLE [aspnet_WebEvent_FullAccess]
GO
/****** Object:  Role [aspnet_Membership_BasicAccess]    Script Date: 08/14/2010 17:31:06 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_BasicAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_BasicAccess' AND type = 'R')
CREATE ROLE [aspnet_Membership_BasicAccess]

END
GO
/****** Object:  Role [aspnet_Membership_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_FullAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_FullAccess' AND type = 'R')
CREATE ROLE [aspnet_Membership_FullAccess]

END
GO
/****** Object:  Role [aspnet_Membership_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_ReportingAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_ReportingAccess' AND type = 'R')
CREATE ROLE [aspnet_Membership_ReportingAccess]

END
GO
/****** Object:  Role [aspnet_Personalization_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_BasicAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_BasicAccess' AND type = 'R')
CREATE ROLE [aspnet_Personalization_BasicAccess]

END
GO
/****** Object:  Role [aspnet_Personalization_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_FullAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_FullAccess' AND type = 'R')
CREATE ROLE [aspnet_Personalization_FullAccess]

END
GO
/****** Object:  Role [aspnet_Personalization_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_ReportingAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_ReportingAccess' AND type = 'R')
CREATE ROLE [aspnet_Personalization_ReportingAccess]

END
GO
/****** Object:  Role [aspnet_Profile_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_BasicAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_BasicAccess' AND type = 'R')
CREATE ROLE [aspnet_Profile_BasicAccess]

END
GO
/****** Object:  Role [aspnet_Profile_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_FullAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_FullAccess' AND type = 'R')
CREATE ROLE [aspnet_Profile_FullAccess]

END
GO
/****** Object:  Role [aspnet_Profile_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_ReportingAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_ReportingAccess' AND type = 'R')
CREATE ROLE [aspnet_Profile_ReportingAccess]

END
GO
/****** Object:  Role [aspnet_Roles_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_BasicAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_BasicAccess' AND type = 'R')
CREATE ROLE [aspnet_Roles_BasicAccess]

END
GO
/****** Object:  Role [aspnet_Roles_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_FullAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_FullAccess' AND type = 'R')
CREATE ROLE [aspnet_Roles_FullAccess]

END
GO
/****** Object:  Role [aspnet_Roles_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_ReportingAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_ReportingAccess' AND type = 'R')
CREATE ROLE [aspnet_Roles_ReportingAccess]

END
GO
/****** Object:  Role [aspnet_WebEvent_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_WebEvent_FullAccess')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_WebEvent_FullAccess' AND type = 'R')
CREATE ROLE [aspnet_WebEvent_FullAccess]

END
GO
/****** Object:  Schema [aspnet_Membership_BasicAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_BasicAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Membership_BasicAccess] AUTHORIZATION [aspnet_Membership_BasicAccess]'
GO
/****** Object:  Schema [aspnet_Membership_FullAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_FullAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Membership_FullAccess] AUTHORIZATION [aspnet_Membership_FullAccess]'
GO
/****** Object:  Schema [aspnet_Membership_ReportingAccess]    Script Date: 08/14/2010 17:31:07 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Membership_ReportingAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Membership_ReportingAccess] AUTHORIZATION [aspnet_Membership_ReportingAccess]'
GO
/****** Object:  Schema [aspnet_Personalization_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_BasicAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Personalization_BasicAccess] AUTHORIZATION [aspnet_Personalization_BasicAccess]'
GO
/****** Object:  Schema [aspnet_Personalization_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_FullAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Personalization_FullAccess] AUTHORIZATION [aspnet_Personalization_FullAccess]'
GO
/****** Object:  Schema [aspnet_Personalization_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Personalization_ReportingAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Personalization_ReportingAccess] AUTHORIZATION [aspnet_Personalization_ReportingAccess]'
GO
/****** Object:  Schema [aspnet_Profile_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_BasicAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Profile_BasicAccess] AUTHORIZATION [aspnet_Profile_BasicAccess]'
GO
/****** Object:  Schema [aspnet_Profile_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_FullAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Profile_FullAccess] AUTHORIZATION [aspnet_Profile_FullAccess]'
GO
/****** Object:  Schema [aspnet_Profile_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Profile_ReportingAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Profile_ReportingAccess] AUTHORIZATION [aspnet_Profile_ReportingAccess]'
GO
/****** Object:  Schema [aspnet_Roles_BasicAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_BasicAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Roles_BasicAccess] AUTHORIZATION [aspnet_Roles_BasicAccess]'
GO
/****** Object:  Schema [aspnet_Roles_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_FullAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Roles_FullAccess] AUTHORIZATION [aspnet_Roles_FullAccess]'
GO
/****** Object:  Schema [aspnet_Roles_ReportingAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_Roles_ReportingAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_Roles_ReportingAccess] AUTHORIZATION [aspnet_Roles_ReportingAccess]'
GO
/****** Object:  Schema [aspnet_WebEvent_FullAccess]    Script Date: 08/14/2010 17:31:08 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'aspnet_WebEvent_FullAccess')
EXEC sys.sp_executesql N'CREATE SCHEMA [aspnet_WebEvent_FullAccess] AUTHORIZATION [aspnet_WebEvent_FullAccess]'
GO
/****** Object:  Table [dbo].[EXM_UserAnswer]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_UserAnswer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EXM_UserAnswer](
	[EXM_UserAnswerID] [int] IDENTITY(1,1) NOT NULL,
	[UserExamID] [int] NULL,
	[LoginUserID] [int] NOT NULL,
	[EXM_QuestionID] [int] NOT NULL,
	[EXM_AnswerID] [int] NOT NULL,
	[EXM_AnswerText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RecieveMark] [decimal](18, 0) NULL,
	[IsRightMark] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_EXM_UserAnswer] PRIMARY KEY CLUSTERED 
(
	[EXM_UserAnswerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EXM_UserAnswer] ON
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (681, 361, 44, 49, 106, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD000EC6F2E AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (682, 361, 44, 49, 107, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD000EC6F37 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (685, 362, 43, 48, 105, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD201110F21 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (686, 362, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD201111052 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (687, 362, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD201111057 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (696, 363, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011612EB AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (698, 363, 43, 48, 103, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011616BA AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (699, 364, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD201171904 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (700, 364, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD201171AD4 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (701, 365, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011755E6 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (702, 365, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011757EE AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (703, 366, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD201180F88 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (704, 366, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011810FF AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (705, 367, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011857C9 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (706, 368, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD201189E3A AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (707, 368, 43, 48, 105, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD20118A102 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (708, 372, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011AA144 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (709, 372, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011AA14D AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (710, 372, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011AA3CF AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (711, 375, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011BEE89 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (712, 376, 43, 49, 107, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011C23D6 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (713, 376, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011C23DB AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (714, 376, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011C23E0 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (715, 376, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011C28CD AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (716, 377, 43, 49, 107, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011CFECB AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (717, 377, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011CFED5 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (718, 377, 43, 49, 109, N'', CAST(-2 AS Decimal(18, 0)), 0, CAST(0x00009DD2011CFED9 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (719, 377, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011D00CF AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (720, 378, 43, 49, 107, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011D369B AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (721, 378, 43, 49, 108, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011D36A0 AS DateTime))
INSERT [dbo].[EXM_UserAnswer] ([EXM_UserAnswerID], [UserExamID], [LoginUserID], [EXM_QuestionID], [EXM_AnswerID], [EXM_AnswerText], [RecieveMark], [IsRightMark], [ModifiedDate]) VALUES (722, 378, 43, 48, 104, N'', CAST(2 AS Decimal(18, 0)), 1, CAST(0x00009DD2011D3A0C AS DateTime))
SET IDENTITY_INSERT [dbo].[EXM_UserAnswer] OFF
/****** Object:  UserDefinedFunction [dbo].[GetFullName]    Script Date: 08/14/2010 17:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFullName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create Function [dbo].[GetFullName](@LoginUserID as int)
RETURNS varchar(max)
as
BEGIN
DECLARE @fullName as varchar(max)

SELECT     @fullName=FirstName+'' ''+LastName
FROM         [User]
WHERE     (LoginUserID = @LoginUserID)
return @fullName
END' 
END
GO
/****** Object:  Table [dbo].[aspnet_WebEvent_Events]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_WebEvent_Events]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_WebEvent_Events](
	[EventId] [char](32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EventTimeUtc] [datetime] NOT NULL,
	[EventTime] [datetime] NOT NULL,
	[EventType] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EventSequence] [decimal](19, 0) NOT NULL,
	[EventOccurrence] [decimal](19, 0) NOT NULL,
	[EventCode] [int] NOT NULL,
	[EventDetailCode] [int] NOT NULL,
	[Message] [nvarchar](1024) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ApplicationPath] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ApplicationVirtualPath] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MachineName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RequestUrl] [nvarchar](1024) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ExceptionType] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Details] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__aspnet_WebEvent___06CD04F7] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetProfilePic]    Script Date: 08/14/2010 17:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProfilePic]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create Function [dbo].[GetProfilePic](@LoginUserID as int)
RETURNS varchar(max)
as
BEGIN
DECLARE @fullName as varchar(max)

SELECT     @fullName=PhotoPath
FROM         [User]
WHERE     (LoginUserID = @LoginUserID)
return @fullName
END' 
END
GO
/****** Object:  Table [dbo].[Order]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[OrderID] [uniqueidentifier] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[FirstName] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LastName] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhoneNumber] [varchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Fax] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address1] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address2] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[City] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[State] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Country] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ZipCode] [varchar](12) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[HomeWork]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomeWork]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HomeWork](
	[HomeWorkID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[EditLoginUserID] [int] NULL,
	[Title] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ShortDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[InstituteCourceID] [int] NULL,
	[InstituteSubjectID] [int] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_HomeWork] PRIMARY KEY CLUSTERED 
(
	[HomeWorkID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[HomeWork] ON
INSERT [dbo].[HomeWork] ([HomeWorkID], [LoginUserID], [EditLoginUserID], [Title], [Description], [ShortDescription], [InstituteCourceID], [InstituteSubjectID], [ModifiedDate]) VALUES (8, 43, 43, N'C Program to Calculate Factorial of a number using Recursion', N'Write a program to calculate the factorial of a number. Use the concept of recursion
instead of using loops.', N'Write a program to calculate the factorial of a number. Use the concept of recursion
instead of using loops.', 21, 9, CAST(0x00009DD000BE28BB AS DateTime))
SET IDENTITY_INSERT [dbo].[HomeWork] OFF
/****** Object:  Table [dbo].[Ratting]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ratting]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ratting](
	[RattingID] [uniqueidentifier] NOT NULL,
	[Rating] [int] NOT NULL,
	[ContentType] [int] NOT NULL,
	[ContentID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Ratting] PRIMARY KEY CLUSTERED 
(
	[RattingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Ratting] ([RattingID], [Rating], [ContentType], [ContentID], [ModifiedDate]) VALUES (N'128066c8-3641-47c4-b5fe-328056027036', 6, 1, N'5cff19d7-f6c1-46f5-ab95-726cd7cd58f1', CAST(0x00009DC9012C50F8 AS DateTime))
INSERT [dbo].[Ratting] ([RattingID], [Rating], [ContentType], [ContentID], [ModifiedDate]) VALUES (N'e42f6b3f-5886-4ea8-955d-6a201517cfdd', 2, 5, N'2f80c85b-f328-4475-a921-32c47e26da8c', CAST(0x00009DD000BC4B1A AS DateTime))
INSERT [dbo].[Ratting] ([RattingID], [Rating], [ContentType], [ContentID], [ModifiedDate]) VALUES (N'6e7d26bb-b16d-4c2b-8624-71b9663cb3cf', 4, 8, N'3e206b7a-2f21-4b00-ab79-fc4cc17dc60f', CAST(0x00009DD000C39E78 AS DateTime))
INSERT [dbo].[Ratting] ([RattingID], [Rating], [ContentType], [ContentID], [ModifiedDate]) VALUES (N'5ad5c125-8177-4d8c-9db0-83abc72e4479', 3, 1, N'4d2f8ae5-3741-426d-9c6e-349d84224e1f', CAST(0x00009DD10123FED9 AS DateTime))
INSERT [dbo].[Ratting] ([RattingID], [Rating], [ContentType], [ContentID], [ModifiedDate]) VALUES (N'e5744a0a-f08f-42cb-bcaa-90f3721b94ac', 1, 7, N'21', CAST(0x00009DD000EC09D9 AS DateTime))
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RestorePermissions]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Setup_RestorePermissions]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Setup_RestorePermissions]
    @name   sysname
AS
BEGIN
    DECLARE @object sysname
    DECLARE @protectType char(10)
    DECLARE @action varchar(60)
    DECLARE @grantee sysname
    DECLARE @cmd nvarchar(500)
    DECLARE c1 cursor FORWARD_ONLY FOR
        SELECT Object, ProtectType, [Action], Grantee FROM #aspnet_Permissions where Object = @name

    OPEN c1

    FETCH c1 INTO @object, @protectType, @action, @grantee
    WHILE (@@fetch_status = 0)
    BEGIN
        SET @cmd = @protectType + '' '' + @action + '' on '' + @object + '' TO ['' + @grantee + '']''
        EXEC (@cmd)
        FETCH c1 INTO @object, @protectType, @action, @grantee
    END

    CLOSE c1
    DEALLOCATE c1
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Setup_RemoveAllRoleMembers]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Setup_RemoveAllRoleMembers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Setup_RemoveAllRoleMembers]
    @name   sysname
AS
BEGIN
    CREATE TABLE #aspnet_RoleMembers
    (
        Group_name      sysname,
        Group_id        smallint,
        Users_in_group  sysname,
        User_id         smallint
    )

    INSERT INTO #aspnet_RoleMembers
    EXEC sp_helpuser @name

    DECLARE @user_id smallint
    DECLARE @cmd nvarchar(500)
    DECLARE c1 cursor FORWARD_ONLY FOR
        SELECT User_id FROM #aspnet_RoleMembers

    OPEN c1

    FETCH c1 INTO @user_id
    WHILE (@@fetch_status = 0)
    BEGIN
        SET @cmd = ''EXEC sp_droprolemember '' + '''''''' + @name + '''''', '''''' + USER_NAME(@user_id) + ''''''''
        EXEC (@cmd)
        FETCH c1 INTO @user_id
    END

    CLOSE c1
    DEALLOCATE c1
END' 
END
GO
/****** Object:  Table [dbo].[Editor]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Editor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Editor](
	[EditorID] [uniqueidentifier] NOT NULL,
	[ContentID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ContentType] [int] NOT NULL,
	[EditorLoginUserID] [int] NOT NULL,
	[Reason] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Editor] PRIMARY KEY CLUSTERED 
(
	[EditorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[aspnet_Applications]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Applications]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Applications](
	[ApplicationName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoweredApplicationName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[Description] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__aspnet_Applicati__25869641] PRIMARY KEY NONCLUSTERED 
(
	[ApplicationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [UQ__aspnet_Applicati__267ABA7A] UNIQUE NONCLUSTERED 
(
	[LoweredApplicationName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON),
 CONSTRAINT [UQ__aspnet_Applicati__276EDEB3] UNIQUE NONCLUSTERED 
(
	[ApplicationName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Applications]') AND name = N'aspnet_Applications_Index')
CREATE CLUSTERED INDEX [aspnet_Applications_Index] ON [dbo].[aspnet_Applications] 
(
	[LoweredApplicationName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
INSERT [dbo].[aspnet_Applications] ([ApplicationName], [LoweredApplicationName], [ApplicationId], [Description]) VALUES (N'/', N'/', N'abac3295-890d-4213-85c3-521cfee7c5d1', NULL)
/****** Object:  Table [dbo].[HTMLWidget]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HTMLWidget]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[HTMLWidget](
	[HTMLWidgetID] [uniqueidentifier] NOT NULL,
	[HTMLDATA] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_HTMLWidget] PRIMARY KEY CLUSTERED 
(
	[HTMLWidgetID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'd5cf7dbe-2f53-48fb-b2e1-046d1f6054c1', N'<p>Right 2</p>', CAST(0x00009DD100F09687 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'af73d4d1-1e70-422f-b17d-0bf067c71178', N'<p>dfgdfgdfg</p>', CAST(0x00009DD0017AA32A AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'7d76a588-abf4-477f-bfaf-485bafab558f', N'', CAST(0x00009DD200D5F740 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'95cc21d8-9bd4-4563-8864-5cbb8ab96180', N'<p>dgdgdgdfg</p>', CAST(0x00009DD00179ABAE AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'21695783-9159-4389-9dea-621254fafe8d', N'<p>Test 4</p>', CAST(0x00009DD100E138D6 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'6bca0df9-db20-4f5d-958f-65fb77117694', N'<p>dfgdfsgdfg</p>', CAST(0x00009DD10133444C AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'1b93c087-83b8-49bf-b8ca-824cc21a9261', N'', CAST(0x00009DD200FA1689 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'30a65c59-42ed-4569-82e1-8931ea870e2b', N'<p>hfdghgfdh</p>', CAST(0x00009DD1011986B7 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'2d8a71cc-28a3-4c2d-8c9d-a57e4827bf0b', N'<p>Rohan 3 test</p>', CAST(0x00009DD100E11AD3 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'2b46baf4-9803-4463-9d88-bbb2e2b26602', N'', CAST(0x00009DD100F0086B AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'd872e288-15bc-42eb-bab0-d21acad46c03', N'<p>dsgdfgdfg</p>', CAST(0x00009DD200FA15EE AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'd57387f0-5702-4c45-aaf4-dafb25f82125', N'', CAST(0x00009DD10119174C AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'7bf18a23-8dac-4e9a-b2ab-dc26c85999e7', N'<p>I m very smart person who can make anything on web</p>', CAST(0x00009DD200DBFFA7 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'f51ba36f-c9f4-44d1-9f4b-dd61757f423c', N'<p>dsfsfdsf sdf dsf dsa fsdafsdf asfs</p>', CAST(0x00009DD1013A894F AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'5b1eae5e-e6fe-49f1-9f0b-ddd596119199', N'<p>Right</p>', CAST(0x00009DD100F08F39 AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'3357eeac-fecb-4ee7-8c85-ddee51cf9940', N'<p>Rohan 1</p>', CAST(0x00009DD100DFE33C AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'85c5023c-beca-4676-9407-e0a90204ad0f', N'<p>dsxfdsf gfsa gdasfgdfg</p>', CAST(0x00009DD200DC135B AS DateTime))
INSERT [dbo].[HTMLWidget] ([HTMLWidgetID], [HTMLDATA], [ModifiedDate]) VALUES (N'52c63a9c-ab75-4761-a9d8-fa62f61815bf', N'<p>Rohan 2</p>', CAST(0x00009DD100DFEB8C AS DateTime))
/****** Object:  Table [dbo].[aspnet_SchemaVersions]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_SchemaVersions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_SchemaVersions](
	[Feature] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CompatibleSchemaVersion] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsCurrentVersion] [bit] NOT NULL,
 CONSTRAINT [PK__aspnet_SchemaVer__300424B4] PRIMARY KEY CLUSTERED 
(
	[Feature] ASC,
	[CompatibleSchemaVersion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'common', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'health monitoring', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'membership', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'personalization', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'profile', N'1', 1)
INSERT [dbo].[aspnet_SchemaVersions] ([Feature], [CompatibleSchemaVersion], [IsCurrentVersion]) VALUES (N'role manager', N'1', 1)
/****** Object:  Table [dbo].[InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteUserType](
	[InstituteUserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[InstituteID] [int] NOT NULL,
	[Name] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteUserType] PRIMARY KEY CLUSTERED 
(
	[InstituteUserTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteUserType] ON
INSERT [dbo].[InstituteUserType] ([InstituteUserTypeID], [LoginUserID], [InstituteID], [Name], [Description], [ModifiedDate]) VALUES (23, 43, 10, N'Student', N'', CAST(0x00009DCE00F877D2 AS DateTime))
INSERT [dbo].[InstituteUserType] ([InstituteUserTypeID], [LoginUserID], [InstituteID], [Name], [Description], [ModifiedDate]) VALUES (24, 43, 10, N'professor', N'', CAST(0x00009DCE00F8A646 AS DateTime))
INSERT [dbo].[InstituteUserType] ([InstituteUserTypeID], [LoginUserID], [InstituteID], [Name], [Description], [ModifiedDate]) VALUES (25, 43, 10, N' Advisor', N'', CAST(0x00009DCE00F8BB5E AS DateTime))
INSERT [dbo].[InstituteUserType] ([InstituteUserTypeID], [LoginUserID], [InstituteID], [Name], [Description], [ModifiedDate]) VALUES (26, 43, 10, N'Supervisor', N'', CAST(0x00009DD10122D5DA AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteUserType] OFF
/****** Object:  Table [dbo].[WidgetPage]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WidgetPage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[WidgetPage](
	[PageID] [uniqueidentifier] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[PageType] [int] NOT NULL,
	[ContentTypeID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Title] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Page] PRIMARY KEY CLUSTERED 
(
	[PageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[WidgetPage] ([PageID], [LoginUserID], [PageType], [ContentTypeID], [Title], [ModifiedDate]) VALUES (N'c4d60d62-6a18-4d45-a091-1a3ca31e53fa', 44, 0, N'44', N'new Page', CAST(0x00009DD10129E34A AS DateTime))
INSERT [dbo].[WidgetPage] ([PageID], [LoginUserID], [PageType], [ContentTypeID], [Title], [ModifiedDate]) VALUES (N'9a804b38-223f-4d26-a21e-9046e938aef3', 43, 0, N'43', N'new Page', CAST(0x00009DD00179A2D1 AS DateTime))
/****** Object:  Table [dbo].[SystemConfiguration]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemConfiguration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SystemConfiguration](
	[SystemConfigurationID] [uniqueidentifier] NOT NULL,
	[InstituteID] [int] NOT NULL,
	[SpaceLabel] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[InnerSpaceLabel] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Configuration] PRIMARY KEY CLUSTERED 
(
	[SystemConfigurationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[TutorialType]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TutorialType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TutorialType](
	[TutorialTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TutorialType] PRIMARY KEY CLUSTERED 
(
	[TutorialTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[CourceCatagory]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourceCatagory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourceCatagory](
	[CourceCatagoryID] [int] IDENTITY(1,1) NOT NULL,
	[CatagoryName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CatagoryType] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CourceCatagory] PRIMARY KEY CLUSTERED 
(
	[CourceCatagoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[CourceCatagory] ON
INSERT [dbo].[CourceCatagory] ([CourceCatagoryID], [CatagoryName], [LoginUserID], [Description], [CatagoryType], [ModifiedDate]) VALUES (48, N'IT', 43, N'', 1, CAST(0x00009DCE00F64B9E AS DateTime))
INSERT [dbo].[CourceCatagory] ([CourceCatagoryID], [CatagoryName], [LoginUserID], [Description], [CatagoryType], [ModifiedDate]) VALUES (49, N'Management', 43, N'', 1, CAST(0x00009DCE00F6589A AS DateTime))
SET IDENTITY_INSERT [dbo].[CourceCatagory] OFF
/****** Object:  Table [dbo].[College]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[College]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[College](
	[CollegeID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CityName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StateName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CountryName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UniverSityID] [uniqueidentifier] NULL,
	[TelePhone] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fax] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WebSite] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CollegeType] [int] NULL,
	[ShortName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Collages] PRIMARY KEY CLUSTERED 
(
	[CollegeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[AnswerState]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnswerState]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AnswerState](
	[AnswerStateID] [int] IDENTITY(1,1) NOT NULL,
	[AnswerStateText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_AnswerState] PRIMARY KEY CLUSTERED 
(
	[AnswerStateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[QuestionStatus]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionStatus]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[QuestionStatus](
	[QuestionStatusID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionStatusText] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_QuestionStatus] PRIMARY KEY CLUSTERED 
(
	[QuestionStatusID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[QuestionType]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[QuestionType](
	[QuestionTypeID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionTypeTnext] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_QuestionType] PRIMARY KEY CLUSTERED 
(
	[QuestionTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[QuestionType] ON
INSERT [dbo].[QuestionType] ([QuestionTypeID], [QuestionTypeTnext], [LoginUserID], [ModifiedDate]) VALUES (18, N'general', 43, CAST(0x00009DCE00F86D17 AS DateTime))
SET IDENTITY_INSERT [dbo].[QuestionType] OFF
/****** Object:  Table [dbo].[Share]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Share]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Share](
	[ShareID] [uniqueidentifier] NOT NULL,
	[ObjectType] [int] NOT NULL,
	[ObjectID] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EnableAllUseView] [bit] NULL,
	[EnableAllUserEdit] [bit] NULL,
	[EnableAllUserComment] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Share] PRIMARY KEY CLUSTERED 
(
	[ShareID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Share] ([ShareID], [ObjectType], [ObjectID], [EnableAllUseView], [EnableAllUserEdit], [EnableAllUserComment], [ModifiedDate]) VALUES (N'feb71c4b-8421-4954-8fdd-1cec6a63c8cb', 1, N'2f80c85b-f328-4475-a921-32c47e26da8c', NULL, NULL, NULL, CAST(0x00009DD000BA6FE3 AS DateTime))
INSERT [dbo].[Share] ([ShareID], [ObjectType], [ObjectID], [EnableAllUseView], [EnableAllUserEdit], [EnableAllUserComment], [ModifiedDate]) VALUES (N'37766f80-181f-4964-9741-80ff5c34c668', 3, N'3f96cf0a-494c-48b9-9725-dc3160960d70', 1, 0, 1, CAST(0x00009DD1012297BE AS DateTime))
/****** Object:  Table [dbo].[Cource]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cource]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Cource](
	[CourceID] [int] IDENTITY(1,1) NOT NULL,
	[CourceCatagoryID] [int] NOT NULL,
	[CourceName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CourceType] [int] NOT NULL,
	[Modifieddate] [datetime] NOT NULL,
 CONSTRAINT [PK_Cource] PRIMARY KEY CLUSTERED 
(
	[CourceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Cource] ON
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (32, 48, N'Master in Computer science', N'Master in Computer science', 2, CAST(0x00009DCE00F678D8 AS DateTime))
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (33, 48, N'MCS: Master of Computer Science', N'MCS: Master of Computer Science', 2, CAST(0x00009DCE00F6DFB2 AS DateTime))
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (34, 48, N'MSCS: Master of Science in Computer Science ', N'MSCS: Master of Science in Computer Science ', 2, CAST(0x00009DCE00F6F811 AS DateTime))
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (35, 48, N'MSSE: Master of Science in Software Engineering ', N'MSSE: Master of Science in Software Engineering ', 2, CAST(0x00009DCE00F70793 AS DateTime))
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (36, 48, N'MAICS: Master of Arts in Interdisciplinary Computer Science ', N'MAICS: Master of Arts in Interdisciplinary Computer Science ', 2, CAST(0x00009DCE00F71A41 AS DateTime))
INSERT [dbo].[Cource] ([CourceID], [CourceCatagoryID], [CourceName], [Description], [CourceType], [Modifieddate]) VALUES (37, 48, N'MACS: Master of Arts in Computer Science ', N'MACS: Master of Arts in Computer Science ', 2, CAST(0x00009DCE00F72C11 AS DateTime))
SET IDENTITY_INSERT [dbo].[Cource] OFF
/****** Object:  Table [dbo].[aspnet_Users]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Users](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoweredUserName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MobileAlias] [nvarchar](16) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsAnonymous] [bit] NOT NULL,
	[LastActivityDate] [datetime] NOT NULL,
 CONSTRAINT [PK__aspnet_Users__2A4B4B5E] PRIMARY KEY NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users]') AND name = N'aspnet_Users_Index')
CREATE UNIQUE CLUSTERED INDEX [aspnet_Users_Index] ON [dbo].[aspnet_Users] 
(
	[ApplicationId] ASC,
	[LoweredUserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users]') AND name = N'aspnet_Users_Index2')
CREATE NONCLUSTERED INDEX [aspnet_Users_Index2] ON [dbo].[aspnet_Users] 
(
	[ApplicationId] ASC,
	[LastActivityDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'be124142-48c4-4a35-b6b6-d01f095750ec', N'christ', N'christ', NULL, 0, CAST(0x00009DD200C288C9 AS DateTime))
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'2be3699d-3686-44bd-a2b2-e708ffd90eb2', N'jill', N'jill', NULL, 0, CAST(0x00009DD200A0AA78 AS DateTime))
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'aac3f49e-bd26-4dd2-806c-5f73b7b06e20', N'leena', N'leena', NULL, 0, CAST(0x00009DD0007EE274 AS DateTime))
INSERT [dbo].[aspnet_Users] ([ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'041187b8-e6db-40b0-8aa5-296d0dd69675', N'michael', N'michael', NULL, 0, CAST(0x00009DCE00A7770D AS DateTime))
/****** Object:  Table [dbo].[LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoginUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoginUser](
	[LoginUserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Password] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[UserType] [int] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LoginUser] PRIMARY KEY CLUSTERED 
(
	[LoginUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[LoginUser] ON
INSERT [dbo].[LoginUser] ([LoginUserID], [Username], [Password], [UserType], [UserId], [ModifiedDate], [CreatedDate]) VALUES (43, N'christ', N'michael', 2, N'be124142-48c4-4a35-b6b6-d01f095750ec', CAST(0x00009DCE00F623FE AS DateTime), CAST(0x00009DCE00F623FE AS DateTime))
INSERT [dbo].[LoginUser] ([LoginUserID], [Username], [Password], [UserType], [UserId], [ModifiedDate], [CreatedDate]) VALUES (44, N'jill', N'michael', 1, N'2be3699d-3686-44bd-a2b2-e708ffd90eb2', CAST(0x00009DCE010033FA AS DateTime), CAST(0x00009DCE010033FA AS DateTime))
INSERT [dbo].[LoginUser] ([LoginUserID], [Username], [Password], [UserType], [UserId], [ModifiedDate], [CreatedDate]) VALUES (45, N'michael', N'michael', 1, N'041187b8-e6db-40b0-8aa5-296d0dd69675', CAST(0x00009DCE010169D4 AS DateTime), CAST(0x00009DCE010169D4 AS DateTime))
INSERT [dbo].[LoginUser] ([LoginUserID], [Username], [Password], [UserType], [UserId], [ModifiedDate], [CreatedDate]) VALUES (46, N'leena', N'michael', 1, N'aac3f49e-bd26-4dd2-806c-5f73b7b06e20', CAST(0x00009DCE0101DC1F AS DateTime), CAST(0x00009DCE0101DC1F AS DateTime))
SET IDENTITY_INSERT [dbo].[LoginUser] OFF
/****** Object:  Table [dbo].[Institute]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Institute]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Institute](
	[InstituteID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[Name] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Address] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CityName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StateName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CountryName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TelePhone] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fax] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WebSite] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CollegeType] [int] NULL,
	[ShortName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Logo] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Institute] PRIMARY KEY CLUSTERED 
(
	[InstituteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Institute] ON
INSERT [dbo].[Institute] ([InstituteID], [LoginUserID], [Name], [Address], [CityName], [StateName], [CountryName], [TelePhone], [Fax], [Email], [WebSite], [CollegeType], [ShortName], [Description], [Logo], [ModifiedDate], [IsDeleted]) VALUES (10, 43, N'Christ University', N'Christ University, Hosur Road,', N'Bangalore', N'Karnataka', N'India', N'8040129100', N'+91.80.40129000', N'mail@christuniversity.in', N'www.christuniversity.in', 1, N'Christ University', N'<p>Economics is the social science concerned with the production, distribution, and consumption of goods and service. Economic analysis is applied throughout society, in business, finance and government, but also in crime, education, the family, health, law, politics, religion, social institutions, war, and science.</p>
<p>&nbsp;</p>
<p>Economics is the social science concerned with the production,  distribution, and consumption of goods and service. Economic analysis is  applied throughout society, in business, finance and government, but  also in crime, education, the family, health, law, politics, religion,  social institutions, war, and science.</p>
<p>&nbsp;</p>
<p>Economics is the social science concerned with the production,  distribution, and consumption of goods and service. Economic analysis is  applied throughout society, in business, finance and government, but  also in crime, education, the family, health, law, politics, religion,  social institutions, war, and science.</p>
<p>&nbsp;</p>
<p>Economics is the social science concerned with the production,  distribution, and consumption of goods and service. Economic analysis is  applied throughout society, in business, finance and government, but  also in crime, education, the family, health, law, politics, religion,  social institutions, war, and science.</p>', N'~/Repository/Image/christ/7.jpg', CAST(0x00009DD000EDCCA7 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Institute] OFF
/****** Object:  Table [dbo].[InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteCource]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteCource](
	[InstituteCourceID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteID] [int] NOT NULL,
	[CourceID] [int] NOT NULL,
	[MetaDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MetaKeyword] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[IsPublished] [bit] NULL,
	[HomeWorkEnable] [bit] NULL,
	[AttendanceEnable] [bit] NULL,
	[QuestionAnswerEnable] [bit] NULL,
	[SelfRegistrationEnable] [bit] NULL,
	[IsFree] [bit] NULL,
	[Price] [decimal](18, 0) NULL,
	[Modifieddate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteCource] PRIMARY KEY CLUSTERED 
(
	[InstituteCourceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteCource] ON
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (21, 10, 32, N'<p><strong>Computer Science Master Degree</strong>: In the Computer Professionals  Program, you start with full-time study in the M.S. in Computer Science  (MSCS) program, and then work for approximately two years at a US  technology company in full-paying practical training employment. Your  practical training position in the computer science field is practicum,  and you will receive academic credit for it.</p>
<p><strong>Computer Science Master Degree</strong>: In the Computer Professionals  Program, you start with full-time study in the M.S. in Computer Science  (MSCS) program, and then work for approximately two years at a US  technology company in full-paying practical training employment. Your  practical training position in the computer science field is practicum,  and you will receive academic credit for it.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F6C656 AS DateTime))
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (22, 10, 33, N'<p>Fully 8 out of 10 working computer programmers have at least an  associate''s degree, but only 2 out of 10 have more than a bachelor''s  degree. A master''s degree in computer programming puts you in an elite  group.</p>
<p>A master''s degree in computer programming signifies that,  while you can write computer code well on your own, you are also ready  to create and supervise large-scale projects because you possess an  overall understanding of information architecture. Often, this degree  can be achieved while you are working a regular job, thanks to the  flexibility of today''s online university.</p>
<p>The curriculum typical  of a master''s degree in Computer programming is naturally more geared  towards advanced knowledge, building upon what you learned while earning  your bachelor''s degree. Senior computer programmers routinely make over  $100,000 per year and are fluent in several major programming  languages. They also are frequently sought after to be involved in  entrepreneurial ventures such as tech start-ups.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F79323 AS DateTime))
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (23, 10, 35, N'<p>Fully 8 out of 10 working computer programmers have at least an  associate''s degree, but only 2 out of 10 have more than a bachelor''s  degree. A master''s degree in computer programming puts you in an elite  group.</p>
<p>A master''s degree in computer programming signifies that,  while you can write computer code well on your own, you are also ready  to create and supervise large-scale projects because you possess an  overall understanding of information architecture. Often, this degree  can be achieved while you are working a regular job, thanks to the  flexibility of today''s online university.</p>
<p>The curriculum typical  of a master''s degree in Computer programming is naturally more geared  towards advanced knowledge, building upon what you learned while earning  your bachelor''s degree. Senior computer programmers routinely make over  $100,000 per year and are fluent in several major programming  languages. They also are frequently sought after to be involved in  entrepreneurial ventures such as tech start-ups.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F7A840 AS DateTime))
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (24, 10, 37, N'<p>Fully 8 out of 10 working computer programmers have at least an  associate''s degree, but only 2 out of 10 have more than a bachelor''s  degree. A master''s degree in computer programming puts you in an elite  group.</p>
<p>A master''s degree in computer programming signifies that,  while you can write computer code well on your own, you are also ready  to create and supervise large-scale projects because you possess an  overall understanding of information architecture. Often, this degree  can be achieved while you are working a regular job, thanks to the  flexibility of today''s online university.</p>
<p>The curriculum typical  of a master''s degree in Computer programming is naturally more geared  towards advanced knowledge, building upon what you learned while earning  your bachelor''s degree. Senior computer programmers routinely make over  $100,000 per year and are fluent in several major programming  languages. They also are frequently sought after to be involved in  entrepreneurial ventures such as tech start-ups.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F7BA57 AS DateTime))
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (25, 10, 34, N'<p>Fully 8 out of 10 working computer programmers have at least an  associate''s degree, but only 2 out of 10 have more than a bachelor''s  degree. A master''s degree in computer programming puts you in an elite  group.</p>
<p>A master''s degree in computer programming signifies that,  while you can write computer code well on your own, you are also ready  to create and supervise large-scale projects because you possess an  overall understanding of information architecture. Often, this degree  can be achieved while you are working a regular job, thanks to the  flexibility of today''s online university.</p>
<p>The curriculum typical  of a master''s degree in Computer programming is naturally more geared  towards advanced knowledge, building upon what you learned while earning  your bachelor''s degree. Senior computer programmers routinely make over  $100,000 per year and are fluent in several major programming  languages. They also are frequently sought after to be involved in  entrepreneurial ventures such as tech start-ups.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F7CC11 AS DateTime))
INSERT [dbo].[InstituteCource] ([InstituteCourceID], [InstituteID], [CourceID], [MetaDescription], [MetaKeyword], [StartDate], [EndDate], [IsPublished], [HomeWorkEnable], [AttendanceEnable], [QuestionAnswerEnable], [SelfRegistrationEnable], [IsFree], [Price], [Modifieddate]) VALUES (26, 10, 36, N'<p>Fully 8 out of 10 working computer programmers have at least an  associate''s degree, but only 2 out of 10 have more than a bachelor''s  degree. A master''s degree in computer programming puts you in an elite  group.</p>
<p>A master''s degree in computer programming signifies that,  while you can write computer code well on your own, you are also ready  to create and supervise large-scale projects because you possess an  overall understanding of information architecture. Often, this degree  can be achieved while you are working a regular job, thanks to the  flexibility of today''s online university.</p>
<p>The curriculum typical  of a master''s degree in Computer programming is naturally more geared  towards advanced knowledge, building upon what you learned while earning  your bachelor''s degree. Senior computer programmers routinely make over  $100,000 per year and are fluent in several major programming  languages. They also are frequently sought after to be involved in  entrepreneurial ventures such as tech start-ups.</p>', N'', CAST(0x00009DCE00000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime), 1, 1, 1, 1, 1, 1, CAST(0 AS Decimal(18, 0)), CAST(0x00009DCE00F7DE40 AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteCource] OFF
/****** Object:  Table [dbo].[InstituteSubject]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteSubject]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteSubject](
	[InstituteSubjectID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[SubjectText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[InstituteCourceID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteSubject] PRIMARY KEY CLUSTERED 
(
	[InstituteSubjectID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteSubject] ON
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (9, 43, N'Software developement Life Cycle', N'', 21, CAST(0x00009DCE00F80723 AS DateTime))
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (10, 43, N'Software developement Life Cycle', N'', 22, CAST(0x00009DCE00F812AC AS DateTime))
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (11, 43, N'Software developement Life Cycle', N'', 23, CAST(0x00009DCE00F819C2 AS DateTime))
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (12, 43, N'Software developement Life Cycle', N'', 24, CAST(0x00009DCE00F82018 AS DateTime))
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (13, 43, N'Software developement Life Cycle', N'', 25, CAST(0x00009DCE00F827A8 AS DateTime))
INSERT [dbo].[InstituteSubject] ([InstituteSubjectID], [LoginUserID], [SubjectText], [Description], [InstituteCourceID], [ModifiedDate]) VALUES (14, 43, N'Software developement Life Cycle', N'', 26, CAST(0x00009DCE00F82DA9 AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteSubject] OFF
/****** Object:  Table [dbo].[InstituteCourceUser]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteCourceUser](
	[InstituteCourceUserID] [uniqueidentifier] NOT NULL,
	[InstituteCourceID] [int] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[WhoLoginUserID] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[Modifieddate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteCourceUser] PRIMARY KEY CLUSTERED 
(
	[InstituteCourceUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'90c328f3-e9fb-4d9c-b096-03209f0ed8f3', 22, 45, 43, 1, CAST(0x00009DCE0101AD1A AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'2a32f092-a398-4288-9185-20ebee841317', 24, 45, 43, 1, CAST(0x00009DCE0101B46D AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'449ac0ce-0073-44f4-8ab2-2bf308a5c2c9', 21, 44, 44, 1, CAST(0x00009DCE01003408 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'5c9b17a8-534a-4883-9574-34f8cca300f2', 24, 46, 43, 1, CAST(0x00009DCE0101EAA4 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'abbda983-fecb-4042-9371-4a4dc573d576', 21, 43, 43, 1, CAST(0x00009DCE00F8378C AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'2038b8da-5e76-469f-866c-5224c9ad0f75', 23, 45, 43, 1, CAST(0x00009DCE0101B06F AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'0833abf9-e9d8-4c6c-b24c-7494bb51e880', 21, 45, 43, 1, CAST(0x00009DCE0101AA10 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'f03ab799-77c1-49b2-809f-80066d9600af', 26, 43, 43, 1, CAST(0x00009DCE00F84815 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'9f4faf9a-cb0d-45ce-a9e7-801966b894f9', 25, 43, 43, 1, CAST(0x00009DCE00F84EBB AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'cbb47445-9fbe-44f8-a07d-edae11c9f9d8', 22, 43, 43, 1, CAST(0x00009DCE00F83AB3 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'4d378031-4b5f-4da6-adb6-f2c42ce5e1c5', 23, 43, 43, 1, CAST(0x00009DCE00F83E61 AS DateTime))
INSERT [dbo].[InstituteCourceUser] ([InstituteCourceUserID], [InstituteCourceID], [LoginUserID], [WhoLoginUserID], [Type], [Modifieddate]) VALUES (N'94ef87f1-4cb9-4857-8a8e-f600e4355b75', 24, 43, 43, 1, CAST(0x00009DCE00F84332 AS DateTime))
/****** Object:  Table [dbo].[Instructor]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Instructor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Instructor](
	[InstructorID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteID] [int] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[InstituteCourceID] [int] NOT NULL,
	[InstructorText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Ratting] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[InstructorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Payment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Payment](
	[PaymentID] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NOT NULL,
	[PaymentStatus] [int] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[PaymentCurrency] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PaymentType] [int] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[ExpireDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderItem](
	[OrderItemID] [uniqueidentifier] NOT NULL,
	[OrderID] [uniqueidentifier] NOT NULL,
	[ItemName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ItemDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Question]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Question](
	[QuestionID] [uniqueidentifier] NOT NULL,
	[QuestionText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoginUserID] [int] NOT NULL,
	[EditLoginUserID] [int] NULL,
	[InstituteCourceID] [int] NOT NULL,
	[InstituteSubjectID] [int] NULL,
	[tag] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[QuestionTypeID] [int] NOT NULL,
	[QuestionStatusID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Question] ([QuestionID], [QuestionText], [Description], [LoginUserID], [EditLoginUserID], [InstituteCourceID], [InstituteSubjectID], [tag], [QuestionTypeID], [QuestionStatusID], [ModifiedDate]) VALUES (N'2f80c85b-f328-4475-a921-32c47e26da8c', N'Online master computer science?', N'information on online master computer science. i want to do masters in computer science information on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer scienceinformation on online master computer science. i want to do masters in computer science', 43, 43, 21, 9, N'', 18, 0, CAST(0x00009DD000BAABE4 AS DateTime))
/****** Object:  Table [dbo].[Answer]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Answer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Answer](
	[AnswerID] [uniqueidentifier] NOT NULL,
	[AnswerText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[QuestionID] [uniqueidentifier] NOT NULL,
	[AnswerStateID] [int] NULL,
	[LoginUserID] [int] NOT NULL,
	[AnswerRate] [int] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[AnswerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Answer] ([AnswerID], [AnswerText], [Description], [QuestionID], [AnswerStateID], [LoginUserID], [AnswerRate], [ModifiedDate]) VALUES (N'2a1cb181-9d8e-492c-b60e-6ed8ddba01cc', N'The computer science field is focused on', N'The computer science field is focused on professionals conceiving, creating, and maintaining computer technologies. This overall description of the field can be applied in numerous ways to complete a considerable amount of work. Careers in this field can have individuals working as systems analysts, database administrators, computer scientists, and more. if you want to do masters in computer science
than i recommend you to visit this site it has all the info in detail ', N'2f80c85b-f328-4475-a921-32c47e26da8c', 0, 43, 0, CAST(0x00009DD000BA8368 AS DateTime))
/****** Object:  Table [dbo].[Exam]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Exam](
	[ExamID] [int] IDENTITY(1,1) NOT NULL,
	[ExamName] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SubjectName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[InstituteCourceID] [int] NULL,
	[InstituteSubjectID] [int] NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoginUserID] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ExamTime] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsActive] [bit] NULL,
	[RequirePecentage] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[ExamID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Exam] ON
INSERT [dbo].[Exam] ([ExamID], [ExamName], [SubjectName], [InstituteCourceID], [InstituteSubjectID], [Description], [LoginUserID], [ModifiedDate], [ExamTime], [IsActive], [RequirePecentage], [StartDate], [EndDate]) VALUES (21, N'Software Development Life Cycle', N'Software Development Life Cycle', 21, 9, N'A software development process is a structure imposed on the development of a software product. Similar terms include software life cycle and software process. There are several models for such processes, each describing approaches to a variety of tasks or activities  that take place during the process. Some people consider a lifecycle model a more general term and a software development process a more specific term. For example, there are many specific software development processes that ''fit'' the spiral lifecycle model.', 43, CAST(0x00009DD000EBEDD5 AS DateTime), N'10', 1, 50, CAST(0x00009DD000000000 AS DateTime), CAST(0x00009DE300000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Exam] OFF
/****** Object:  Table [dbo].[UserExam]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExam]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserExam](
	[UserExamID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ExamID] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[IsFinish] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_UserExam] PRIMARY KEY CLUSTERED 
(
	[UserExamID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[UserExam] ON
INSERT [dbo].[UserExam] ([UserExamID], [LoginUserID], [ExamID], [StartTime], [EndDate], [IsFinish], [ModifiedDate]) VALUES (378, 43, 21, CAST(0x00009DD2011D3215 AS DateTime), CAST(0x00009DD2011D3C64 AS DateTime), 1, CAST(0x00009DD2011D3C64 AS DateTime))
SET IDENTITY_INSERT [dbo].[UserExam] OFF
/****** Object:  Table [dbo].[Comment]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Comment](
	[CommentID] [uniqueidentifier] NOT NULL,
	[ContentID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ContentType] [int] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[CommentText] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'740515bf-3efa-4f5f-9d9e-0a992cd5616a', N'8', 6, 46, N'Hi,
I am learning C from book by Yashwant Kanetkar Let Us C. In that I am in chapter 9th Puppeting on screen where i was doing function strcat which was explained in book and in end its said by author that I leave it up to you for writing a function xstrcat to concenate two string. I am trying to solve it but i am not able to can you please help me with that? ', CAST(0x00009DD000C1BCC1 AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'3f23a3db-c88c-40fc-8ccb-6e96b4550ce1', N'6be2271e-b733-4524-82b6-e740293c73b4', 3, 43, N'how about JTYJN''s kahin toh? So what if she isn''t ur girlfriend....this song definetely rocks if you want a slow song....Even pehla nasha is really nice! And dil chata hai''s jaane kyun log pyar karte hain-remember? And yes! tu hi mera dost hai!!! Yuuvraaj''s this number is realllly the best!', CAST(0x00009DD000D9634D AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'9d8bbd96-af76-4b41-9be9-827dc4b4d941', N'3e206b7a-2f21-4b00-ab79-fc4cc17dc60f', 8, 44, N'Nice Article Sir', CAST(0x00009DD000C3F0E7 AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'6432b1d8-0e8f-4bc1-bf88-bb6f29b03576', N'8', 6, 44, N'i want to get triangular form of output.. for example if my input is world.. the output should be
w
wo
wor
worl
world
using single dimension array.. pls help me... ', CAST(0x00009DD000BFC024 AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'3e068b42-c11c-4bd0-b981-d1bb16fa1478', N'8', 6, 43, N'hey man i am stuck with one of my project in which i have to write a program in c can u please help i will send u the specifications of my project once i get a response from you ', CAST(0x00009DD000BF954B AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'91f929f6-23ac-4f50-9d95-d474af6649ac', N'6be2271e-b733-4524-82b6-e740293c73b4', 3, 46, N'how about JTYJN''s kahin toh? So what if she isn''t ur girlfriend....this song definetely rocks if you want a slow song....Even pehla nasha is really nice! And dil chata hai''s jaane kyun log pyar karte hain-remember? And yes! tu hi mera dost hai!!! Yuuvraaj''s this number is realllly the best!', CAST(0x00009DD000D98F93 AS DateTime))
INSERT [dbo].[Comment] ([CommentID], [ContentID], [ContentType], [LoginUserID], [CommentText], [ModifiedDate]) VALUES (N'b6aa0e24-02f1-4ebb-bc7f-f7de00ed8dd1', N'6be2271e-b733-4524-82b6-e740293c73b4', 3, 44, N'how about JTYJN''s kahin toh? So what if she isn''t ur girlfriend....this song definetely rocks if you want a slow song....Even pehla nasha is really nice! And dil chata hai''s jaane kyun log pyar karte hain-remember? And yes! tu hi mera dost hai!!! Yuuvraaj''s this number is realllly the best!', CAST(0x00009DD000D97470 AS DateTime))
/****** Object:  Table [dbo].[Message]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Message]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Message](
	[MessageID] [uniqueidentifier] NOT NULL,
	[Subject] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MessageText] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ToLoginUserID] [int] NOT NULL,
	[FromLoginUserID] [int] NOT NULL,
	[ReplyID] [int] NULL,
	[ReadTime] [datetime] NULL,
	[IsReaded] [bit] NULL,
	[DeleteFromTo] [bit] NULL,
	[DeleteFromFrom] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[UserEducation]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserEducation]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserEducation](
	[UserEducationID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[InstituteID] [int] NULL,
	[InstitueName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SubjectName] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Year] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_UserEducation] PRIMARY KEY CLUSTERED 
(
	[UserEducationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[ShareUser]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShareUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ShareUser](
	[ShareUserID] [uniqueidentifier] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ShareID] [uniqueidentifier] NOT NULL,
	[EnableEdit] [bit] NULL,
	[EnableAdd] [bit] NULL,
	[EnableView] [bit] NULL,
	[EnableDelete] [bit] NULL,
	[EnableEditByLoggedIn] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ShareUser] PRIMARY KEY CLUSTERED 
(
	[ShareUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ShareUser] ([ShareUserID], [LoginUserID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'0428c7f7-b113-43e2-81bd-03c3bc8d4fa1', 46, N'37766f80-181f-4964-9741-80ff5c34c668', 0, 0, 0, 0, 0, CAST(0x00009DD1012297DA AS DateTime))
INSERT [dbo].[ShareUser] ([ShareUserID], [LoginUserID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'c399df59-2c5b-438e-a100-39589cd1fc50', 43, N'37766f80-181f-4964-9741-80ff5c34c668', 0, 0, 0, 0, 0, CAST(0x00009DD1012297CC AS DateTime))
INSERT [dbo].[ShareUser] ([ShareUserID], [LoginUserID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'27f17452-3dd6-427a-a942-735095f74266', 45, N'37766f80-181f-4964-9741-80ff5c34c668', 0, 0, 0, 0, 0, CAST(0x00009DD1012297D5 AS DateTime))
INSERT [dbo].[ShareUser] ([ShareUserID], [LoginUserID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'1693ad0d-330a-437d-8604-8c8ff4ff89c0', 43, N'feb71c4b-8421-4954-8fdd-1cec6a63c8cb', 0, 0, 0, 0, 0, CAST(0x00009DD000BA6FE8 AS DateTime))
INSERT [dbo].[ShareUser] ([ShareUserID], [LoginUserID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'7f41cf35-3b1a-46e2-be11-b432cfd4e47c', 44, N'37766f80-181f-4964-9741-80ff5c34c668', 1, 0, 1, 0, 0, CAST(0x00009DD1012297D1 AS DateTime))
/****** Object:  Table [dbo].[Article]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Article]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Article](
	[ArticleID] [uniqueidentifier] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[EditLoginUserID] [int] NULL,
	[Title] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MetaDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[InstituteCourceID] [int] NOT NULL,
	[InstituteSubjectID] [int] NOT NULL,
	[Tag] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Rating] [int] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Article] ([ArticleID], [LoginUserID], [EditLoginUserID], [Title], [Description], [MetaDescription], [InstituteCourceID], [InstituteSubjectID], [Tag], [Rating], [ModifiedDate]) VALUES (N'3e206b7a-2f21-4b00-ab79-fc4cc17dc60f', 43, 43, N'Know About C++ Born', N'<p><strong>C++</strong> (pronounced <span class="IPA" title="English pronunciation respelling"><a title="Wikipedia:Pronunciation respelling key" href="http://en.wikipedia.org/wiki/Wikipedia:Pronunciation_respelling_key"><em>see plus plus</em></a></span>) is a <a title="Type system" href="http://en.wikipedia.org/wiki/Type_system#Static_typing">statically typed</a>, <a title="Free-form language" href="http://en.wikipedia.org/wiki/Free-form_language">free-form</a>, <a class="mw-redirect" title="Multi-paradigm programming language" href="http://en.wikipedia.org/wiki/Multi-paradigm_programming_language">multi-paradigm</a>, <a title="Compiled language" href="http://en.wikipedia.org/wiki/Compiled_language">compiled</a>, general-purpose <a title="Programming language" href="http://en.wikipedia.org/wiki/Programming_language">programming language</a>. It is regarded as a "middle-level" language, as it comprises a combination of both <a title="High-level programming language" href="http://en.wikipedia.org/wiki/High-level_programming_language">high-level</a> and <a title="Low-level programming language" href="http://en.wikipedia.org/wiki/Low-level_programming_language">low-level</a> language features.<sup id="cite_ref-1" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-1"><span>[</span>2<span>]</span></a></sup> It was developed by <a title="Bjarne Stroustrup" href="http://en.wikipedia.org/wiki/Bjarne_Stroustrup">Bjarne Stroustrup</a> starting in 1979 at <a title="Bell Labs" href="http://en.wikipedia.org/wiki/Bell_Labs">Bell Labs</a> as an enhancement to the <a title="C (programming language)" href="http://en.wikipedia.org/wiki/C_%28programming_language%29">C programming language</a> and originally named <em>C with Classes</em>. It was renamed <em>C++</em> in 1983.<sup id="cite_ref-2" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-2"><span>[</span>3<span>]</span></a></sup></p>
<p>As one of the most popular programming languages ever created,<sup id="cite_ref-3" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-3"><span>[</span>4<span>]</span></a></sup><sup id="cite_ref-4" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-4"><span>[</span>5<span>]</span></a></sup> C++ is widely used in the software industry. Some of its application  domains include systems software, application software, device drivers,  embedded software, high-performance server and client applications, and  entertainment software such as <a class="mw-redirect" title="Video games" href="http://en.wikipedia.org/wiki/Video_games">video games</a>. Several groups provide both free and proprietary C++ <a title="Compiler" href="http://en.wikipedia.org/wiki/Compiler">compiler</a> software, including the <a title="GNU Compiler Collection" href="http://en.wikipedia.org/wiki/GNU_Compiler_Collection">GNU Project</a>, <a class="mw-redirect" title="Microsoft Visual C++" href="http://en.wikipedia.org/wiki/Microsoft_Visual_C%2B%2B">Microsoft</a>, <a title="Intel C++ Compiler" href="http://en.wikipedia.org/wiki/Intel_C%2B%2B_Compiler">Intel</a> and <a class="mw-redirect" title="Borland C++ Builder" href="http://en.wikipedia.org/wiki/Borland_C%2B%2B_Builder">Borland</a>. C++ has greatly influenced many other popular programming languages, most notably <a title="Java (programming language)" href="http://en.wikipedia.org/wiki/Java_%28programming_language%29">Java</a>.</p>
<p>C++ is also used for <a class="mw-redirect" title="Hardware design" href="http://en.wikipedia.org/wiki/Hardware_design">hardware design</a>, where design is initially described in C++, then analyzed, architecturally constrained, and scheduled to create a <a title="Register transfer level" href="http://en.wikipedia.org/wiki/Register_transfer_level">register transfer level</a> <a title="Hardware description language" href="http://en.wikipedia.org/wiki/Hardware_description_language">hardware description language</a> via <a title="High-level synthesis" href="http://en.wikipedia.org/wiki/High-level_synthesis">high-level synthesis</a>.<sup class="Template-Fact" style="white-space: nowrap;" title="This claim needs references to reliable sources from June 2010">[<em><a title="Wikipedia:Citation needed" href="http://en.wikipedia.org/wiki/Wikipedia:Citation_needed">citation needed</a></em>]</sup></p>
<p>The language began as enhancements to <a title="C (programming language)" href="http://en.wikipedia.org/wiki/C_%28programming_language%29">C</a>, first adding <a title="Class (computer science)" href="http://en.wikipedia.org/wiki/Class_%28computer_science%29">classes</a>, then <a class="mw-redirect" title="Virtual functions" href="http://en.wikipedia.org/wiki/Virtual_functions">virtual functions</a>, <a title="Operator overloading" href="http://en.wikipedia.org/wiki/Operator_overloading">operator overloading</a>, <a title="Multiple inheritance" href="http://en.wikipedia.org/wiki/Multiple_inheritance">multiple inheritance</a>, <a title="Template (programming)" href="http://en.wikipedia.org/wiki/Template_%28programming%29">templates</a>, and <a title="Exception handling" href="http://en.wikipedia.org/wiki/Exception_handling">exception handling</a> among other features. After years of development, the C++ programming language standard was ratified in 1998 as <em><a class="mw-redirect" title="ISO/IEC 14882" href="http://en.wikipedia.org/wiki/ISO/IEC_14882">ISO/IEC 14882</a>:1998</em>. That standard is still current, but is amended by the 2003 technical <a class="mw-redirect" title="Errata" href="http://en.wikipedia.org/wiki/Errata">corrigendum</a>, <em>ISO/IEC 14882:2003</em>. The next standard version (known informally as <a title="C++0x" href="http://en.wikipedia.org/wiki/C%2B%2B0x">C++0x</a>) is in development.</p>
<p>&nbsp;</p>
<p><strong>C++</strong> (pronounced <span class="IPA" title="English pronunciation respelling"><a title="Wikipedia:Pronunciation respelling key" href="http://en.wikipedia.org/wiki/Wikipedia:Pronunciation_respelling_key"><em>see plus plus</em></a></span>) is a <a title="Type system" href="http://en.wikipedia.org/wiki/Type_system#Static_typing">statically typed</a>, <a title="Free-form language" href="http://en.wikipedia.org/wiki/Free-form_language">free-form</a>, <a class="mw-redirect" title="Multi-paradigm programming language" href="http://en.wikipedia.org/wiki/Multi-paradigm_programming_language">multi-paradigm</a>, <a title="Compiled language" href="http://en.wikipedia.org/wiki/Compiled_language">compiled</a>, general-purpose <a title="Programming language" href="http://en.wikipedia.org/wiki/Programming_language">programming language</a>. It is regarded as a "middle-level" language, as it comprises a combination of both <a title="High-level programming language" href="http://en.wikipedia.org/wiki/High-level_programming_language">high-level</a> and <a title="Low-level programming language" href="http://en.wikipedia.org/wiki/Low-level_programming_language">low-level</a> language features.<sup id="cite_ref-1" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-1"><span>[</span>2<span>]</span></a></sup> It was developed by <a title="Bjarne Stroustrup" href="http://en.wikipedia.org/wiki/Bjarne_Stroustrup">Bjarne Stroustrup</a> starting in 1979 at <a title="Bell Labs" href="http://en.wikipedia.org/wiki/Bell_Labs">Bell Labs</a> as an enhancement to the <a title="C (programming language)" href="http://en.wikipedia.org/wiki/C_%28programming_language%29">C programming language</a> and originally named <em>C with Classes</em>. It was renamed <em>C++</em> in 1983.<sup id="cite_ref-2" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-2"><span>[</span>3<span>]</span></a></sup></p>
<p>As one of the most popular programming languages ever created,<sup id="cite_ref-3" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-3"><span>[</span>4<span>]</span></a></sup><sup id="cite_ref-4" class="reference"><a href="http://en.wikipedia.org/wiki/C%2B%2B#cite_note-4"><span>[</span>5<span>]</span></a></sup> C++ is widely used in the software industry. Some of its application  domains include systems software, application software, device drivers,  embedded software, high-performance server and client applications, and  entertainment software such as <a class="mw-redirect" title="Video games" href="http://en.wikipedia.org/wiki/Video_games">video games</a>. Several groups provide both free and proprietary C++ <a title="Compiler" href="http://en.wikipedia.org/wiki/Compiler">compiler</a> software, including the <a title="GNU Compiler Collection" href="http://en.wikipedia.org/wiki/GNU_Compiler_Collection">GNU Project</a>, <a class="mw-redirect" title="Microsoft Visual C++" href="http://en.wikipedia.org/wiki/Microsoft_Visual_C%2B%2B">Microsoft</a>, <a title="Intel C++ Compiler" href="http://en.wikipedia.org/wiki/Intel_C%2B%2B_Compiler">Intel</a> and <a class="mw-redirect" title="Borland C++ Builder" href="http://en.wikipedia.org/wiki/Borland_C%2B%2B_Builder">Borland</a>. C++ has greatly influenced many other popular programming languages, most notably <a title="Java (programming language)" href="http://en.wikipedia.org/wiki/Java_%28programming_language%29">Java</a>.</p>
<p>C++ is also used for <a class="mw-redirect" title="Hardware design" href="http://en.wikipedia.org/wiki/Hardware_design">hardware design</a>, where design is initially described in C++, then analyzed, architecturally constrained, and scheduled to create a <a title="Register transfer level" href="http://en.wikipedia.org/wiki/Register_transfer_level">register transfer level</a> <a title="Hardware description language" href="http://en.wikipedia.org/wiki/Hardware_description_language">hardware description language</a> via <a title="High-level synthesis" href="http://en.wikipedia.org/wiki/High-level_synthesis">high-level synthesis</a>.<sup class="Template-Fact" style="white-space: nowrap;" title="This claim needs references to reliable sources from June 2010">[<em><a title="Wikipedia:Citation needed" href="http://en.wikipedia.org/wiki/Wikipedia:Citation_needed">citation needed</a></em>]</sup></p>
<p>The language began as enhancements to <a title="C (programming language)" href="http://en.wikipedia.org/wiki/C_%28programming_language%29">C</a>, first adding <a title="Class (computer science)" href="http://en.wikipedia.org/wiki/Class_%28computer_science%29">classes</a>, then <a class="mw-redirect" title="Virtual functions" href="http://en.wikipedia.org/wiki/Virtual_functions">virtual functions</a>, <a title="Operator overloading" href="http://en.wikipedia.org/wiki/Operator_overloading">operator overloading</a>, <a title="Multiple inheritance" href="http://en.wikipedia.org/wiki/Multiple_inheritance">multiple inheritance</a>, <a title="Template (programming)" href="http://en.wikipedia.org/wiki/Template_%28programming%29">templates</a>, and <a title="Exception handling" href="http://en.wikipedia.org/wiki/Exception_handling">exception handling</a> among other features. After years of development, the C++ programming language standard was ratified in 1998 as <em><a class="mw-redirect" title="ISO/IEC 14882" href="http://en.wikipedia.org/wiki/ISO/IEC_14882">ISO/IEC 14882</a>:1998</em>. That standard is still current, but is amended by the 2003 technical <a class="mw-redirect" title="Errata" href="http://en.wikipedia.org/wiki/Errata">corrigendum</a>, <em>ISO/IEC 14882:2003</em>. The next standard version (known informally as <a title="C++0x" href="http://en.wikipedia.org/wiki/C%2B%2B0x">C++0x</a>) is in development.</p>', N'C++ (pronounced see plus plus) is a statically typed, free-form, multi-paradigm, compiled, general-purpose programming language. It is regarded as a "middle-level" language, as it comprises a combination of both high-level and low-level language features.[2] It was developed by Bjarne Stroustrup starting in 1979 at Bell Labs as an enhancement to the C programming language and originally named C with Classes. It was renamed C++ in 1983.[3]

As one of the most popular programming languages ever created,[4][5] C++ is widely used in the software industry. Some of its application domains include systems software, application software, device drivers, embedded software, high-performance server and client applications, and entertainment software such as video games. Several groups provide both free and proprietary C++ compiler software, including the GNU Project, Microsoft, Intel and Borland. C++ has greatly influenced many other popular programming languages, most notably Java.

C++ is also used for hardware design, where design is initially described in C++, then analyzed, architecturally constrained, and scheduled to create a register transfer level hardware description language via high-level synthesis.[citation needed]

The language began as enhancements to C, first adding classes, then virtual functions, operator overloading, multiple inheritance, templates, and exception handling among other features. After years of development, the C++ programming language standard was ratified in 1998 as ISO/IEC 14882:1998. That standard is still current, but is amended by the 2003 technical corrigendum, ISO/IEC 14882:2003. The next standard version (known informally as C++0x) is in development.', 21, 9, N'C++', 0, CAST(0x00009DD000C2DB71 AS DateTime))
/****** Object:  Table [dbo].[Event]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Event]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Event](
	[EventID] [uniqueidentifier] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[EditLoginUserID] [int] NULL,
	[Title] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MetaDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[InstituteCourceID] [int] NULL,
	[InstituteSubjectID] [int] NULL,
	[Tag] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ContactPerson] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ContactEmail] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ContactPhone] [varchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Document]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Document]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Document](
	[DocumentID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MetaDescription] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Tag] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoginUserID] [int] NOT NULL,
	[EditLoginUserID] [int] NULL,
	[Rating] [int] NULL,
	[FilePath] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DocumentType] [int] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[DocumentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'29418d4c-c3ba-48ab-8317-2c6e89c76bb7', N's9', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'', 44, 44, 0, N'~/Repository//Image/jill/xue_xue_institute_03.jpg', 1, CAST(0x00009DD000CB697E AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'4d2f8ae5-3741-426d-9c6e-349d84224e1f', N'Sport1', N'Physical events such as scoring goals or crossing a line first often define the result of a sport. However, the degree of skill in some sports such as diving, dressage and figure skating is judged according to well-defined criteria. This is in contrast with other judged activities such as beauty pageants and body-building shows, where skill does not have to be shown and the criteria are not as well defined.
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Physical events such as scoring goals or crossing a line first often define the result of a sport. However, the degree of skill in some sports such as diving, dressage and figure skating is judged according to well-defined criteria. This is in contrast with other judged ', N'sports,group', 44, 44, 0, N'~/Repository//Image/jill/2003.Summer.Institute.jpg', 1, CAST(0x00009DD000C9AB28 AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'2f782a98-1fcd-43cc-bf76-466c4a01ce90', N's8', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'', 44, 44, 0, N'~/Repository//Image/jill/sp.jpg', 1, CAST(0x00009DD000CBD5FC AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'b942eb29-f9ae-49a8-b43a-61797e8d654d', N'College Annual Function Duet Song', N' PHILADELPHIA — Condoleezza Rice is no stranger to the whims of royalty. So when the Queen of Soul herself, Aretha Franklin, decided the two should get together to play a song or two for charity, it was decreed.

The former U.S. secretary of state and Franklin took the stage Tuesday evening at Philadelphia''s Mann Music Center in a rare duet for Rice, the classically trained pianist, and Franklin, the soulful voice of a generation. Their aim was to raise money for urban children and awareness for music and the arts.

"It is a joint effort for the inner-city youth of Philadelphia and Detroit," Franklin told The Associated Press the night before their concert with the Philadelphia Orchestra.

Their appearance in the three-hour concert before an estimated crowd of 8,000 overflowed with Franklin''s catalog of hits and arias from the world of opera and classical music.

"We decided to give it a try," Franklin said. "So here we are, in the city of Brotherly — and Sisterly — Love."

Rice, better known as a diplomat and national security adviser, played piano while Franklin sang her hit "I Say A Little Prayer" as well as "My Country ''Tis of Thee." Earlier in the program, Rice performed a selection from Mozart''s "Piano Concerto No. 20 in D Minor" with the orchestra, a piece she said she practiced furiously. ', N'College Annual Function Duet Song', N'', 43, 43, 0, N'~/Repository//Audio/christ/[Songs.PK] Khatta Meetha - 06 - Sajde (Remix).mp3', 3, CAST(0x00009DD000D87C34 AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'22a8b48b-eb1a-414a-91c6-a786c0fe4a15', N's2', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'', 44, 44, 0, N'~/Repository//Image/jill/School Sports 1.JPG', 1, CAST(0x00009DD000CB45D8 AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'e822bbff-a6bb-4545-9750-b17f5fbf3701', N's5', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'', 44, 44, 0, N'~/Repository//Image/jill/Sport_tonight.jpg', 1, CAST(0x00009DD000CBB974 AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'caa19dd8-c79f-41fc-af68-d996dc0290b4', N's2', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.


Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'
Accurate records are kept and updated for most sports at the highest levels, while failures and accomplishments are widely announced in sport news. Sports are most often played just for fun or for the simple fact that people need exercise to stay in good physical condition. However, professional sport is a major source of entertainment.', N'', 44, 44, 0, N'~/Repository//Image/jill/sports-gear.jpg', 1, CAST(0x00009DD000CB2C85 AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'3f96cf0a-494c-48b9-9725-dc3160960d70', N'College Annual Function Duet Song', N' PHILADELPHIA — Condoleezza Rice is no stranger to the whims of royalty. So when the Queen of Soul herself, Aretha Franklin, decided the two should get together to play a song or two for charity, it was decreed.

The former U.S. secretary of state and Franklin took the stage Tuesday evening at Philadelphia''s Mann Music Center in a rare duet for Rice, the classically trained pianist, and Franklin, the soulful voice of a generation. Their aim was to raise money for urban children and awareness for music and the arts.

"It is a joint effort for the inner-city youth of Philadelphia and Detroit," Franklin told The Associated Press the night before their concert with the Philadelphia Orchestra.

Their appearance in the three-hour concert before an estimated crowd of 8,000 overflowed with Franklin''s catalog of hits and arias from the world of opera and classical music.

"We decided to give it a try," Franklin said. "So here we are, in the city of Brotherly — and Sisterly — Love."

Rice, better known as a diplomat and national security adviser, played piano while Franklin sang her hit "I Say A Little Prayer" as well as "My Country ''Tis of Thee." Earlier in the program, Rice performed a selection from Mozart''s "Piano Concerto No. 20 in D Minor" with the orchestra, a piece she said she practiced furiously. ', N'College Annual Function Duet Song', N'', 43, 43, 0, N'~/Repository//Audio/christ/[Songs.PK] Khatta Meetha - 06 - Sajde (Remix).mp3', 3, CAST(0x00009DD000D87D7C AS DateTime))
INSERT [dbo].[Document] ([DocumentID], [Name], [Description], [MetaDescription], [Tag], [LoginUserID], [EditLoginUserID], [Rating], [FilePath], [DocumentType], [ModifiedDate]) VALUES (N'6be2271e-b733-4524-82b6-e740293c73b4', N'College Annual Function Duet Song', N' PHILADELPHIA — Condoleezza Rice is no stranger to the whims of royalty. So when the Queen of Soul herself, Aretha Franklin, decided the two should get together to play a song or two for charity, it was decreed.

The former U.S. secretary of state and Franklin took the stage Tuesday evening at Philadelphia''s Mann Music Center in a rare duet for Rice, the classically trained pianist, and Franklin, the soulful voice of a generation. Their aim was to raise money for urban children and awareness for music and the arts.

"It is a joint effort for the inner-city youth of Philadelphia and Detroit," Franklin told The Associated Press the night before their concert with the Philadelphia Orchestra.

Their appearance in the three-hour concert before an estimated crowd of 8,000 overflowed with Franklin''s catalog of hits and arias from the world of opera and classical music.

"We decided to give it a try," Franklin said. "So here we are, in the city of Brotherly — and Sisterly — Love."

Rice, better known as a diplomat and national security adviser, played piano while Franklin sang her hit "I Say A Little Prayer" as well as "My Country ''Tis of Thee." Earlier in the program, Rice performed a selection from Mozart''s "Piano Concerto No. 20 in D Minor" with the orchestra, a piece she said she practiced furiously. ', N'College Annual Function Duet Song', N'', 43, 43, 0, N'~/Repository//Audio/christ/[Songs.PK] Khatta Meetha - 06 - Sajde (Remix).mp3', 3, CAST(0x00009DD000D87E83 AS DateTime))
/****** Object:  Table [dbo].[User]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[FirstName] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LastName] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MiddleName] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PhotoPath] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BirthDate] [datetime] NULL,
	[Address1] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address2] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[City] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[State] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Country] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WebSite] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AboutMe] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Status] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([UserID], [LoginUserID], [FirstName], [LastName], [MiddleName], [PhotoPath], [BirthDate], [Address1], [Address2], [City], [State], [Country], [WebSite], [AboutMe], [Status], [ModifiedDate]) VALUES (22, 43, N'Jacson', N'Paul', N'', N'~/Repository/Image/christ/face600.jpg', CAST(0x0000406500000000 AS DateTime), N'NW', N'', N'nework', N'CA', N'USA', N'', NULL, N'', CAST(0x00009DCE00F98D89 AS DateTime))
INSERT [dbo].[User] ([UserID], [LoginUserID], [FirstName], [LastName], [MiddleName], [PhotoPath], [BirthDate], [Address1], [Address2], [City], [State], [Country], [WebSite], [AboutMe], [Status], [ModifiedDate]) VALUES (23, 44, N'jill', N'deck', N'', N'~/Repository/Image/jill/image016.jpg', CAST(0x0000649600000000 AS DateTime), N'Grades: Kindergarten - 8', N'4600 E Acampo Road', N'Acampo', N'CA', N'US', N'', NULL, N'working on Student Grad Report', CAST(0x00009DD000E775A0 AS DateTime))
INSERT [dbo].[User] ([UserID], [LoginUserID], [FirstName], [LastName], [MiddleName], [PhotoPath], [BirthDate], [Address1], [Address2], [City], [State], [Country], [WebSite], [AboutMe], [Status], [ModifiedDate]) VALUES (24, 45, N'michael', N'lee', NULL, N'~/Repository/Image/michael/your-face.jpg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserID], [LoginUserID], [FirstName], [LastName], [MiddleName], [PhotoPath], [BirthDate], [Address1], [Address2], [City], [State], [Country], [WebSite], [AboutMe], [Status], [ModifiedDate]) VALUES (25, 46, N'leena', N'robert', NULL, N'~/Repository/Image/leena/Morph-of-Marilyn-Monroe-and-Christina-Aguilera.jpeg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  Table [dbo].[InstituteUser]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteUser](
	[InstituteUserID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteID] [int] NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteUser] PRIMARY KEY CLUSTERED 
(
	[InstituteUserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteUser] ON
INSERT [dbo].[InstituteUser] ([InstituteUserID], [InstituteID], [LoginUserID], [Description], [ModifiedDate]) VALUES (34, 10, 43, N'', CAST(0x00009DCE00F62408 AS DateTime))
INSERT [dbo].[InstituteUser] ([InstituteUserID], [InstituteID], [LoginUserID], [Description], [ModifiedDate]) VALUES (35, 10, 44, N'', CAST(0x00009DCE01003403 AS DateTime))
INSERT [dbo].[InstituteUser] ([InstituteUserID], [InstituteID], [LoginUserID], [Description], [ModifiedDate]) VALUES (36, 10, 45, N'', CAST(0x00009DCE01016B83 AS DateTime))
INSERT [dbo].[InstituteUser] ([InstituteUserID], [InstituteID], [LoginUserID], [Description], [ModifiedDate]) VALUES (37, 10, 46, N'', CAST(0x00009DCE0101DC24 AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteUser] OFF
/****** Object:  Table [dbo].[Tutorial]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tutorial]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tutorial](
	[TutorialID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[TutorialTypeID] [int] NOT NULL,
	[Name] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[FilePath] [varchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Tutorial] PRIMARY KEY CLUSTERED 
(
	[TutorialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[aspnet_Membership]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Membership](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Password] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PasswordFormat] [int] NOT NULL,
	[PasswordSalt] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MobilePIN] [nvarchar](16) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoweredEmail] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PasswordQuestion] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[PasswordAnswer] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsApproved] [bit] NOT NULL,
	[IsLockedOut] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastLoginDate] [datetime] NOT NULL,
	[LastPasswordChangedDate] [datetime] NOT NULL,
	[LastLockoutDate] [datetime] NOT NULL,
	[FailedPasswordAttemptCount] [int] NOT NULL,
	[FailedPasswordAttemptWindowStart] [datetime] NOT NULL,
	[FailedPasswordAnswerAttemptCount] [int] NOT NULL,
	[FailedPasswordAnswerAttemptWindowStart] [datetime] NOT NULL,
	[Comment] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__aspnet_Membershi__3A81B327] PRIMARY KEY NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]') AND name = N'aspnet_Membership_index')
CREATE CLUSTERED INDEX [aspnet_Membership_index] ON [dbo].[aspnet_Membership] 
(
	[ApplicationId] ASC,
	[LoweredEmail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'041187b8-e6db-40b0-8aa5-296d0dd69675', N'nNS78yNng9ixO8Q2HUP08+6ZSVU=', 1, N'eNvauJK4DhaBZjaBsd9Esw==', NULL, N'', N'', N'No Question', N'U6qfZ/gIDF7zCnn4RsXdz8/52dc=', 1, 0, CAST(0x00009DCE00A6C494 AS DateTime), CAST(0x00009DCE00A7770D AS DateTime), CAST(0x00009DCE00A6C494 AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 1, CAST(0x00009DD00066F68C AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'aac3f49e-bd26-4dd2-806c-5f73b7b06e20', N'k5e5XfYDgFgTU3nFPeYFM5xrjaQ=', 1, N'zp65o/4C9Cd8vzJ6dqNvBg==', NULL, N'', N'', N'No Question', N'onrD9Dsge3BMoOsz1zKhu969Oog=', 1, 0, CAST(0x00009DCE00A73898 AS DateTime), CAST(0x00009DD0007EE274 AS DateTime), CAST(0x00009DCE00A73898 AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'be124142-48c4-4a35-b6b6-d01f095750ec', N'OI8nz+pFglUwQAYZjSELhcmqOOk=', 1, N'+d5NOezyQA7hlIMU9uTwcg==', NULL, N'admin@Christ.com', N'admin@christ.com', N'No Question', N'8BQeTrG2svIHFx4X+HdRTSqahO4=', 1, 0, CAST(0x00009DCE009B8098 AS DateTime), CAST(0x00009DD200C288C9 AS DateTime), CAST(0x00009DCE009B8098 AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
INSERT [dbo].[aspnet_Membership] ([ApplicationId], [UserId], [Password], [PasswordFormat], [PasswordSalt], [MobilePIN], [Email], [LoweredEmail], [PasswordQuestion], [PasswordAnswer], [IsApproved], [IsLockedOut], [CreateDate], [LastLoginDate], [LastPasswordChangedDate], [LastLockoutDate], [FailedPasswordAttemptCount], [FailedPasswordAttemptWindowStart], [FailedPasswordAnswerAttemptCount], [FailedPasswordAnswerAttemptWindowStart], [Comment]) VALUES (N'abac3295-890d-4213-85c3-521cfee7c5d1', N'2be3699d-3686-44bd-a2b2-e708ffd90eb2', N'xoV3B+xl7kkzVMQZyNmjB+c6qxA=', 1, N'bELmEtNufAhfd0CXvqHnjw==', NULL, N'jill@aa.com', N'jill@aa.com', N'No Question', N'YV42PIPiq0gEVjOoSc0e6CA+EEo=', 1, 0, CAST(0x00009DCE00A59060 AS DateTime), CAST(0x00009DD200A0AA78 AS DateTime), CAST(0x00009DCE00A59060 AS DateTime), CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), 0, CAST(0xFFFF2FB300000000 AS DateTime), NULL)
/****** Object:  Table [dbo].[aspnet_Paths]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Paths](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[PathId] [uniqueidentifier] NOT NULL,
	[Path] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoweredPath] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK__aspnet_Paths__6C190EBB] PRIMARY KEY NONCLUSTERED 
(
	[PathId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]') AND name = N'aspnet_Paths_index')
CREATE UNIQUE CLUSTERED INDEX [aspnet_Paths_index] ON [dbo].[aspnet_Paths] 
(
	[ApplicationId] ASC,
	[LoweredPath] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
/****** Object:  Table [dbo].[aspnet_Roles]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Roles](
	[ApplicationId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[RoleName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoweredRoleName] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__aspnet_Roles__59063A47] PRIMARY KEY NONCLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]') AND name = N'aspnet_Roles_index1')
CREATE UNIQUE CLUSTERED INDEX [aspnet_Roles_index1] ON [dbo].[aspnet_Roles] 
(
	[ApplicationId] ASC,
	[LoweredRoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
/****** Object:  Table [dbo].[aspnet_PersonalizationPerUser]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_PersonalizationPerUser](
	[Id] [uniqueidentifier] NOT NULL,
	[PathId] [uniqueidentifier] NULL,
	[UserId] [uniqueidentifier] NULL,
	[PageSettings] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__aspnet_Personali__74AE54BC] PRIMARY KEY NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]') AND name = N'aspnet_PersonalizationPerUser_index1')
CREATE UNIQUE CLUSTERED INDEX [aspnet_PersonalizationPerUser_index1] ON [dbo].[aspnet_PersonalizationPerUser] 
(
	[PathId] ASC,
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]') AND name = N'aspnet_PersonalizationPerUser_ncindex2')
CREATE UNIQUE NONCLUSTERED INDEX [aspnet_PersonalizationPerUser_ncindex2] ON [dbo].[aspnet_PersonalizationPerUser] 
(
	[UserId] ASC,
	[PathId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
/****** Object:  Table [dbo].[aspnet_Profile]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_Profile](
	[UserId] [uniqueidentifier] NOT NULL,
	[PropertyNames] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PropertyValuesString] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PropertyValuesBinary] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__aspnet_Profile__4F7CD00D] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[aspnet_UsersInRoles]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_UsersInRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK__aspnet_UsersInRo__5CD6CB2B] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]') AND name = N'aspnet_UsersInRoles_index')
CREATE NONCLUSTERED INDEX [aspnet_UsersInRoles_index] ON [dbo].[aspnet_UsersInRoles] 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
GO
/****** Object:  Table [dbo].[DocumentCource]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DocumentCource]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DocumentCource](
	[DocumentCourceID] [uniqueidentifier] NOT NULL,
	[DocumentID] [uniqueidentifier] NOT NULL,
	[InstituteCourceID] [int] NOT NULL,
	[SubjectID] [int] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_DocumentCource] PRIMARY KEY CLUSTERED 
(
	[DocumentCourceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'82bbc742-8686-42cd-8b32-0964d49fe9b3', N'4d2f8ae5-3741-426d-9c6e-349d84224e1f', 21, 9, CAST(0x00009DD000C93BCF AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'a9f65053-eba8-4d6c-af83-15610787983f', N'3f96cf0a-494c-48b9-9725-dc3160960d70', 21, 9, CAST(0x00009DD000D87D7C AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'0c707996-403b-492c-b00c-179c6d9b7adf', N'22a8b48b-eb1a-414a-91c6-a786c0fe4a15', 21, 9, CAST(0x00009DD000CB45D8 AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'f9606fdd-0143-458b-bbd1-34657f459eb3', N'b942eb29-f9ae-49a8-b43a-61797e8d654d', 21, 9, CAST(0x00009DD000D87C34 AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'f36ebb3f-17ef-421a-ad60-4eb523acb454', N'caa19dd8-c79f-41fc-af68-d996dc0290b4', 21, 9, CAST(0x00009DD000CB2C85 AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'c70cf16e-aa52-4f7d-9a7b-628c614b8a80', N'e822bbff-a6bb-4545-9750-b17f5fbf3701', 21, 9, CAST(0x00009DD000CBB974 AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'86f56b96-a56b-4588-8ec4-a7274743dda7', N'6be2271e-b733-4524-82b6-e740293c73b4', 21, 9, CAST(0x00009DD000D87E83 AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'39b06698-2132-4bd4-9f76-c5f444691608', N'29418d4c-c3ba-48ab-8317-2c6e89c76bb7', 21, 9, CAST(0x00009DD000CB697E AS DateTime))
INSERT [dbo].[DocumentCource] ([DocumentCourceID], [DocumentID], [InstituteCourceID], [SubjectID], [ModifiedDate]) VALUES (N'eacd5357-32cd-4267-896e-cf3bc7d4311f', N'2f782a98-1fcd-43cc-bf76-466c4a01ce90', 21, 9, CAST(0x00009DD000CBD5FC AS DateTime))
/****** Object:  Table [dbo].[EXM_Question]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_Question]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EXM_Question](
	[EXM_QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[ExamID] [int] NOT NULL,
	[Q_Type] [int] NOT NULL,
	[Marks] [decimal](18, 0) NULL,
	[Description] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[Order] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_EXM_Question] PRIMARY KEY CLUSTERED 
(
	[EXM_QuestionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EXM_Question] ON
INSERT [dbo].[EXM_Question] ([EXM_QuestionID], [Question], [LoginUserID], [ExamID], [Q_Type], [Marks], [Description], [ModifiedDate], [Order], [IsActive]) VALUES (48, N'What is SDLC?', 43, 21, 1, CAST(2 AS Decimal(18, 0)), N'What is SDLC?', CAST(0x00009DD000EA0CC7 AS DateTime), 2, 0)
INSERT [dbo].[EXM_Question] ([EXM_QuestionID], [Question], [LoginUserID], [ExamID], [Q_Type], [Marks], [Description], [ModifiedDate], [Order], [IsActive]) VALUES (49, N'What is First Phase of SDLC?', 43, 21, 2, CAST(2 AS Decimal(18, 0)), N'What is First Phase of SDLC?', CAST(0x00009DD000EB4E75 AS DateTime), 1, 0)
SET IDENTITY_INSERT [dbo].[EXM_Question] OFF
/****** Object:  Table [dbo].[EXM_Answer]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXM_Answer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EXM_Answer](
	[EXM_AnswerID] [int] IDENTITY(1,1) NOT NULL,
	[EXM_QuestionID] [int] NOT NULL,
	[Answer] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsRight] [bit] NOT NULL,
	[Marks] [decimal](18, 0) NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_EXM_Answer] PRIMARY KEY CLUSTERED 
(
	[EXM_AnswerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[EXM_Answer] ON
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (103, 48, N'Software Delay Life Cycle', 0, NULL, CAST(0x00009DD000EA2CB6 AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (104, 48, N'Software Development Life Cycle', 1, NULL, CAST(0x00009DD000EA4743 AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (105, 48, N'Software Dead Line Cycle', 0, NULL, CAST(0x00009DD000EA6000 AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (106, 49, N'Requirement Gathering', 0, NULL, CAST(0x00009DD000EB6575 AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (107, 49, N'Requirement Analysis?', 1, NULL, CAST(0x00009DD000EB7FE1 AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (108, 49, N'Project Planning', 1, NULL, CAST(0x00009DD000EB91DC AS DateTime))
INSERT [dbo].[EXM_Answer] ([EXM_AnswerID], [EXM_QuestionID], [Answer], [IsRight], [Marks], [ModifiedDate]) VALUES (109, 49, N'System Design', 0, NULL, CAST(0x00009DD000EB9CFE AS DateTime))
SET IDENTITY_INSERT [dbo].[EXM_Answer] OFF
/****** Object:  Table [dbo].[InstituteUserInUserType]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserInUserType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteUserInUserType](
	[InstituteUserInUserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[LoginUserID] [int] NOT NULL,
	[InstituteUserID] [int] NOT NULL,
	[InstituteUserTypeID] [int] NOT NULL,
	[Modifieddate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteUserInUserType] PRIMARY KEY CLUSTERED 
(
	[InstituteUserInUserTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteUserInUserType] ON
INSERT [dbo].[InstituteUserInUserType] ([InstituteUserInUserTypeID], [LoginUserID], [InstituteUserID], [InstituteUserTypeID], [Modifieddate]) VALUES (18, 43, 10, 24, CAST(0x00009DCE00F94284 AS DateTime))
INSERT [dbo].[InstituteUserInUserType] ([InstituteUserInUserTypeID], [LoginUserID], [InstituteUserID], [InstituteUserTypeID], [Modifieddate]) VALUES (19, 43, 10, 23, CAST(0x00009DCE00F94CB7 AS DateTime))
INSERT [dbo].[InstituteUserInUserType] ([InstituteUserInUserTypeID], [LoginUserID], [InstituteUserID], [InstituteUserTypeID], [Modifieddate]) VALUES (20, 45, 10, 23, CAST(0x00009DCE01017A95 AS DateTime))
INSERT [dbo].[InstituteUserInUserType] ([InstituteUserInUserTypeID], [LoginUserID], [InstituteUserID], [InstituteUserTypeID], [Modifieddate]) VALUES (21, 46, 10, 23, CAST(0x00009DCE0101E38E AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteUserInUserType] OFF
/****** Object:  Table [dbo].[ShareGroup]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShareGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ShareGroup](
	[ShareGroupID] [uniqueidentifier] NOT NULL,
	[InstituteUserTypeID] [int] NOT NULL,
	[ShareID] [uniqueidentifier] NOT NULL,
	[EnableEdit] [bit] NULL,
	[EnableAdd] [bit] NULL,
	[EnableView] [bit] NULL,
	[EnableDelete] [bit] NULL,
	[EnableEditByLoggedIn] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ShareGroup] PRIMARY KEY CLUSTERED 
(
	[ShareGroupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ShareGroup] ([ShareGroupID], [InstituteUserTypeID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'662af698-792d-40f6-8ae4-3a50fd0425fe', 23, N'37766f80-181f-4964-9741-80ff5c34c668', 0, 0, 0, 0, 0, CAST(0x00009DD101229D54 AS DateTime))
INSERT [dbo].[ShareGroup] ([ShareGroupID], [InstituteUserTypeID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'd47cad74-24b6-4819-bb9f-80dc85b0085e', 24, N'37766f80-181f-4964-9741-80ff5c34c668', 1, 0, 0, 0, 0, CAST(0x00009DD101229D58 AS DateTime))
INSERT [dbo].[ShareGroup] ([ShareGroupID], [InstituteUserTypeID], [ShareID], [EnableEdit], [EnableAdd], [EnableView], [EnableDelete], [EnableEditByLoggedIn], [ModifiedDate]) VALUES (N'b1bb39e5-7b14-49ed-af38-af6bdef7957f', 25, N'37766f80-181f-4964-9741-80ff5c34c668', 0, 0, 0, 0, 0, CAST(0x00009DD101229D58 AS DateTime))
/****** Object:  Table [dbo].[InstituteUserTypeAccess]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InstituteUserTypeAccess]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[InstituteUserTypeAccess](
	[InstituteUserTypeAccessID] [int] IDENTITY(1,1) NOT NULL,
	[InstituteUserTypeID] [int] NOT NULL,
	[CanAddExam] [bit] NOT NULL,
	[CanAddQuestion] [bit] NOT NULL,
	[CanAddUser] [bit] NOT NULL,
	[CanAddCource] [bit] NOT NULL,
	[CanAddSubject] [bit] NOT NULL,
	[CanAddAudio] [bit] NULL,
	[CanAddImage] [bit] NULL,
	[CanAddDocument] [bit] NULL,
	[CanAddVideo] [bit] NULL,
	[CanAddHomeWork] [bit] NULL,
	[CanAddEvent] [bit] NULL,
	[CanAddArticle] [bit] NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_InstituteTypeRight] PRIMARY KEY CLUSTERED 
(
	[InstituteUserTypeAccessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[InstituteUserTypeAccess] ON
INSERT [dbo].[InstituteUserTypeAccess] ([InstituteUserTypeAccessID], [InstituteUserTypeID], [CanAddExam], [CanAddQuestion], [CanAddUser], [CanAddCource], [CanAddSubject], [CanAddAudio], [CanAddImage], [CanAddDocument], [CanAddVideo], [CanAddHomeWork], [CanAddEvent], [CanAddArticle], [ModifiedDate]) VALUES (18, 23, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, CAST(0x00009DCE00F8E1AC AS DateTime))
INSERT [dbo].[InstituteUserTypeAccess] ([InstituteUserTypeAccessID], [InstituteUserTypeID], [CanAddExam], [CanAddQuestion], [CanAddUser], [CanAddCource], [CanAddSubject], [CanAddAudio], [CanAddImage], [CanAddDocument], [CanAddVideo], [CanAddHomeWork], [CanAddEvent], [CanAddArticle], [ModifiedDate]) VALUES (19, 24, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, CAST(0x00009DCE00F91E80 AS DateTime))
INSERT [dbo].[InstituteUserTypeAccess] ([InstituteUserTypeAccessID], [InstituteUserTypeID], [CanAddExam], [CanAddQuestion], [CanAddUser], [CanAddCource], [CanAddSubject], [CanAddAudio], [CanAddImage], [CanAddDocument], [CanAddVideo], [CanAddHomeWork], [CanAddEvent], [CanAddArticle], [ModifiedDate]) VALUES (20, 25, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, CAST(0x00009DCE00F92E69 AS DateTime))
INSERT [dbo].[InstituteUserTypeAccess] ([InstituteUserTypeAccessID], [InstituteUserTypeID], [CanAddExam], [CanAddQuestion], [CanAddUser], [CanAddCource], [CanAddSubject], [CanAddAudio], [CanAddImage], [CanAddDocument], [CanAddVideo], [CanAddHomeWork], [CanAddEvent], [CanAddArticle], [ModifiedDate]) VALUES (21, 26, 0, 1, 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x00009DD10122D5DF AS DateTime))
SET IDENTITY_INSERT [dbo].[InstituteUserTypeAccess] OFF
/****** Object:  Table [dbo].[Widget]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Widget]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Widget](
	[WidgetID] [uniqueidentifier] NOT NULL,
	[PageID] [uniqueidentifier] NOT NULL,
	[Title] [varchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ContentType] [int] NOT NULL,
	[ContentID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[WidgetOrder] [int] NOT NULL,
	[WidgetColumn] [int] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Widget] PRIMARY KEY CLUSTERED 
(
	[WidgetID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'627549e8-8f6d-4fa0-94f0-0bc117682d3e', N'9a804b38-223f-4d26-a21e-9046e938aef3', N'', 0, N'1b93c087-83b8-49bf-b8ca-824cc21a9261', 1, 2, CAST(0x00009DD200E80FDF AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'7ca622dc-f155-4de0-99cb-0f200ae7e946', N'c4d60d62-6a18-4d45-a091-1a3ca31e53fa', N'About me', 0, N'7bf18a23-8dac-4e9a-b2ab-dc26c85999e7', 2, 2, CAST(0x00009DD1012A2556 AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'f2036f2a-ba8c-4e8f-ba13-1de7251010f7', N'c4d60d62-6a18-4d45-a091-1a3ca31e53fa', N'All Content', 15, N'43', 3, 1, CAST(0x00009DD1012A3497 AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'ce155f56-e2d0-45cc-8bb7-34d573b1c484', N'9a804b38-223f-4d26-a21e-9046e938aef3', N'Rohan Test', 0, N'd872e288-15bc-42eb-bab0-d21acad46c03', 2, 1, CAST(0x00009DD200E80FDF AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'5d91795f-9728-4cb7-8cea-7a5d60a7dc34', N'9a804b38-223f-4d26-a21e-9046e938aef3', N'All Content', 15, N'43', 4, 1, CAST(0x00009DD200E80FE4 AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'fefcbd5b-b8fb-4ede-905e-bb77a36de28d', N'c4d60d62-6a18-4d45-a091-1a3ca31e53fa', N'About My College', 0, N'85c5023c-beca-4676-9407-e0a90204ad0f', 4, 2, CAST(0x00009DD200DC02E9 AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'5b33d498-36ef-41b8-8625-c303c2bd2f00', N'9a804b38-223f-4d26-a21e-9046e938aef3', N'ProfileInfo', 16, N'43', 3, 1, CAST(0x00009DD200E80FE4 AS DateTime))
INSERT [dbo].[Widget] ([WidgetID], [PageID], [Title], [ContentType], [ContentID], [WidgetOrder], [WidgetColumn], [ModifiedDate]) VALUES (N'2de7bf20-4363-45f3-a76e-f617cdcff6cd', N'c4d60d62-6a18-4d45-a091-1a3ca31e53fa', N'ProfileInfo', 16, N'44', 5, 1, CAST(0x00009DD200F1950B AS DateTime))
/****** Object:  Table [dbo].[aspnet_PersonalizationAllUsers]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[aspnet_PersonalizationAllUsers](
	[PathId] [uniqueidentifier] NOT NULL,
	[PageSettings] [image] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK__aspnet_Personali__71D1E811] PRIMARY KEY CLUSTERED 
(
	[PathId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalMarksByExamAndUserExamID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTotalMarksByExamAndUserExamID]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
CREATE  function [dbo].[GetTotalMarksByExamAndUserExamID](@ExamID int,@UserExamID Int,@LoginUserID Int)

returns Int
as
    begin
declare @totalmark as int
set @totalmark=0
SELECT     @totalmark=SUM(RecieveMark) 
FROM         EXM_UserAnswer

WHERE  (UserExamID = @UserExamID) AND (LoginUserID = @LoginUserID)
IF(@totalmark IS NULL)
BEGIN
set @totalmark=0
END 
return @totalmark
    end
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetFullMessage]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetFullMessage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[GetFullMessage]
@MessageID as uniqueidentifier
as
BEGIN
SELECT     MessageID, Subject, MessageText, ToLoginUserID, FromLoginUserID, ReplyID, ReadTime, IsReaded, DeleteFromTo, DeleteFromFrom, ModifiedDate, 
                      dbo.GetProfilePic(ToLoginUserID) AS ToProfilePic, dbo.GetProfilePic(FromLoginUserID) AS FromProfilePic, dbo.GetFullName(ToLoginUserID) 
                      AS ToFullName, dbo.GetFullName(FromLoginUserID) AS FromFullName
FROM         Message
WHERE     MessageID=@MessageID

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetSentMessage]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSentMessage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetSentMessage]
@LoginUserID as int
as
BEGIN
SELECT     MessageID, Subject, MessageText, ToLoginUserID, FromLoginUserID, ReplyID, ReadTime, IsReaded, DeleteFromTo, DeleteFromFrom, ModifiedDate, 
                      dbo.GetProfilePic(ToLoginUserID) AS ToProfilePic, dbo.GetProfilePic(FromLoginUserID) AS FromProfilePic, dbo.GetFullName(ToLoginUserID) 
                      AS ToFullName, dbo.GetFullName(FromLoginUserID) AS FromFullName
FROM         Message
WHERE    FromLoginUserID=@LoginUserID

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetInboxMessage]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInboxMessage]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetInboxMessage]
@LoginUserID as int
as
BEGIN
SELECT     MessageID, Subject, MessageText, ToLoginUserID, FromLoginUserID, ReplyID, ReadTime, IsReaded, DeleteFromTo, DeleteFromFrom, ModifiedDate, 
                      dbo.GetProfilePic(ToLoginUserID) AS ToProfilePic, dbo.GetProfilePic(FromLoginUserID) AS FromProfilePic, dbo.GetFullName(ToLoginUserID) 
                      AS ToFullName, dbo.GetFullName(FromLoginUserID) AS FromFullName
FROM         Message
WHERE     ToLoginUserID=@LoginUserID

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserRelatedContent]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRelatedContent]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetUserRelatedContent]
@LoginUserID as int,
@InstituteCourceID as int,
@InstituteSubjectID as int,
@ContentType as int,
@LoggedInUserLoginID as int
as 
Begin


SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 1 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = CASE WHEN @LoginUserID <> 0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND 
                      ([Document].DocumentType = ''1'') AND 
                      (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID <> 0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
                      AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID <> 0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END) AND 
                      (1 = CASE WHEN @ContentType <> 0 THEN @ContentType ELSE 1 END)
					AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 2 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''2'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (2 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 2 END )         
		AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 3 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''3'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (3 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 3 END )   
       AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )            
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 4 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''4'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (4 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 4 END )   
        AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )            
UNION ALL

SELECT     CAST(QuestionID AS varchar(40)) AS ID, QuestionText AS Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate, 
                      5 AS ContentType, '''' as Param1
FROM         Question
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (5 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 5 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      


UNION ALL

SELECT     CAST(HomeWorkID as varchar(40)) as ID, Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
             6 as ContentType,'''' as Param1
FROM         HomeWork      
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (6 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 6 END )  
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      
 

UNION ALL

SELECT     CAST(ExamID as varchar(40)) as ID, ExamName as Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
		   7 as ContentType,Cast(IsActive as varchar(max)) as Param1
FROM         Exam
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (7 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 7 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )    
UNION ALL

SELECT     CAST(ArticleID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			8 as ContentType,'''' as Param1
FROM         Article 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (8 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 8 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )    

UNION ALL

SELECT     CAST(EventID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			9 as ContentType,'''' as Param1
FROM         Event 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (9 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 9 END )   
AND Event.StartDate>getdate()-1
AND Event.EndDate>getdate()+1
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )    

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserRelatedContentSearch]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRelatedContentSearch]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetUserRelatedContentSearch]
@LoginUserID as int,
@InstituteCourceID as int,
@InstituteSubjectID as int,
@ContentType as int,
@LoggedInUserLoginID as int,
@Keyword as varchar(max),
@Starddate as datetime,
@Enddate as datetime
as 
Begin


SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 1 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = CASE WHEN @LoginUserID <> 0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND 
                      ([Document].DocumentType = ''1'') AND 
                      (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID <> 0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
                      AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID <> 0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END) AND 
                      (1 = CASE WHEN @ContentType <> 0 THEN @ContentType ELSE 1 END)
					AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )  
					AND ([Document].Name LIKE (''%''+@Keyword+''%'')
					OR [Document].Description LIKE (''%''+@Keyword+''%'')
					OR [Document].MetaDescription LIKE (''%''+@Keyword+''%'')
OR [Document].tag LIKE (''%''+@Keyword+''%'')      )
  

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 2 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''2'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (2 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 2 END )         
		AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )   
		AND ([Document].Name LIKE (''%''+@Keyword+''%'')
					OR [Document].Description LIKE (''%''+@Keyword+''%'')
					OR [Document].MetaDescription LIKE (''%''+@Keyword+''%'')
OR [Document].tag LIKE (''%''+@Keyword+''%'')      )
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 3 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''3'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (3 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 3 END )   
       AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )   
	AND ([Document].Name LIKE (''%''+@Keyword+''%'')
					OR [Document].Description LIKE (''%''+@Keyword+''%'')
					OR [Document].MetaDescription LIKE (''%''+@Keyword+''%'')
OR [Document].tag LIKE (''%''+@Keyword+''%'')      )     
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 4 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''4'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (4 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 4 END )   
        AND DocumentCource.InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      
		AND ([Document].Name LIKE (''%''+@Keyword+''%'')
					OR [Document].Description LIKE (''%''+@Keyword+''%'')
					OR [Document].MetaDescription LIKE (''%''+@Keyword+''%'')
OR [Document].tag LIKE (''%''+@Keyword+''%'')      )
UNION ALL

SELECT     CAST(QuestionID AS varchar(40)) AS ID, QuestionText AS Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate, 
                      5 AS ContentType, '''' as Param1
FROM         Question
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (5 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 5 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )   
		AND (Question.QuestionText LIKE (''%''+@Keyword+''%'')
					OR Question.Description LIKE (''%''+@Keyword+''%'')					  
OR Question.tag LIKE (''%''+@Keyword+''%'')       )


UNION ALL

SELECT     CAST(HomeWorkID as varchar(40)) as ID, Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
             6 as ContentType,'''' as Param1
FROM         HomeWork      
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (6 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 6 END )  
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )      
AND (HomeWork.Title LIKE (''%''+@Keyword+''%'')
					OR HomeWork.Description LIKE (''%''+@Keyword+''%'')
					OR HomeWork.ShortDescription LIKE (''%''+@Keyword+''%'')      )

 

UNION ALL

SELECT     CAST(ExamID as varchar(40)) as ID, ExamName as Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
		   7 as ContentType,Cast(IsActive as varchar(max)) as Param1
FROM         Exam
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (7 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 7 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )   
 
UNION ALL

SELECT     CAST(ArticleID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			8 as ContentType,'''' as Param1
FROM         Article 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (8 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 8 END )   
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )  
AND (Article.Title LIKE (''%''+@Keyword+''%'')
					OR Article.Description LIKE (''%''+@Keyword+''%'')
					OR Article.MetaDescription LIKE (''%''+@Keyword+''%'')      
OR Article.tag LIKE (''%''+@Keyword+''%'')      )
  

UNION ALL

SELECT     CAST(EventID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			9 as ContentType,'''' as Param1
FROM         Event 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (9 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 9 END )   
AND Event.StartDate>getdate()-1
AND Event.EndDate>getdate()+1
AND InstituteCourceID in (SELECT     InstituteCource.InstituteCourceID
															FROM         InstituteCource INNER JOIN
															InstituteCourceUser ON InstituteCource.InstituteCourceID = InstituteCourceUser.InstituteCourceID
															WHERE     (InstituteCourceUser.LoginUserID = @LoggedInUserLoginID)  )  
AND (Event.Title LIKE (''%''+@Keyword+''%'')
					OR Event.Description LIKE (''%''+@Keyword+''%'')
					OR Event.MetaDescription LIKE (''%''+@Keyword+''%'')      
OR Event.tag LIKE (''%''+@Keyword+''%'')     )

END
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetInstituteCourceName]    Script Date: 08/14/2010 17:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteCourceName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[GetInstituteCourceName]( @InstituteCourceID as int)
RETURNS varchar(max)
as
Begin

declare @EnableEdit as varchar(max)
set @EnableEdit=''''


SELECT     @EnableEdit=Cource.CourceName
FROM         InstituteCource INNER JOIN
                      Cource ON InstituteCource.CourceID = Cource.CourceID
WHERE     (InstituteCource.InstituteCourceID = @InstituteCourceID)


return @EnableEdit
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetUser]
@InstituteCourceID as int,
@InstituteID as int
as
BEGIN
SELECT     [User].UserID, [User].LoginUserID, [User].FirstName, [User].LastName, [User].MiddleName, [User].PhotoPath, [User].BirthDate, [User].Address1, 
                      [User].Address2, [User].City, [User].State, [User].Country, [User].WebSite, [User].AboutMe, [User].Status
                      
FROM         InstituteCource INNER JOIN
                      Institute ON InstituteCource.InstituteID = Institute.InstituteID INNER JOIN
                      InstituteUser ON Institute.InstituteID = InstituteUser.InstituteID INNER JOIN
                      LoginUser ON InstituteUser.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID
GROUP BY [User].UserID, [User].LoginUserID, [User].FirstName, [User].LastName, [User].MiddleName, [User].PhotoPath, [User].BirthDate, [User].Address1, 
                      [User].Address2, [User].City, [User].State, [User].Country, [User].WebSite, [User].AboutMe, [User].Status
                      
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_WebEvent_LogEvent]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_WebEvent_LogEvent]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_WebEvent_LogEvent]
        @EventId         char(32),
        @EventTimeUtc    datetime,
        @EventTime       datetime,
        @EventType       nvarchar(256),
        @EventSequence   decimal(19,0),
        @EventOccurrence decimal(19,0),
        @EventCode       int,
        @EventDetailCode int,
        @Message         nvarchar(1024),
        @ApplicationPath nvarchar(256),
        @ApplicationVirtualPath nvarchar(256),
        @MachineName    nvarchar(256),
        @RequestUrl      nvarchar(1024),
        @ExceptionType   nvarchar(256),
        @Details         ntext
AS
BEGIN
    INSERT
        dbo.aspnet_WebEvent_Events
        (
            EventId,
            EventTimeUtc,
            EventTime,
            EventType,
            EventSequence,
            EventOccurrence,
            EventCode,
            EventDetailCode,
            Message,
            ApplicationPath,
            ApplicationVirtualPath,
            MachineName,
            RequestUrl,
            ExceptionType,
            Details
        )
    VALUES
    (
        @EventId,
        @EventTimeUtc,
        @EventTime,
        @EventType,
        @EventSequence,
        @EventOccurrence,
        @EventCode,
        @EventDetailCode,
        @Message,
        @ApplicationPath,
        @ApplicationVirtualPath,
        @MachineName,
        @RequestUrl,
        @ExceptionType,
        @Details
    )
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserContent]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserContent]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetUserContent]
@LoginUserID as int

as 
Begin


SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 1 AS ContentType
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = @LoginUserID) AND ([Document].DocumentType = ''1'')

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 2 AS ContentType
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = @LoginUserID) AND ([Document].DocumentType = ''2'')

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 3 AS ContentType
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = @LoginUserID) AND ([Document].DocumentType = ''3'')

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 4 AS ContentType
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = @LoginUserID) AND ([Document].DocumentType = ''4'')

UNION ALL

SELECT     CAST(QuestionID as varchar(40)) as ID, QuestionText as Title, LoginUserID, InstituteCourceID, InstituteSubjectID,  ModifiedDate,5 as ContentType
FROM         Question
WHERE     (LoginUserID = @LoginUserID)




END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetContent]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetContent]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetContent]
@LoginUserID as int,
@InstituteCourceID as int,
@InstituteSubjectID as int,
@ContentType as int
as 
Begin


SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 1 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID = CASE WHEN @LoginUserID <> 0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND 
                      ([Document].DocumentType = ''1'') AND 
                      (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID <> 0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
                      AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID <> 0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END) AND 
                      (1 = CASE WHEN @ContentType <> 0 THEN @ContentType ELSE 1 END)        

UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 2 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''2'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (2 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 2 END )         
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 3 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''3'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (3 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 3 END )         
UNION ALL

SELECT     CAST([Document].DocumentID AS varchar(40)) AS ID, [Document].Name AS Title, [Document].LoginUserID, DocumentCource.InstituteCourceID, 
                      DocumentCource.SubjectID AS InstituteSubjectID, [Document].ModifiedDate, 4 AS ContentType, [Document].FilePath as Param1
FROM         [Document] INNER JOIN
                      DocumentCource ON [Document].DocumentID = DocumentCource.DocumentID
WHERE     ([Document].LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE [Document].LoginUserID END) AND ([Document].DocumentType = ''4'')
		AND (DocumentCource.InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE DocumentCource.InstituteCourceID END) 
		AND (DocumentCource.SubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE DocumentCource.SubjectID END )         
		AND (4 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 4 END )         
UNION ALL

SELECT     CAST(QuestionID AS varchar(40)) AS ID, QuestionText AS Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate, 
                      5 AS ContentType, '''' as Param1
FROM         Question
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (5 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 5 END )   


UNION ALL

SELECT     CAST(HomeWorkID as varchar(40)) as ID, Title, LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
             6 as ContentType,'''' as Param1
FROM         HomeWork      
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (6 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 6 END )   

UNION ALL

SELECT     CAST(ExamID as varchar(40)) as ID, ExamName as Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
		   7 as ContentType,Cast(IsActive as varchar(max)) as Param1
FROM         Exam
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (7 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 7 END )   

UNION ALL

SELECT     CAST(ArticleID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			8 as ContentType,'''' as Param1
FROM         Article 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (8 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 8 END )   


UNION ALL

SELECT     CAST(EventID as varchar(40)) as ID,  Title,LoginUserID, InstituteCourceID, InstituteSubjectID, ModifiedDate,
			9 as ContentType,'''' as Param1
FROM         Event 
WHERE     (LoginUserID =CASE WHEN @LoginUserID<>0 THEN @LoginUserID ELSE LoginUserID END) 
AND (InstituteCourceID = CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE InstituteCourceID END) 
AND (InstituteSubjectID = CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE InstituteSubjectID END)
AND (9 = CASE WHEN @ContentType<>0 THEN @ContentType ELSE 9 END )   
AND Event.StartDate>getdate()-1
AND Event.EndDate>getdate()+1


END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetInstituteByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteByLoginUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create procedure [dbo].[GetInstituteByLoginUserID]
@LoginUserID as int
as
Begin


SELECT     Institute.Name AS InstituteName, LoginUser.Username, [User].UserID, [User].LoginUserID, [User].FirstName, [User].LastName, [User].MiddleName, 
                      [User].PhotoPath, [User].BirthDate, [User].Address1, [User].Address2, [User].City, [User].State, [User].Country, [User].WebSite, [User].ModifiedDate, 
                      Institute.InstituteID
FROM         InstituteUser INNER JOIN
                      LoginUser ON InstituteUser.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      Institute ON InstituteUser.InstituteID = Institute.InstituteID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID
WHERE     ([User].LoginUserID = @LoginUserID)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserByInsituteCourceID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserByInsituteCourceID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[GetUserByInsituteCourceID]
@InsituteCourceID as int
as
BEGIN


SELECT     [User].UserID, [User].LoginUserID, [User].FirstName, [User].LastName, [User].MiddleName, [User].PhotoPath, [User].BirthDate, [User].Address1, 
                      [User].Address2, [User].City, [User].State, [User].Country, [User].WebSite, [User].AboutMe, [User].Status, [User].ModifiedDate
FROM         [User] INNER JOIN
                      LoginUser ON [User].LoginUserID = LoginUser.LoginUserID

Where [User].LoginUserID in (SELECT     LoginUserID
FROM         InstituteCourceUser
WHERE     (InstituteCourceID = @InsituteCourceID))


END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetInstituteUserFeatureAccess]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteUserFeatureAccess]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[GetInstituteUserFeatureAccess]
@LoginUserID as int
as 
Begin

SELECT     InstituteUserTypeAccess.InstituteUserTypeAccessID, InstituteUserTypeAccess.InstituteUserTypeID, InstituteUserTypeAccess.CanAddExam, 
                      InstituteUserTypeAccess.CanAddQuestion, InstituteUserTypeAccess.CanAddUser, InstituteUserTypeAccess.CanAddCource, 
                      InstituteUserTypeAccess.CanAddSubject, InstituteUserTypeAccess.CanAddAudio, InstituteUserTypeAccess.CanAddImage, 
                      InstituteUserTypeAccess.CanAddDocument, InstituteUserTypeAccess.CanAddVideo, InstituteUserTypeAccess.CanAddHomeWork, 
                      InstituteUserTypeAccess.CanAddEvent, InstituteUserTypeAccess.CanAddArticle, InstituteUserTypeAccess.ModifiedDate, 
                      InstituteUserInUserType.LoginUserID
FROM         LoginUser INNER JOIN
                      InstituteUserInUserType ON LoginUser.LoginUserID = InstituteUserInUserType.LoginUserID INNER JOIN
                      InstituteUserTypeAccess ON InstituteUserInUserType.InstituteUserTypeID = InstituteUserTypeAccess.InstituteUserTypeID
WHERE     (InstituteUserInUserType.LoginUserID = @LoginUserID)

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetTutorial]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetTutorial]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[GetTutorial]
@Keywork as varchar(1000),
@TutorialType as int
as
BEGIN
SELECT     Tutorial.TutorialID, Tutorial.TutorialTypeID, Tutorial.LoginUserID, Tutorial.Name, Tutorial.Description, Tutorial.ModifiedDate, Tutorial.FilePath, 
                      TutorialType.Name AS TutorialType, [User].FirstName, [User].LastName, [User].MiddleName, [User].PhotoPath
FROM         LoginUser INNER JOIN
                      Tutorial ON LoginUser.LoginUserID = Tutorial.LoginUserID INNER JOIN
                      TutorialType ON Tutorial.TutorialTypeID = TutorialType.TutorialTypeID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID
WHERE     (Tutorial.Name LIKE ''%'' + @Keywork + ''%'') AND (Tutorial.TutorialTypeID = CASE WHEN @TutorialType<>-1 THEN @TutorialType ELSE Tutorial.TutorialTypeID  END)

END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableEditGroup]    Script Date: 08/14/2010 17:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableEditGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableEditGroup](@ObjectID as varchar(100),@ObjectType as int,@InstituteUserTypeID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT      @EnableEdit=ShareGroup.EnableEdit
FROM         Share INNER JOIN
                      ShareGroup ON Share.ShareID = ShareGroup.ShareID
WHERE     (ShareGroup.InstituteUserTypeID = @InstituteUserTypeID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)




return @EnableEdit
END



' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableAddGroup]    Script Date: 08/14/2010 17:31:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableAddGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableAddGroup](@ObjectID as varchar(100),@ObjectType as int,@InstituteUserTypeID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT      @EnableEdit=ShareGroup.EnableAdd
FROM         Share INNER JOIN
                      ShareGroup ON Share.ShareID = ShareGroup.ShareID
WHERE     (ShareGroup.InstituteUserTypeID = @InstituteUserTypeID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)




return @EnableEdit
END



' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableViewGroup]    Script Date: 08/14/2010 17:31:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableViewGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableViewGroup](@ObjectID as varchar(100),@ObjectType as int,@InstituteUserTypeID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT      @EnableEdit=ShareGroup.EnableView
FROM         Share INNER JOIN
                      ShareGroup ON Share.ShareID = ShareGroup.ShareID
WHERE     (ShareGroup.InstituteUserTypeID = @InstituteUserTypeID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)




return @EnableEdit
END



' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableDeleteGroup]    Script Date: 08/14/2010 17:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableDeleteGroup]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableDeleteGroup](@ObjectID as varchar(100),@ObjectType as int,@InstituteUserTypeID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT      @EnableEdit=ShareGroup.EnableDelete
FROM         Share INNER JOIN
                      ShareGroup ON Share.ShareID = ShareGroup.ShareID
WHERE     (ShareGroup.InstituteUserTypeID = @InstituteUserTypeID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)




return @EnableEdit
END



' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableAdd]    Script Date: 08/14/2010 17:31:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableAdd]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableAdd](@ObjectID as varchar(100),@ObjectType as int,@LoginUserID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT     @EnableEdit=ShareUser.EnableAdd
FROM         Share INNER JOIN
                      ShareUser ON Share.ShareID = ShareUser.ShareID
WHERE     (ShareUser.LoginUserID = @LoginUserID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)



return @EnableEdit
END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableEdit]    Script Date: 08/14/2010 17:31:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableEdit]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableEdit](@ObjectID as varchar(100),@ObjectType as int,@LoginUserID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT     @EnableEdit=ShareUser.EnableEdit
FROM         Share INNER JOIN
                      ShareUser ON Share.ShareID = ShareUser.ShareID
WHERE     (ShareUser.LoginUserID = @LoginUserID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)



return @EnableEdit
END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableDelete]    Script Date: 08/14/2010 17:31:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableDelete]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableDelete](@ObjectID as varchar(100),@ObjectType as int,@LoginUserID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT     @EnableEdit=ShareUser.EnableDelete
FROM         Share INNER JOIN
                      ShareUser ON Share.ShareID = ShareUser.ShareID
WHERE     (ShareUser.LoginUserID = @LoginUserID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)



return @EnableEdit
END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[EnableView]    Script Date: 08/14/2010 17:31:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EnableView]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[EnableView](@ObjectID as varchar(100),@ObjectType as int,@LoginUserID as int)
RETURNS bit
as
Begin

declare @EnableEdit as bit
set @EnableEdit=0

SELECT     @EnableEdit=ShareUser.EnableView
FROM         Share INNER JOIN
                      ShareUser ON Share.ShareID = ShareUser.ShareID
WHERE     (ShareUser.LoginUserID = @LoginUserID) AND (Share.ObjectType = @ObjectType) AND (Share.ObjectID = @ObjectID)



return @EnableEdit
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Applications_CreateApplication]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Applications_CreateApplication]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Applications_CreateApplication]
    @ApplicationName      nvarchar(256),
    @ApplicationId        uniqueidentifier OUTPUT
AS
BEGIN
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName

    IF(@ApplicationId IS NULL)
    BEGIN
        DECLARE @TranStarted   bit
        SET @TranStarted = 0

        IF( @@TRANCOUNT = 0 )
        BEGIN
	        BEGIN TRANSACTION
	        SET @TranStarted = 1
        END
        ELSE
    	    SET @TranStarted = 0

        SELECT  @ApplicationId = ApplicationId
        FROM dbo.aspnet_Applications WITH (UPDLOCK, HOLDLOCK)
        WHERE LOWER(@ApplicationName) = LoweredApplicationName

        IF(@ApplicationId IS NULL)
        BEGIN
            SELECT  @ApplicationId = NEWID()
            INSERT  dbo.aspnet_Applications (ApplicationId, ApplicationName, LoweredApplicationName)
            VALUES  (@ApplicationId, @ApplicationName, LOWER(@ApplicationName))
        END


        IF( @TranStarted = 1 )
        BEGIN
            IF(@@ERROR = 0)
            BEGIN
	        SET @TranStarted = 0
	        COMMIT TRANSACTION
            END
            ELSE
            BEGIN
                SET @TranStarted = 0
                ROLLBACK TRANSACTION
            END
        END
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_AnyDataInTables]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_AnyDataInTables]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_AnyDataInTables]
    @TablesToCheck int
AS
BEGIN
    -- Check Membership table if (@TablesToCheck & 1) is set
    IF ((@TablesToCheck & 1) <> 0 AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_MembershipUsers'') AND (type = ''V''))))
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Membership))
        BEGIN
            SELECT N''aspnet_Membership''
            RETURN
        END
    END

    -- Check aspnet_Roles table if (@TablesToCheck & 2) is set
    IF ((@TablesToCheck & 2) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_Roles'') AND (type = ''V''))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 RoleId FROM dbo.aspnet_Roles))
        BEGIN
            SELECT N''aspnet_Roles''
            RETURN
        END
    END

    -- Check aspnet_Profile table if (@TablesToCheck & 4) is set
    IF ((@TablesToCheck & 4) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_Profiles'') AND (type = ''V''))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Profile))
        BEGIN
            SELECT N''aspnet_Profile''
            RETURN
        END
    END

    -- Check aspnet_PersonalizationPerUser table if (@TablesToCheck & 8) is set
    IF ((@TablesToCheck & 8) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_WebPartState_User'') AND (type = ''V''))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_PersonalizationPerUser))
        BEGIN
            SELECT N''aspnet_PersonalizationPerUser''
            RETURN
        END
    END

    -- Check aspnet_PersonalizationPerUser table if (@TablesToCheck & 16) is set
    IF ((@TablesToCheck & 16) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''aspnet_WebEvent_LogEvent'') AND (type = ''P''))) )
    BEGIN
        IF (EXISTS(SELECT TOP 1 * FROM dbo.aspnet_WebEvent_Events))
        BEGIN
            SELECT N''aspnet_WebEvent_Events''
            RETURN
        END
    END

    -- Check aspnet_Users table if (@TablesToCheck & 1,2,4 & 8) are all set
    IF ((@TablesToCheck & 1) <> 0 AND
        (@TablesToCheck & 2) <> 0 AND
        (@TablesToCheck & 4) <> 0 AND
        (@TablesToCheck & 8) <> 0 AND
        (@TablesToCheck & 32) <> 0 AND
        (@TablesToCheck & 128) <> 0 AND
        (@TablesToCheck & 256) <> 0 AND
        (@TablesToCheck & 512) <> 0 AND
        (@TablesToCheck & 1024) <> 0)
    BEGIN
        IF (EXISTS(SELECT TOP 1 UserId FROM dbo.aspnet_Users))
        BEGIN
            SELECT N''aspnet_Users''
            RETURN
        END
        IF (EXISTS(SELECT TOP 1 ApplicationId FROM dbo.aspnet_Applications))
        BEGIN
            SELECT N''aspnet_Applications''
            RETURN
        END
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_DeleteUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users_DeleteUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Users_DeleteUser]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @TablesToDeleteFrom int,
    @NumTablesDeletedFrom int OUTPUT
AS
BEGIN
    DECLARE @UserId               uniqueidentifier
    SELECT  @UserId               = NULL
    SELECT  @NumTablesDeletedFrom = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
	SET @TranStarted = 0

    DECLARE @ErrorCode   int
    DECLARE @RowCount    int

    SET @ErrorCode = 0
    SET @RowCount  = 0

    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a
    WHERE   u.LoweredUserName       = LOWER(@UserName)
        AND u.ApplicationId         = a.ApplicationId
        AND LOWER(@ApplicationName) = a.LoweredApplicationName

    IF (@UserId IS NULL)
    BEGIN
        GOTO Cleanup
    END

    -- Delete from Membership table if (@TablesToDeleteFrom & 1) is set
    IF ((@TablesToDeleteFrom & 1) <> 0 AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_MembershipUsers'') AND (type = ''V''))))
    BEGIN
        DELETE FROM dbo.aspnet_Membership WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
               @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_UsersInRoles table if (@TablesToDeleteFrom & 2) is set
    IF ((@TablesToDeleteFrom & 2) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_UsersInRoles'') AND (type = ''V''))) )
    BEGIN
        DELETE FROM dbo.aspnet_UsersInRoles WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_Profile table if (@TablesToDeleteFrom & 4) is set
    IF ((@TablesToDeleteFrom & 4) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_Profiles'') AND (type = ''V''))) )
    BEGIN
        DELETE FROM dbo.aspnet_Profile WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_PersonalizationPerUser table if (@TablesToDeleteFrom & 8) is set
    IF ((@TablesToDeleteFrom & 8) <> 0  AND
        (EXISTS (SELECT name FROM sysobjects WHERE (name = N''vw_aspnet_WebPartState_User'') AND (type = ''V''))) )
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationPerUser WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    -- Delete from aspnet_Users table if (@TablesToDeleteFrom & 1,2,4 & 8) are all set
    IF ((@TablesToDeleteFrom & 1) <> 0 AND
        (@TablesToDeleteFrom & 2) <> 0 AND
        (@TablesToDeleteFrom & 4) <> 0 AND
        (@TablesToDeleteFrom & 8) <> 0 AND
        (EXISTS (SELECT UserId FROM dbo.aspnet_Users WHERE @UserId = UserId)))
    BEGIN
        DELETE FROM dbo.aspnet_Users WHERE @UserId = UserId

        SELECT @ErrorCode = @@ERROR,
                @RowCount = @@ROWCOUNT

        IF( @ErrorCode <> 0 )
            GOTO Cleanup

        IF (@RowCount <> 0)
            SELECT  @NumTablesDeletedFrom = @NumTablesDeletedFrom + 1
    END

    IF( @TranStarted = 1 )
    BEGIN
	    SET @TranStarted = 0
	    COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:
    SET @NumTablesDeletedFrom = 0

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
	    ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_Applications]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Applications]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_Applications]
  AS SELECT [dbo].[aspnet_Applications].[ApplicationName], [dbo].[aspnet_Applications].[LoweredApplicationName], [dbo].[aspnet_Applications].[ApplicationId], [dbo].[aspnet_Applications].[Description]
  FROM [dbo].[aspnet_Applications]
  '
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByName]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByName]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @CurrentTimeUtc       datetime,
    @UpdateLastActivity   bit = 0
AS
BEGIN
    DECLARE @UserId uniqueidentifier

    IF (@UpdateLastActivity = 1)
    BEGIN
        -- select user ID from aspnet_users table
        SELECT TOP 1 @UserId = u.UserId
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE    LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                LOWER(@UserName) = u.LoweredUserName AND u.UserId = m.UserId

        IF (@@ROWCOUNT = 0) -- Username not found
            RETURN -1

        UPDATE   dbo.aspnet_Users
        SET      LastActivityDate = @CurrentTimeUtc
        WHERE    @UserId = UserId

        SELECT m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
                m.CreateDate, m.LastLoginDate, u.LastActivityDate, m.LastPasswordChangedDate,
                u.UserId, m.IsLockedOut, m.LastLockoutDate
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE  @UserId = u.UserId AND u.UserId = m.UserId 
    END
    ELSE
    BEGIN
        SELECT TOP 1 m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
                m.CreateDate, m.LastLoginDate, u.LastActivityDate, m.LastPasswordChangedDate,
                u.UserId, m.IsLockedOut,m.LastLockoutDate
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE    LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                LOWER(@UserName) = u.LoweredUserName AND u.UserId = m.UserId

        IF (@@ROWCOUNT = 0) -- Username not found
            RETURN -1
    END

    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPasswordWithFormat]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetPasswordWithFormat]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetPasswordWithFormat]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @UpdateLastLoginActivityDate    bit,
    @CurrentTimeUtc                 datetime
AS
BEGIN
    DECLARE @IsLockedOut                        bit
    DECLARE @UserId                             uniqueidentifier
    DECLARE @Password                           nvarchar(128)
    DECLARE @PasswordSalt                       nvarchar(128)
    DECLARE @PasswordFormat                     int
    DECLARE @FailedPasswordAttemptCount         int
    DECLARE @FailedPasswordAnswerAttemptCount   int
    DECLARE @IsApproved                         bit
    DECLARE @LastActivityDate                   datetime
    DECLARE @LastLoginDate                      datetime

    SELECT  @UserId          = NULL

    SELECT  @UserId = u.UserId, @IsLockedOut = m.IsLockedOut, @Password=Password, @PasswordFormat=PasswordFormat,
            @PasswordSalt=PasswordSalt, @FailedPasswordAttemptCount=FailedPasswordAttemptCount,
		    @FailedPasswordAnswerAttemptCount=FailedPasswordAnswerAttemptCount, @IsApproved=IsApproved,
            @LastActivityDate = LastActivityDate, @LastLoginDate = LastLoginDate
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF (@UserId IS NULL)
        RETURN 1

    IF (@IsLockedOut = 1)
        RETURN 99

    SELECT   @Password, @PasswordFormat, @PasswordSalt, @FailedPasswordAttemptCount,
             @FailedPasswordAnswerAttemptCount, @IsApproved, @LastLoginDate, @LastActivityDate

    IF (@UpdateLastLoginActivityDate = 1 AND @IsApproved = 1)
    BEGIN
        UPDATE  dbo.aspnet_Membership
        SET     LastLoginDate = @CurrentTimeUtc
        WHERE   UserId = @UserId

        UPDATE  dbo.aspnet_Users
        SET     LastActivityDate = @CurrentTimeUtc
        WHERE   @UserId = UserId
    END


    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByEmail]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByEmail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByEmail]
    @ApplicationName  nvarchar(256),
    @Email            nvarchar(256)
AS
BEGIN
    IF( @Email IS NULL )
        SELECT  u.UserName
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                u.UserId = m.UserId AND
                m.LoweredEmail IS NULL
    ELSE
        SELECT  u.UserName
        FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
                u.ApplicationId = a.ApplicationId    AND
                u.UserId = m.UserId AND
                LOWER(@Email) = m.LoweredEmail

    IF (@@rowcount = 0)
        RETURN(1)
    RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UpdateUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_UpdateUser]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @Email                nvarchar(256),
    @Comment              ntext,
    @IsApproved           bit,
    @LastLoginDate        datetime,
    @LastActivityDate     datetime,
    @UniqueEmail          int,
    @CurrentTimeUtc       datetime
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId, @ApplicationId = a.ApplicationId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF (@UserId IS NULL)
        RETURN(1)

    IF (@UniqueEmail = 1)
    BEGIN
        IF (EXISTS (SELECT *
                    FROM  dbo.aspnet_Membership WITH (UPDLOCK, HOLDLOCK)
                    WHERE ApplicationId = @ApplicationId  AND @UserId <> UserId AND LoweredEmail = LOWER(@Email)))
        BEGIN
            RETURN(7)
        END
    END

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
	SET @TranStarted = 0

    UPDATE dbo.aspnet_Users WITH (ROWLOCK)
    SET
         LastActivityDate = @LastActivityDate
    WHERE
       @UserId = UserId

    IF( @@ERROR <> 0 )
        GOTO Cleanup

    UPDATE dbo.aspnet_Membership WITH (ROWLOCK)
    SET
         Email            = @Email,
         LoweredEmail     = LOWER(@Email),
         Comment          = @Comment,
         IsApproved       = @IsApproved,
         LastLoginDate    = @LastLoginDate
    WHERE
       @UserId = UserId

    IF( @@ERROR <> 0 )
        GOTO Cleanup

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN -1
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UnlockUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UnlockUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_UnlockUser]
    @ApplicationName                         nvarchar(256),
    @UserName                                nvarchar(256)
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF ( @UserId IS NULL )
        RETURN 1

    UPDATE dbo.aspnet_Membership
    SET IsLockedOut = 0,
        FailedPasswordAttemptCount = 0,
        FailedPasswordAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 ),
        FailedPasswordAnswerAttemptCount = 0,
        FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 ),
        LastLockoutDate = CONVERT( datetime, ''17540101'', 112 )
    WHERE @UserId = UserId

    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer]
    @ApplicationName       nvarchar(256),
    @UserName              nvarchar(256),
    @NewPasswordQuestion   nvarchar(256),
    @NewPasswordAnswer     nvarchar(128)
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Membership m, dbo.aspnet_Users u, dbo.aspnet_Applications a
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId
    IF (@UserId IS NULL)
    BEGIN
        RETURN(1)
    END

    UPDATE dbo.aspnet_Membership
    SET    PasswordQuestion = @NewPasswordQuestion, PasswordAnswer = @NewPasswordAnswer
    WHERE  UserId=@UserId
    RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_UpdateUserInfo]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_UpdateUserInfo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_UpdateUserInfo]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @IsPasswordCorrect              bit,
    @UpdateLastLoginActivityDate    bit,
    @MaxInvalidPasswordAttempts     int,
    @PasswordAttemptWindow          int,
    @CurrentTimeUtc                 datetime,
    @LastLoginDate                  datetime,
    @LastActivityDate               datetime
AS
BEGIN
    DECLARE @UserId                                 uniqueidentifier
    DECLARE @IsApproved                             bit
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId,
            @IsApproved = m.IsApproved,
            @IsLockedOut = m.IsLockedOut,
            @LastLockoutDate = m.LastLockoutDate,
            @FailedPasswordAttemptCount = m.FailedPasswordAttemptCount,
            @FailedPasswordAttemptWindowStart = m.FailedPasswordAttemptWindowStart,
            @FailedPasswordAnswerAttemptCount = m.FailedPasswordAnswerAttemptCount,
            @FailedPasswordAnswerAttemptWindowStart = m.FailedPasswordAnswerAttemptWindowStart
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m WITH ( UPDLOCK )
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF ( @@rowcount = 0 )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    IF( @IsLockedOut = 1 )
    BEGIN
        GOTO Cleanup
    END

    IF( @IsPasswordCorrect = 0 )
    BEGIN
        IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAttemptWindowStart ) )
        BEGIN
            SET @FailedPasswordAttemptWindowStart = @CurrentTimeUtc
            SET @FailedPasswordAttemptCount = 1
        END
        ELSE
        BEGIN
            SET @FailedPasswordAttemptWindowStart = @CurrentTimeUtc
            SET @FailedPasswordAttemptCount = @FailedPasswordAttemptCount + 1
        END

        BEGIN
            IF( @FailedPasswordAttemptCount >= @MaxInvalidPasswordAttempts )
            BEGIN
                SET @IsLockedOut = 1
                SET @LastLockoutDate = @CurrentTimeUtc
            END
        END
    END
    ELSE
    BEGIN
        IF( @FailedPasswordAttemptCount > 0 OR @FailedPasswordAnswerAttemptCount > 0 )
        BEGIN
            SET @FailedPasswordAttemptCount = 0
            SET @FailedPasswordAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )
            SET @FailedPasswordAnswerAttemptCount = 0
            SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )
            SET @LastLockoutDate = CONVERT( datetime, ''17540101'', 112 )
        END
    END

    IF( @UpdateLastLoginActivityDate = 1 )
    BEGIN
        UPDATE  dbo.aspnet_Users
        SET     LastActivityDate = @LastActivityDate
        WHERE   @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END

        UPDATE  dbo.aspnet_Membership
        SET     LastLoginDate = @LastLoginDate
        WHERE   UserId = @UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END


    UPDATE dbo.aspnet_Membership
    SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
        FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
        FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
        FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
        FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
    WHERE @UserId = UserId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetPassword]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetPassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetPassword]
    @ApplicationName                nvarchar(256),
    @UserName                       nvarchar(256),
    @MaxInvalidPasswordAttempts     int,
    @PasswordAttemptWindow          int,
    @CurrentTimeUtc                 datetime,
    @PasswordAnswer                 nvarchar(128) = NULL
AS
BEGIN
    DECLARE @UserId                                 uniqueidentifier
    DECLARE @PasswordFormat                         int
    DECLARE @Password                               nvarchar(128)
    DECLARE @passAns                                nvarchar(128)
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId,
            @Password = m.Password,
            @passAns = m.PasswordAnswer,
            @PasswordFormat = m.PasswordFormat,
            @IsLockedOut = m.IsLockedOut,
            @LastLockoutDate = m.LastLockoutDate,
            @FailedPasswordAttemptCount = m.FailedPasswordAttemptCount,
            @FailedPasswordAttemptWindowStart = m.FailedPasswordAttemptWindowStart,
            @FailedPasswordAnswerAttemptCount = m.FailedPasswordAnswerAttemptCount,
            @FailedPasswordAnswerAttemptWindowStart = m.FailedPasswordAnswerAttemptWindowStart
    FROM    dbo.aspnet_Applications a, dbo.aspnet_Users u, dbo.aspnet_Membership m WITH ( UPDLOCK )
    WHERE   LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.ApplicationId = a.ApplicationId    AND
            u.UserId = m.UserId AND
            LOWER(@UserName) = u.LoweredUserName

    IF ( @@rowcount = 0 )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    IF( @IsLockedOut = 1 )
    BEGIN
        SET @ErrorCode = 99
        GOTO Cleanup
    END

    IF ( NOT( @PasswordAnswer IS NULL ) )
    BEGIN
        IF( ( @passAns IS NULL ) OR ( LOWER( @passAns ) <> LOWER( @PasswordAnswer ) ) )
        BEGIN
            IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAnswerAttemptWindowStart ) )
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = 1
            END
            ELSE
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount + 1
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
            END

            BEGIN
                IF( @FailedPasswordAnswerAttemptCount >= @MaxInvalidPasswordAttempts )
                BEGIN
                    SET @IsLockedOut = 1
                    SET @LastLockoutDate = @CurrentTimeUtc
                END
            END

            SET @ErrorCode = 3
        END
        ELSE
        BEGIN
            IF( @FailedPasswordAnswerAttemptCount > 0 )
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = 0
                SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )
            END
        END

        UPDATE dbo.aspnet_Membership
        SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
            FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
            FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
            FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
            FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
        WHERE @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    IF( @ErrorCode = 0 )
        SELECT @Password, @PasswordFormat

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_SetPassword]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_SetPassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_SetPassword]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @NewPassword      nvarchar(128),
    @PasswordSalt     nvarchar(128),
    @CurrentTimeUtc   datetime,
    @PasswordFormat   int = 0
AS
BEGIN
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF (@UserId IS NULL)
        RETURN(1)

    UPDATE dbo.aspnet_Membership
    SET Password = @NewPassword, PasswordFormat = @PasswordFormat, PasswordSalt = @PasswordSalt,
        LastPasswordChangedDate = @CurrentTimeUtc
    WHERE @UserId = UserId
    RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_ResetPassword]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_ResetPassword]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_ResetPassword]
    @ApplicationName             nvarchar(256),
    @UserName                    nvarchar(256),
    @NewPassword                 nvarchar(128),
    @MaxInvalidPasswordAttempts  int,
    @PasswordAttemptWindow       int,
    @PasswordSalt                nvarchar(128),
    @CurrentTimeUtc              datetime,
    @PasswordFormat              int = 0,
    @PasswordAnswer              nvarchar(128) = NULL
AS
BEGIN
    DECLARE @IsLockedOut                            bit
    DECLARE @LastLockoutDate                        datetime
    DECLARE @FailedPasswordAttemptCount             int
    DECLARE @FailedPasswordAttemptWindowStart       datetime
    DECLARE @FailedPasswordAnswerAttemptCount       int
    DECLARE @FailedPasswordAnswerAttemptWindowStart datetime

    DECLARE @UserId                                 uniqueidentifier
    SET     @UserId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    SELECT  @UserId = u.UserId
    FROM    dbo.aspnet_Users u, dbo.aspnet_Applications a, dbo.aspnet_Membership m
    WHERE   LoweredUserName = LOWER(@UserName) AND
            u.ApplicationId = a.ApplicationId  AND
            LOWER(@ApplicationName) = a.LoweredApplicationName AND
            u.UserId = m.UserId

    IF ( @UserId IS NULL )
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    SELECT @IsLockedOut = IsLockedOut,
           @LastLockoutDate = LastLockoutDate,
           @FailedPasswordAttemptCount = FailedPasswordAttemptCount,
           @FailedPasswordAttemptWindowStart = FailedPasswordAttemptWindowStart,
           @FailedPasswordAnswerAttemptCount = FailedPasswordAnswerAttemptCount,
           @FailedPasswordAnswerAttemptWindowStart = FailedPasswordAnswerAttemptWindowStart
    FROM dbo.aspnet_Membership WITH ( UPDLOCK )
    WHERE @UserId = UserId

    IF( @IsLockedOut = 1 )
    BEGIN
        SET @ErrorCode = 99
        GOTO Cleanup
    END

    UPDATE dbo.aspnet_Membership
    SET    Password = @NewPassword,
           LastPasswordChangedDate = @CurrentTimeUtc,
           PasswordFormat = @PasswordFormat,
           PasswordSalt = @PasswordSalt
    WHERE  @UserId = UserId AND
           ( ( @PasswordAnswer IS NULL ) OR ( LOWER( PasswordAnswer ) = LOWER( @PasswordAnswer ) ) )

    IF ( @@ROWCOUNT = 0 )
        BEGIN
            IF( @CurrentTimeUtc > DATEADD( minute, @PasswordAttemptWindow, @FailedPasswordAnswerAttemptWindowStart ) )
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = 1
            END
            ELSE
            BEGIN
                SET @FailedPasswordAnswerAttemptWindowStart = @CurrentTimeUtc
                SET @FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount + 1
            END

            BEGIN
                IF( @FailedPasswordAnswerAttemptCount >= @MaxInvalidPasswordAttempts )
                BEGIN
                    SET @IsLockedOut = 1
                    SET @LastLockoutDate = @CurrentTimeUtc
                END
            END

            SET @ErrorCode = 3
        END
    ELSE
        BEGIN
            IF( @FailedPasswordAnswerAttemptCount > 0 )
            BEGIN
                SET @FailedPasswordAnswerAttemptCount = 0
                SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )
            END
        END

    IF( NOT ( @PasswordAnswer IS NULL ) )
    BEGIN
        UPDATE dbo.aspnet_Membership
        SET IsLockedOut = @IsLockedOut, LastLockoutDate = @LastLockoutDate,
            FailedPasswordAttemptCount = @FailedPasswordAttemptCount,
            FailedPasswordAttemptWindowStart = @FailedPasswordAttemptWindowStart,
            FailedPasswordAnswerAttemptCount = @FailedPasswordAnswerAttemptCount,
            FailedPasswordAnswerAttemptWindowStart = @FailedPasswordAnswerAttemptWindowStart
        WHERE @UserId = UserId

        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    IF( @TranStarted = 1 )
    BEGIN
	SET @TranStarted = 0
	COMMIT TRANSACTION
    END

    RETURN @ErrorCode

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Personalization_GetApplicationId]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Personalization_GetApplicationId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Personalization_GetApplicationId] (
    @ApplicationName NVARCHAR(256),
    @ApplicationId UNIQUEIDENTIFIER OUT)
AS
BEGIN
    SELECT @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_FindUsersInRole]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_FindUsersInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_FindUsersInRole]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256),
    @UserNameToMatch  nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
     DECLARE @RoleId uniqueidentifier
     SELECT  @RoleId = NULL

     SELECT  @RoleId = RoleId
     FROM    dbo.aspnet_Roles
     WHERE   LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId

     IF (@RoleId IS NULL)
         RETURN(1)

    SELECT u.UserName
    FROM   dbo.aspnet_Users u, dbo.aspnet_UsersInRoles ur
    WHERE  u.UserId = ur.UserId AND @RoleId = ur.RoleId AND u.ApplicationId = @ApplicationId AND LoweredUserName LIKE LOWER(@UserNameToMatch)
    ORDER BY u.UserName
    RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_GetAllRoles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_GetAllRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Roles_GetAllRoles] (
    @ApplicationName           nvarchar(256))
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN
    SELECT RoleName
    FROM   dbo.aspnet_Roles WHERE ApplicationId = @ApplicationId
    ORDER BY RoleName
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteInactiveProfiles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_DeleteInactiveProfiles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_DeleteInactiveProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @InactiveSinceDate      datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
    BEGIN
        SELECT  0
        RETURN
    END

    DELETE
    FROM    dbo.aspnet_Profile
    WHERE   UserId IN
            (   SELECT  UserId
                FROM    dbo.aspnet_Users u
                WHERE   ApplicationId = @ApplicationId
                        AND (LastActivityDate <= @InactiveSinceDate)
                        AND (
                                (@ProfileAuthOptions = 2)
                             OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                             OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
                            )
            )

    SELECT  @@ROWCOUNT
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @InactiveSinceDate      datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
    BEGIN
        SELECT 0
        RETURN
    END

    SELECT  COUNT(*)
    FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p
    WHERE   ApplicationId = @ApplicationId
        AND u.UserId = p.UserId
        AND (LastActivityDate <= @InactiveSinceDate)
        AND (
                (@ProfileAuthOptions = 2)
                OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
            )
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProfiles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetProfiles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_GetProfiles]
    @ApplicationName        nvarchar(256),
    @ProfileAuthOptions     int,
    @PageIndex              int,
    @PageSize               int,
    @UserNameToMatch        nvarchar(256) = NULL,
    @InactiveSinceDate      datetime      = NULL
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
        SELECT  u.UserId
        FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p
        WHERE   ApplicationId = @ApplicationId
            AND u.UserId = p.UserId
            AND (@InactiveSinceDate IS NULL OR LastActivityDate <= @InactiveSinceDate)
            AND (     (@ProfileAuthOptions = 2)
                   OR (@ProfileAuthOptions = 0 AND IsAnonymous = 1)
                   OR (@ProfileAuthOptions = 1 AND IsAnonymous = 0)
                 )
            AND (@UserNameToMatch IS NULL OR LoweredUserName LIKE LOWER(@UserNameToMatch))
        ORDER BY UserName

    SELECT  u.UserName, u.IsAnonymous, u.LastActivityDate, p.LastUpdatedDate,
            DATALENGTH(p.PropertyNames) + DATALENGTH(p.PropertyValuesString) + DATALENGTH(p.PropertyValuesBinary)
    FROM    dbo.aspnet_Users u, dbo.aspnet_Profile p, #PageIndexForUsers i
    WHERE   u.UserId = p.UserId AND p.UserId = i.UserId AND i.IndexId >= @PageLowerBound AND i.IndexId <= @PageUpperBound

    SELECT COUNT(*)
    FROM   #PageIndexForUsers

    DROP TABLE #PageIndexForUsers
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_GetProperties]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_GetProperties]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_GetProperties]
    @ApplicationName      nvarchar(256),
    @UserName             nvarchar(256),
    @CurrentTimeUtc       datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN

    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL

    SELECT @UserId = UserId
    FROM   dbo.aspnet_Users
    WHERE  ApplicationId = @ApplicationId AND LoweredUserName = LOWER(@UserName)

    IF (@UserId IS NULL)
        RETURN
    SELECT TOP 1 PropertyNames, PropertyValuesString, PropertyValuesBinary
    FROM         dbo.aspnet_Profile
    WHERE        UserId = @UserId

    IF (@@ROWCOUNT > 0)
    BEGIN
        UPDATE dbo.aspnet_Users
        SET    LastActivityDate=@CurrentTimeUtc
        WHERE  UserId = @UserId
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetAllUsers]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetAllUsers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetAllUsers]
    @ApplicationName       nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0


    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
    SELECT u.UserId
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u
    WHERE  u.ApplicationId = @ApplicationId AND u.UserId = m.UserId
    ORDER BY u.UserName

    SELECT @TotalRecords = @@ROWCOUNT

    SELECT u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY u.UserName
    RETURN @TotalRecords
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetNumberOfUsersOnline]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetNumberOfUsersOnline]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetNumberOfUsersOnline]
    @ApplicationName            nvarchar(256),
    @MinutesSinceLastInActive   int,
    @CurrentTimeUtc             datetime
AS
BEGIN
    DECLARE @DateActive datetime
    SELECT  @DateActive = DATEADD(minute,  -(@MinutesSinceLastInActive), @CurrentTimeUtc)

    DECLARE @NumOnline int
    SELECT  @NumOnline = COUNT(*)
    FROM    dbo.aspnet_Users u(NOLOCK),
            dbo.aspnet_Applications a(NOLOCK),
            dbo.aspnet_Membership m(NOLOCK)
    WHERE   u.ApplicationId = a.ApplicationId                  AND
            LastActivityDate > @DateActive                     AND
            a.LoweredApplicationName = LOWER(@ApplicationName) AND
            u.UserId = m.UserId
    RETURN(@NumOnline)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByName]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_FindUsersByName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_FindUsersByName]
    @ApplicationName       nvarchar(256),
    @UserNameToMatch       nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    INSERT INTO #PageIndexForUsers (UserId)
        SELECT u.UserId
        FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
        WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND u.LoweredUserName LIKE LOWER(@UserNameToMatch)
        ORDER BY u.UserName


    SELECT  u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY u.UserName

    SELECT  @TotalRecords = COUNT(*)
    FROM    #PageIndexForUsers
    RETURN @TotalRecords
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_FindUsersByEmail]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_FindUsersByEmail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_FindUsersByEmail]
    @ApplicationName       nvarchar(256),
    @EmailToMatch          nvarchar(256),
    @PageIndex             int,
    @PageSize              int
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM dbo.aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN 0

    -- Set the page bounds
    DECLARE @PageLowerBound int
    DECLARE @PageUpperBound int
    DECLARE @TotalRecords   int
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table TO store the select results
    CREATE TABLE #PageIndexForUsers
    (
        IndexId int IDENTITY (0, 1) NOT NULL,
        UserId uniqueidentifier
    )

    -- Insert into our temp table
    IF( @EmailToMatch IS NULL )
        INSERT INTO #PageIndexForUsers (UserId)
            SELECT u.UserId
            FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
            WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND m.Email IS NULL
            ORDER BY m.LoweredEmail
    ELSE
        INSERT INTO #PageIndexForUsers (UserId)
            SELECT u.UserId
            FROM   dbo.aspnet_Users u, dbo.aspnet_Membership m
            WHERE  u.ApplicationId = @ApplicationId AND m.UserId = u.UserId AND m.LoweredEmail LIKE LOWER(@EmailToMatch)
            ORDER BY m.LoweredEmail

    SELECT  u.UserName, m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate,
            m.LastLoginDate,
            u.LastActivityDate,
            m.LastPasswordChangedDate,
            u.UserId, m.IsLockedOut,
            m.LastLockoutDate
    FROM   dbo.aspnet_Membership m, dbo.aspnet_Users u, #PageIndexForUsers p
    WHERE  u.UserId = p.UserId AND u.UserId = m.UserId AND
           p.IndexId >= @PageLowerBound AND p.IndexId <= @PageUpperBound
    ORDER BY m.LoweredEmail

    SELECT  @TotalRecords = COUNT(*)
    FROM    #PageIndexForUsers
    RETURN @TotalRecords
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_RoleExists]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_RoleExists]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Roles_RoleExists]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(0)
    IF (EXISTS (SELECT RoleName FROM dbo.aspnet_Roles WHERE LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId ))
        RETURN(1)
    ELSE
        RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_DeleteRole]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_DeleteRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Roles_DeleteRole]
    @ApplicationName            nvarchar(256),
    @RoleName                   nvarchar(256),
    @DeleteOnlyIfRoleIsEmpty    bit
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
        SET @TranStarted = 0

    DECLARE @RoleId   uniqueidentifier
    SELECT  @RoleId = NULL
    SELECT  @RoleId = RoleId FROM dbo.aspnet_Roles WHERE LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId

    IF (@RoleId IS NULL)
    BEGIN
        SELECT @ErrorCode = 1
        GOTO Cleanup
    END
    IF (@DeleteOnlyIfRoleIsEmpty <> 0)
    BEGIN
        IF (EXISTS (SELECT RoleId FROM dbo.aspnet_UsersInRoles  WHERE @RoleId = RoleId))
        BEGIN
            SELECT @ErrorCode = 2
            GOTO Cleanup
        END
    END


    DELETE FROM dbo.aspnet_UsersInRoles  WHERE @RoleId = RoleId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    DELETE FROM dbo.aspnet_Roles WHERE @RoleId = RoleId  AND ApplicationId = @ApplicationId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        COMMIT TRANSACTION
    END

    RETURN(0)

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetRolesForUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_GetRolesForUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_GetRolesForUser]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL

    SELECT  @UserId = UserId
    FROM    dbo.aspnet_Users
    WHERE   LoweredUserName = LOWER(@UserName) AND ApplicationId = @ApplicationId

    IF (@UserId IS NULL)
        RETURN(1)

    SELECT r.RoleName
    FROM   dbo.aspnet_Roles r, dbo.aspnet_UsersInRoles ur
    WHERE  r.RoleId = ur.RoleId AND r.ApplicationId = @ApplicationId AND ur.UserId = @UserId
    ORDER BY r.RoleName
    RETURN (0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_IsUserInRole]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_IsUserInRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_IsUserInRole]
    @ApplicationName  nvarchar(256),
    @UserName         nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(2)
    DECLARE @UserId uniqueidentifier
    SELECT  @UserId = NULL
    DECLARE @RoleId uniqueidentifier
    SELECT  @RoleId = NULL

    SELECT  @UserId = UserId
    FROM    dbo.aspnet_Users
    WHERE   LoweredUserName = LOWER(@UserName) AND ApplicationId = @ApplicationId

    IF (@UserId IS NULL)
        RETURN(2)

    SELECT  @RoleId = RoleId
    FROM    dbo.aspnet_Roles
    WHERE   LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId

    IF (@RoleId IS NULL)
        RETURN(3)

    IF (EXISTS( SELECT * FROM dbo.aspnet_UsersInRoles WHERE  UserId = @UserId AND RoleId = @RoleId))
        RETURN(1)
    ELSE
        RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_AddUsersToRoles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_AddUsersToRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_AddUsersToRoles]
	@ApplicationName  nvarchar(256),
	@UserNames		  nvarchar(4000),
	@RoleNames		  nvarchar(4000),
	@CurrentTimeUtc   datetime
AS
BEGIN
	DECLARE @AppId uniqueidentifier
	SELECT  @AppId = NULL
	SELECT  @AppId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
	IF (@AppId IS NULL)
		RETURN(2)
	DECLARE @TranStarted   bit
	SET @TranStarted = 0

	IF( @@TRANCOUNT = 0 )
	BEGIN
		BEGIN TRANSACTION
		SET @TranStarted = 1
	END

	DECLARE @tbNames	table(Name nvarchar(256) NOT NULL PRIMARY KEY)
	DECLARE @tbRoles	table(RoleId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @tbUsers	table(UserId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @Num		int
	DECLARE @Pos		int
	DECLARE @NextPos	int
	DECLARE @Name		nvarchar(256)

	SET @Num = 0
	SET @Pos = 1
	WHILE(@Pos <= LEN(@RoleNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N'','', @RoleNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@RoleNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@RoleNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbRoles
	  SELECT RoleId
	  FROM   dbo.aspnet_Roles ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredRoleName AND ar.ApplicationId = @AppId

	IF (@@ROWCOUNT <> @Num)
	BEGIN
		SELECT TOP 1 Name
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT ar.LoweredRoleName FROM dbo.aspnet_Roles ar,  @tbRoles r WHERE r.RoleId = ar.RoleId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(2)
	END

	DELETE FROM @tbNames WHERE 1=1
	SET @Num = 0
	SET @Pos = 1

	WHILE(@Pos <= LEN(@UserNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N'','', @UserNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@UserNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@UserNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbUsers
	  SELECT UserId
	  FROM   dbo.aspnet_Users ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredUserName AND ar.ApplicationId = @AppId

	IF (@@ROWCOUNT <> @Num)
	BEGIN
		DELETE FROM @tbNames
		WHERE LOWER(Name) IN (SELECT LoweredUserName FROM dbo.aspnet_Users au,  @tbUsers u WHERE au.UserId = u.UserId)

		INSERT dbo.aspnet_Users (ApplicationId, UserId, UserName, LoweredUserName, IsAnonymous, LastActivityDate)
		  SELECT @AppId, NEWID(), Name, LOWER(Name), 0, @CurrentTimeUtc
		  FROM   @tbNames

		INSERT INTO @tbUsers
		  SELECT  UserId
		  FROM	dbo.aspnet_Users au, @tbNames t
		  WHERE   LOWER(t.Name) = au.LoweredUserName AND au.ApplicationId = @AppId
	END

	IF (EXISTS (SELECT * FROM dbo.aspnet_UsersInRoles ur, @tbUsers tu, @tbRoles tr WHERE tu.UserId = ur.UserId AND tr.RoleId = ur.RoleId))
	BEGIN
		SELECT TOP 1 UserName, RoleName
		FROM		 dbo.aspnet_UsersInRoles ur, @tbUsers tu, @tbRoles tr, aspnet_Users u, aspnet_Roles r
		WHERE		u.UserId = tu.UserId AND r.RoleId = tr.RoleId AND tu.UserId = ur.UserId AND tr.RoleId = ur.RoleId

		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(3)
	END

	INSERT INTO dbo.aspnet_UsersInRoles (UserId, RoleId)
	SELECT UserId, RoleId
	FROM @tbUsers, @tbRoles

	IF( @TranStarted = 1 )
		COMMIT TRANSACTION
	RETURN(0)
END                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles]
	@ApplicationName  nvarchar(256),
	@UserNames		  nvarchar(4000),
	@RoleNames		  nvarchar(4000)
AS
BEGIN
	DECLARE @AppId uniqueidentifier
	SELECT  @AppId = NULL
	SELECT  @AppId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
	IF (@AppId IS NULL)
		RETURN(2)


	DECLARE @TranStarted   bit
	SET @TranStarted = 0

	IF( @@TRANCOUNT = 0 )
	BEGIN
		BEGIN TRANSACTION
		SET @TranStarted = 1
	END

	DECLARE @tbNames  table(Name nvarchar(256) NOT NULL PRIMARY KEY)
	DECLARE @tbRoles  table(RoleId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @tbUsers  table(UserId uniqueidentifier NOT NULL PRIMARY KEY)
	DECLARE @Num	  int
	DECLARE @Pos	  int
	DECLARE @NextPos  int
	DECLARE @Name	  nvarchar(256)
	DECLARE @CountAll int
	DECLARE @CountU	  int
	DECLARE @CountR	  int


	SET @Num = 0
	SET @Pos = 1
	WHILE(@Pos <= LEN(@RoleNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N'','', @RoleNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@RoleNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@RoleNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbRoles
	  SELECT RoleId
	  FROM   dbo.aspnet_Roles ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredRoleName AND ar.ApplicationId = @AppId
	SELECT @CountR = @@ROWCOUNT

	IF (@CountR <> @Num)
	BEGIN
		SELECT TOP 1 N'''', Name
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT ar.LoweredRoleName FROM dbo.aspnet_Roles ar,  @tbRoles r WHERE r.RoleId = ar.RoleId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(2)
	END


	DELETE FROM @tbNames WHERE 1=1
	SET @Num = 0
	SET @Pos = 1


	WHILE(@Pos <= LEN(@UserNames))
	BEGIN
		SELECT @NextPos = CHARINDEX(N'','', @UserNames,  @Pos)
		IF (@NextPos = 0 OR @NextPos IS NULL)
			SELECT @NextPos = LEN(@UserNames) + 1
		SELECT @Name = RTRIM(LTRIM(SUBSTRING(@UserNames, @Pos, @NextPos - @Pos)))
		SELECT @Pos = @NextPos+1

		INSERT INTO @tbNames VALUES (@Name)
		SET @Num = @Num + 1
	END

	INSERT INTO @tbUsers
	  SELECT UserId
	  FROM   dbo.aspnet_Users ar, @tbNames t
	  WHERE  LOWER(t.Name) = ar.LoweredUserName AND ar.ApplicationId = @AppId

	SELECT @CountU = @@ROWCOUNT
	IF (@CountU <> @Num)
	BEGIN
		SELECT TOP 1 Name, N''''
		FROM   @tbNames
		WHERE  LOWER(Name) NOT IN (SELECT au.LoweredUserName FROM dbo.aspnet_Users au,  @tbUsers u WHERE u.UserId = au.UserId)

		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(1)
	END

	SELECT  @CountAll = COUNT(*)
	FROM	dbo.aspnet_UsersInRoles ur, @tbUsers u, @tbRoles r
	WHERE   ur.UserId = u.UserId AND ur.RoleId = r.RoleId

	IF (@CountAll <> @CountU * @CountR)
	BEGIN
		SELECT TOP 1 UserName, RoleName
		FROM		 @tbUsers tu, @tbRoles tr, dbo.aspnet_Users u, dbo.aspnet_Roles r
		WHERE		 u.UserId = tu.UserId AND r.RoleId = tr.RoleId AND
					 tu.UserId NOT IN (SELECT ur.UserId FROM dbo.aspnet_UsersInRoles ur WHERE ur.RoleId = tr.RoleId) AND
					 tr.RoleId NOT IN (SELECT ur.RoleId FROM dbo.aspnet_UsersInRoles ur WHERE ur.UserId = tu.UserId)
		IF( @TranStarted = 1 )
			ROLLBACK TRANSACTION
		RETURN(3)
	END

	DELETE FROM dbo.aspnet_UsersInRoles
	WHERE UserId IN (SELECT UserId FROM @tbUsers)
	  AND RoleId IN (SELECT RoleId FROM @tbRoles)
	IF( @TranStarted = 1 )
		COMMIT TRANSACTION
	RETURN(0)
END
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        ' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UsersInRoles_GetUsersInRoles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles_GetUsersInRoles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UsersInRoles_GetUsersInRoles]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL
    SELECT  @ApplicationId = ApplicationId FROM aspnet_Applications WHERE LOWER(@ApplicationName) = LoweredApplicationName
    IF (@ApplicationId IS NULL)
        RETURN(1)
     DECLARE @RoleId uniqueidentifier
     SELECT  @RoleId = NULL

     SELECT  @RoleId = RoleId
     FROM    dbo.aspnet_Roles
     WHERE   LOWER(@RoleName) = LoweredRoleName AND ApplicationId = @ApplicationId

     IF (@RoleId IS NULL)
         RETURN(1)

    SELECT u.UserName
    FROM   dbo.aspnet_Users u, dbo.aspnet_UsersInRoles ur
    WHERE  u.UserId = ur.UserId AND @RoleId = ur.RoleId AND u.ApplicationId = @ApplicationId
    ORDER BY u.UserName
    RETURN(0)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetHTMLWidgetByWidgetID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetHTMLWidgetByWidgetID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetHTMLWidgetByWidgetID]
@WidgetID as uniqueidentifier
as
BEGIN
SELECT     Widget.Title, HTMLWidget.HTMLWidgetID, HTMLWidget.HTMLDATA, HTMLWidget.ModifiedDate, Widget.ContentID, Widget.WidgetID
FROM         HTMLWidget INNER JOIN
                      Widget ON CAST(HTMLWidget.HTMLWidgetID AS varchar(50)) = Widget.ContentID
WHERE     (Widget.WidgetID = @WidgetID)
END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_Users]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Users]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_Users]
  AS SELECT [dbo].[aspnet_Users].[ApplicationId], [dbo].[aspnet_Users].[UserId], [dbo].[aspnet_Users].[UserName], [dbo].[aspnet_Users].[LoweredUserName], [dbo].[aspnet_Users].[MobileAlias], [dbo].[aspnet_Users].[IsAnonymous], [dbo].[aspnet_Users].[LastActivityDate]
  FROM [dbo].[aspnet_Users]
  '
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Users_CreateUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Users_CreateUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Users_CreateUser]
    @ApplicationId    uniqueidentifier,
    @UserName         nvarchar(256),
    @IsUserAnonymous  bit,
    @LastActivityDate DATETIME,
    @UserId           uniqueidentifier OUTPUT
AS
BEGIN
    IF( @UserId IS NULL )
        SELECT @UserId = NEWID()
    ELSE
    BEGIN
        IF( EXISTS( SELECT UserId FROM dbo.aspnet_Users
                    WHERE @UserId = UserId ) )
            RETURN -1
    END

    INSERT dbo.aspnet_Users (ApplicationId, UserId, UserName, LoweredUserName, IsAnonymous, LastActivityDate)
    VALUES (@ApplicationId, @UserId, @UserName, LOWER(@UserName), @IsUserAnonymous, @LastActivityDate)

    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_GetUserByUserId]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_GetUserByUserId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_GetUserByUserId]
    @UserId               uniqueidentifier,
    @CurrentTimeUtc       datetime,
    @UpdateLastActivity   bit = 0
AS
BEGIN
    IF ( @UpdateLastActivity = 1 )
    BEGIN
        UPDATE   dbo.aspnet_Users
        SET      LastActivityDate = @CurrentTimeUtc
        FROM     dbo.aspnet_Users
        WHERE    @UserId = UserId

        IF ( @@ROWCOUNT = 0 ) -- User ID not found
            RETURN -1
    END

    SELECT  m.Email, m.PasswordQuestion, m.Comment, m.IsApproved,
            m.CreateDate, m.LastLoginDate, u.LastActivityDate,
            m.LastPasswordChangedDate, u.UserName, m.IsLockedOut,
            m.LastLockoutDate
    FROM    dbo.aspnet_Users u, dbo.aspnet_Membership m
    WHERE   @UserId = u.UserId AND u.UserId = m.UserId

    IF ( @@ROWCOUNT = 0 ) -- User ID not found
       RETURN -1

    RETURN 0
END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_MembershipUsers]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_MembershipUsers]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_MembershipUsers]
  AS SELECT [dbo].[aspnet_Membership].[UserId],
            [dbo].[aspnet_Membership].[PasswordFormat],
            [dbo].[aspnet_Membership].[MobilePIN],
            [dbo].[aspnet_Membership].[Email],
            [dbo].[aspnet_Membership].[LoweredEmail],
            [dbo].[aspnet_Membership].[PasswordQuestion],
            [dbo].[aspnet_Membership].[PasswordAnswer],
            [dbo].[aspnet_Membership].[IsApproved],
            [dbo].[aspnet_Membership].[IsLockedOut],
            [dbo].[aspnet_Membership].[CreateDate],
            [dbo].[aspnet_Membership].[LastLoginDate],
            [dbo].[aspnet_Membership].[LastPasswordChangedDate],
            [dbo].[aspnet_Membership].[LastLockoutDate],
            [dbo].[aspnet_Membership].[FailedPasswordAttemptCount],
            [dbo].[aspnet_Membership].[FailedPasswordAttemptWindowStart],
            [dbo].[aspnet_Membership].[FailedPasswordAnswerAttemptCount],
            [dbo].[aspnet_Membership].[FailedPasswordAnswerAttemptWindowStart],
            [dbo].[aspnet_Membership].[Comment],
            [dbo].[aspnet_Users].[ApplicationId],
            [dbo].[aspnet_Users].[UserName],
            [dbo].[aspnet_Users].[MobileAlias],
            [dbo].[aspnet_Users].[IsAnonymous],
            [dbo].[aspnet_Users].[LastActivityDate]
  FROM [dbo].[aspnet_Membership] INNER JOIN [dbo].[aspnet_Users]
      ON [dbo].[aspnet_Membership].[UserId] = [dbo].[aspnet_Users].[UserId]
  '
GO
/****** Object:  UserDefinedFunction [dbo].[GetExamTotalmark]    Script Date: 08/14/2010 17:31:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamTotalmark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create function [dbo].[GetExamTotalmark](@ExamID as int)
RETURNS  Decimal
AS
BEGIN
DECLARE @TotalMark as decimal
set @TotalMark=0
SELECT     @TotalMark=SUM(EXM_Question.Marks) 
FROM         EXM_Question INNER JOIN
                      EXM_Answer ON EXM_Question.EXM_QuestionID = EXM_Answer.EXM_QuestionID
WHERE     (EXM_Answer.IsRight = 1)
GROUP BY EXM_Question.ExamID
HAVING      (EXM_Question.ExamID = @ExamID)
Return @TotalMark
END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetSingleChoiceMark]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSingleChoiceMark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[GetSingleChoiceMark](@QuestionID as int,@AnswerID as int)
RETURNS  Decimal
AS
BEGIN
	-- Declare the return variable here
	Declare @Mark as Decimal
set @Mark=0
SELECT     @Mark=EXM_Question.Marks
FROM         EXM_Question INNER JOIN
                      EXM_Answer ON EXM_Question.EXM_QuestionID = EXM_Answer.EXM_QuestionID
WHERE     (EXM_Question.Q_Type IN (''1'',''3'')) AND (EXM_Answer.IsRight = 1) AND (EXM_Answer.EXM_QuestionID = @QuestionID) AND (EXM_Answer.EXM_AnswerID = @AnswerID)


return @Mark
END
' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetMultiChoiceMark]    Script Date: 08/14/2010 17:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetMultiChoiceMark]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[GetMultiChoiceMark](@QuestionID as int,@UserExamID as int)
RETURNS  Decimal
AS
BEGIN
	-- Declare the return variable here
	Declare @Mark as Decimal,@RightAnswer as int,@WrongeAnswer as int,@ReMark as decimal
set @Mark=0
set @ReMark=-1
set @RightAnswer=0

set @WrongeAnswer=0


SELECT     @RightAnswer=Count(EXM_Answer.IsRight),@Mark=AVG(EXM_Question.Marks)
FROM         EXM_Answer INNER JOIN
                      EXM_Question ON EXM_Answer.EXM_QuestionID = EXM_Question.EXM_QuestionID INNER JOIN
                      EXM_UserAnswer ON EXM_Answer.EXM_AnswerID = EXM_UserAnswer.EXM_AnswerID INNER JOIN
                      UserExam ON EXM_UserAnswer.LoginUserID = UserExam.LoginUserID
WHERE     (EXM_Question.Q_Type = ''2'') AND (EXM_Answer.IsRight = 1) AND EXM_Answer.EXM_QuestionID=@QuestionID and UserExam.UserExamID=@UserExamID
GROUP BY EXM_Question.Marks

SELECT     @WrongeAnswer=Count(EXM_Answer.IsRight),@Mark=AVG(EXM_Question.Marks)
FROM         EXM_Answer INNER JOIN
                      EXM_Question ON EXM_Answer.EXM_QuestionID = EXM_Question.EXM_QuestionID INNER JOIN
                      EXM_UserAnswer ON EXM_Answer.EXM_AnswerID = EXM_UserAnswer.EXM_AnswerID INNER JOIN
                      UserExam ON EXM_UserAnswer.LoginUserID = UserExam.LoginUserID
WHERE     (EXM_Question.Q_Type = ''2'') AND (EXM_Answer.IsRight = 0) AND EXM_Answer.EXM_QuestionID=@QuestionID and UserExam.UserExamID=@UserExamID
GROUP BY EXM_Question.Marks

if(@RightAnswer-@WrongeAnswer)>-1
BEGIN
set @ReMark=(@Mark)*(@RightAnswer-@WrongeAnswer)

END
--set @ReMark=(@Mark)*(@RightAnswer-@WrongeAnswer)
return @ReMark
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_UnRegisterSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_UnRegisterSchemaVersion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_UnRegisterSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128)
AS
BEGIN
    DELETE FROM dbo.aspnet_SchemaVersions
        WHERE   Feature = LOWER(@Feature) AND @CompatibleSchemaVersion = CompatibleSchemaVersion
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_CheckSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_CheckSchemaVersion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_CheckSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128)
AS
BEGIN
    IF (EXISTS( SELECT  *
                FROM    dbo.aspnet_SchemaVersions
                WHERE   Feature = LOWER( @Feature ) AND
                        CompatibleSchemaVersion = @CompatibleSchemaVersion ))
        RETURN 0

    RETURN 1
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_RegisterSchemaVersion]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_RegisterSchemaVersion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_RegisterSchemaVersion]
    @Feature                   nvarchar(128),
    @CompatibleSchemaVersion   nvarchar(128),
    @IsCurrentVersion          bit,
    @RemoveIncompatibleSchema  bit
AS
BEGIN
    IF( @RemoveIncompatibleSchema = 1 )
    BEGIN
        DELETE FROM dbo.aspnet_SchemaVersions WHERE Feature = LOWER( @Feature )
    END
    ELSE
    BEGIN
        IF( @IsCurrentVersion = 1 )
        BEGIN
            UPDATE dbo.aspnet_SchemaVersions
            SET IsCurrentVersion = 0
            WHERE Feature = LOWER( @Feature )
        END
    END

    INSERT  dbo.aspnet_SchemaVersions( Feature, CompatibleSchemaVersion, IsCurrentVersion )
    VALUES( LOWER( @Feature ), @CompatibleSchemaVersion, @IsCurrentVersion )
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetCourceByInstituteID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCourceByInstituteID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[GetCourceByInstituteID]
@InstituteID as int
as
BEGIN

SELECT     Cource.CourceName, InstituteCource.InstituteCourceID, InstituteCource.InstituteID, InstituteCource.CourceID
FROM         InstituteCource INNER JOIN
                      Cource ON InstituteCource.CourceID = Cource.CourceID
WHERE     (InstituteCource.InstituteID = @InstituteID)

END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_Profiles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Profiles]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_Profiles]
  AS SELECT [dbo].[aspnet_Profile].[UserId], [dbo].[aspnet_Profile].[LastUpdatedDate],
      [DataSize]=  DATALENGTH([dbo].[aspnet_Profile].[PropertyNames])
                 + DATALENGTH([dbo].[aspnet_Profile].[PropertyValuesString])
                 + DATALENGTH([dbo].[aspnet_Profile].[PropertyValuesBinary])
  FROM [dbo].[aspnet_Profile]
  '
GO
/****** Object:  View [dbo].[vw_aspnet_Roles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_Roles]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_Roles]
  AS SELECT [dbo].[aspnet_Roles].[ApplicationId], [dbo].[aspnet_Roles].[RoleId], [dbo].[aspnet_Roles].[RoleName], [dbo].[aspnet_Roles].[LoweredRoleName], [dbo].[aspnet_Roles].[Description]
  FROM [dbo].[aspnet_Roles]
  '
GO
/****** Object:  UserDefinedFunction [dbo].[GetAnswerStatus]    Script Date: 08/14/2010 17:31:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAnswerStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create Function [dbo].[GetAnswerStatus](@status as int)
RETURNS varchar(1000)
as
Begin

declare @statustext as varchar(1000)
set @statustext=''''


SELECT    @statustext=AnswerStateText
FROM         AnswerState
WHERE  AnswerStateID=@status

if(@statustext='''')
BEGIN
set @statustext=''open''
END

return @statustext
END' 
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetInstituteSubjectName]    Script Date: 08/14/2010 17:31:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetInstituteSubjectName]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'Create Function [dbo].[GetInstituteSubjectName]( @InstituteSubjectID as int)
RETURNS varchar(max)
as
Begin

declare @EnableEdit as varchar(max)
set @EnableEdit=''''


SELECT     @EnableEdit=SubjectText
FROM         InstituteSubject
WHERE     (InstituteSubjectID = @InstituteSubjectID)

return @EnableEdit
END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_UsersInRoles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_UsersInRoles]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_UsersInRoles]
  AS SELECT [dbo].[aspnet_UsersInRoles].[UserId], [dbo].[aspnet_UsersInRoles].[RoleId]
  FROM [dbo].[aspnet_UsersInRoles]
  '
GO
/****** Object:  UserDefinedFunction [dbo].[GetQuestionStatus]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionStatus]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'create Function [dbo].[GetQuestionStatus](@status as int)
RETURNS varchar(1000)
as
Begin

declare @statustext as varchar(1000)
set @statustext=''''

SELECT    @statustext= QuestionStatusText
FROM         QuestionStatus
WHERE     (QuestionStatusID =@status)

if(@statustext='''')
BEGIN
set @statustext=''open''
END

return @statustext
END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Paths]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_Paths]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_WebPartState_Paths]
  AS SELECT [dbo].[aspnet_Paths].[ApplicationId], [dbo].[aspnet_Paths].[PathId], [dbo].[aspnet_Paths].[Path], [dbo].[aspnet_Paths].[LoweredPath]
  FROM [dbo].[aspnet_Paths]
  '
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Paths_CreatePath]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Paths_CreatePath]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Paths_CreatePath]
    @ApplicationId UNIQUEIDENTIFIER,
    @Path           NVARCHAR(256),
    @PathId         UNIQUEIDENTIFIER OUTPUT
AS
BEGIN
    BEGIN TRANSACTION
    IF (NOT EXISTS(SELECT * FROM dbo.aspnet_Paths WHERE LoweredPath = LOWER(@Path) AND ApplicationId = @ApplicationId))
    BEGIN
        INSERT dbo.aspnet_Paths (ApplicationId, Path, LoweredPath) VALUES (@ApplicationId, @Path, LOWER(@Path))
    END
    COMMIT TRANSACTION
    SELECT @PathId = PathId FROM dbo.aspnet_Paths WHERE LOWER(@Path) = LoweredPath AND ApplicationId = @ApplicationId
END' 
END
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_Shared]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_Shared]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_WebPartState_Shared]
  AS SELECT [dbo].[aspnet_PersonalizationAllUsers].[PathId], [DataSize]=DATALENGTH([dbo].[aspnet_PersonalizationAllUsers].[PageSettings]), [dbo].[aspnet_PersonalizationAllUsers].[LastUpdatedDate]
  FROM [dbo].[aspnet_PersonalizationAllUsers]
  '
GO
/****** Object:  View [dbo].[vw_aspnet_WebPartState_User]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_aspnet_WebPartState_User]'))
EXEC dbo.sp_executesql @statement = N'
  CREATE VIEW [dbo].[vw_aspnet_WebPartState_User]
  AS SELECT [dbo].[aspnet_PersonalizationPerUser].[PathId], [dbo].[aspnet_PersonalizationPerUser].[UserId], [DataSize]=DATALENGTH([dbo].[aspnet_PersonalizationPerUser].[PageSettings]), [dbo].[aspnet_PersonalizationPerUser].[LastUpdatedDate]
  FROM [dbo].[aspnet_PersonalizationPerUser]
  '
GO
/****** Object:  StoredProcedure [dbo].[ExamUserByExamID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamUserByExamID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[ExamUserByExamID]
@ExamID as int
as
Begin
SELECT     EXM_UserAnswer.UserExamID, EXM_UserAnswer.LoginUserID, SUM(EXM_UserAnswer.RecieveMark) AS Marks, UserExam.ExamID, 
                      [User].FirstName, [User].LastName, UserExam.ModifiedDate, UserExam.StartTime, UserExam.EndDate AS EndTime, 
                      dbo.GetExamTotalmark(UserExam.ExamID) AS ExamTotalMarks, Exam.RequirePecentage, UserExam.IsFinish
FROM         EXM_UserAnswer INNER JOIN
                      UserExam ON EXM_UserAnswer.UserExamID = UserExam.UserExamID INNER JOIN
                      [User] ON EXM_UserAnswer.LoginUserID = [User].LoginUserID INNER JOIN
                      Exam ON UserExam.ExamID = Exam.ExamID
GROUP BY EXM_UserAnswer.UserExamID, EXM_UserAnswer.LoginUserID, UserExam.ExamID, [User].FirstName, [User].LastName, UserExam.ModifiedDate, 
                      UserExam.StartTime, UserExam.EndDate, Exam.RequirePecentage,UserExam.IsFinish
HAVING      (UserExam.ExamID = @ExamID)

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamResultByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamResultByLoginUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetExamResultByLoginUserID] 
@LoginUserID as int,
@ExamID as int
as
Begin


SELECT     dbo.GetTotalMarksByExamAndUserExamID(Exam.ExamID, UserExam.UserExamID, UserExam.LoginUserID) AS Marks, Exam.ExamName, 
                      Exam.SubjectName, UserExam.StartTime, UserExam.EndDate AS EndTime, UserExam.IsFinish, Exam.StartDate, Exam.EndDate, 
                      Exam.RequirePecentage,dbo.GetExamTotalmark(Exam.ExamID) as ExamTotalMarks
FROM         Exam INNER JOIN
                      UserExam ON Exam.ExamID = UserExam.ExamID
WHERE     (Exam.ExamID = @ExamID) AND (UserExam.LoginUserID = @LoginUserID)

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamsResultByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamsResultByLoginUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create procedure [dbo].[GetExamsResultByLoginUserID] 
@LoginUserID as int
as
Begin


SELECT     dbo.GetTotalMarksByExamAndUserExamID(Exam.ExamID, UserExam.UserExamID, UserExam.LoginUserID) AS Marks, Exam.ExamName, 
                      Exam.SubjectName, UserExam.StartTime, UserExam.EndDate AS EndTime, UserExam.IsFinish, Exam.StartDate, Exam.EndDate, 
                      Exam.RequirePecentage,dbo.GetExamTotalmark(Exam.ExamID) as ExamTotalMarks
FROM         Exam INNER JOIN
                      UserExam ON Exam.ExamID = UserExam.ExamID
WHERE     (UserExam.LoginUserID = @LoginUserID)

END



' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetShareUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetShareUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetShareUser]
@ObjectType as int,
@ObjectID as varchar(100)
as
BEGIN


SELECT     LoginUser.Username
		, LoginUser.LoginUserID
		,[dbo].[EnableEdit](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableEdit
		,[dbo].[EnableAdd](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableAdd
		,[dbo].[EnableView](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableView
		,[dbo].[EnableDelete](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableDelete
		,[dbo].[EnableEdit](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableEditByLoggedIn
		
FROM         InstituteUser INNER JOIN
                      LoginUser ON InstituteUser.LoginUserID = LoginUser.LoginUserID


END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionByLoginUserID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionByLoginUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[GetQuestionByLoginUserID]
@LoginUserID as int,
@QuestionTypeID as int,
@QuestionStatusID as int
as
BEgin
SELECT     Question.QuestionText, Question.QuestionID, Question.Description, Question.LoginUserID, Question.QuestionTypeID, 
                      dbo.GetQuestionStatus(Question.QuestionStatusID) AS QuestionStatus, Question.ModifiedDate, [User].FirstName, [User].LastName, 
                      [User].MiddleName, [User].PhotoPath, QuestionType.QuestionTypeTnext AS QuestionType, Question.QuestionStatusID
FROM         Question INNER JOIN
                      LoginUser ON Question.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID INNER JOIN
                      QuestionType ON Question.QuestionTypeID = QuestionType.QuestionTypeID
WHERE     (Question.QuestionTypeID = CASE WHEN @QuestionTypeID <> - 1 THEN @QuestionTypeID ELSE Question.QuestionTypeID END) AND 
                      (Question.QuestionStatusID = CASE WHEN @QuestionStatusID <> - 1 THEN @QuestionStatusID ELSE Question.QuestionStatusID END) AND 
                      (Question.LoginUserID =@LoginUserID)

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAnswerByQuestionID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAnswerByQuestionID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'create procedure [dbo].[GetAnswerByQuestionID]
@QuestionID as uniqueidentifier,
@AnswerStateID as int
as
BEGIN

SELECT     Answer.AnswerID, Answer.AnswerText, Answer.Description, Answer.QuestionID, dbo.GetAnswerStatus(Answer.AnswerStateID) AS AnswerStatus, 
                      Answer.AnswerStateID, Answer.LoginUserID, Answer.AnswerRate, Answer.ModifiedDate, [User].FirstName, [User].LastName, [User].MiddleName, 
                      [User].PhotoPath
FROM         Answer INNER JOIN
                      LoginUser ON Answer.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID
WHERE     (Answer.QuestionID = @QuestionID) AND (Answer.AnswerStateID = CASE WHEN @AnswerStateID<>-1 THEN @AnswerStateID ELSE Answer.AnswerStateID END )
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuestionByQuestionID]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestionByQuestionID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetQuestionByQuestionID]
@QuestionID as Uniqueidentifier,
@QuestionTypeID as int,
@QuestionStatusID as int,
@InstituteSubjectID as int,
@InstituteCourceID as int
as
BEgin
SELECT     Question.QuestionText, Question.QuestionID, Question.Description, Question.LoginUserID, Question.QuestionTypeID, 
                      dbo.GetQuestionStatus(Question.QuestionStatusID) AS QuestionStatus, Question.ModifiedDate, [User].FirstName, [User].LastName, 
                      [User].MiddleName, [User].PhotoPath, QuestionType.QuestionTypeTnext AS QuestionType, Question.QuestionStatusID, Question.InstituteCourceID, 
                      Question.InstituteSubjectID
FROM         Question INNER JOIN
                      LoginUser ON Question.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID INNER JOIN
                      QuestionType ON Question.QuestionTypeID = QuestionType.QuestionTypeID
WHERE     (Question.QuestionTypeID = CASE WHEN @QuestionTypeID <> - 1 THEN @QuestionTypeID ELSE Question.QuestionTypeID END) AND 
                      (Question.QuestionStatusID = CASE WHEN @QuestionStatusID <> - 1 THEN @QuestionStatusID ELSE Question.QuestionStatusID END) AND 
                      (Question.QuestionID = @QuestionID) AND
					  (Question.InstituteSubjectID=CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE Question.InstituteSubjectID END) AND
					  (Question.InstituteCourceID=CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE Question.InstituteSubjectID END) 
					

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuestion]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetQuestion]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetQuestion]
@Keyword as varchar(1000),
@QuestionTypeID as int,
@QuestionStatusID as int,
@InstituteCourceID as int,
@InstituteSubjectID as int
as
BEgin
SELECT     Question.QuestionText, Question.QuestionID, Question.Description, Question.LoginUserID, Question.QuestionTypeID, 
                      dbo.GetQuestionStatus(Question.QuestionStatusID) AS QuestionStatus, Question.ModifiedDate, [User].FirstName, [User].LastName, 
                      [User].MiddleName, [User].PhotoPath, QuestionType.QuestionTypeTnext AS QuestionType, Question.QuestionStatusID
FROM         Question INNER JOIN
                      LoginUser ON Question.LoginUserID = LoginUser.LoginUserID INNER JOIN
                      [User] ON LoginUser.LoginUserID = [User].LoginUserID INNER JOIN
                      QuestionType ON Question.QuestionTypeID = QuestionType.QuestionTypeID
WHERE     (Question.QuestionTypeID = CASE WHEN @QuestionTypeID<>-1 THEN @QuestionTypeID ELSE Question.QuestionTypeID END ) 
			AND (Question.QuestionStatusID = CASE WHEN @QuestionStatusID<>-1 THEN @QuestionStatusID ELSE Question.QuestionStatusID END)
            AND (Question.QuestionText LIKE ''%''+@Keyword+''%''
OR Question.Description LIKE ''%''+@Keyword+''%'') AND
(Question.InstituteSubjectID=CASE WHEN @InstituteSubjectID<>0 THEN @InstituteSubjectID ELSE Question.InstituteSubjectID END) AND
					  (Question.InstituteCourceID=CASE WHEN @InstituteCourceID<>0 THEN @InstituteCourceID ELSE Question.InstituteCourceID END) 

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserObjectAccess]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserObjectAccess]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetUserObjectAccess]
@LoginUserID as int,
@ObjectID as varchar(40),
@ObjectType as int
as
BEGIN

SELECT     LoginUser.Username
		, LoginUser.LoginUserID
		,[dbo].[EnableEdit](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableEdit
		,[dbo].[EnableAdd](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableAdd
		,[dbo].[EnableView](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableView
		,[dbo].[EnableDelete](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableDelete
		,[dbo].[EnableEdit](@ObjectID,@ObjectType,LoginUser.LoginUserID) as EnableEditByLoggedIn
		
FROM         InstituteUser INNER JOIN
                      LoginUser ON InstituteUser.LoginUserID = LoginUser.LoginUserID
Where LoginUser.LoginUserID=@LoginUserID

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_SetProperties]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_SetProperties]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_SetProperties]
    @ApplicationName        nvarchar(256),
    @PropertyNames          ntext,
    @PropertyValuesString   ntext,
    @PropertyValuesBinary   image,
    @UserName               nvarchar(256),
    @IsUserAnonymous        bit,
    @CurrentTimeUtc         datetime
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
       BEGIN TRANSACTION
       SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    DECLARE @UserId uniqueidentifier
    DECLARE @LastActivityDate datetime
    SELECT  @UserId = NULL
    SELECT  @LastActivityDate = @CurrentTimeUtc

    SELECT @UserId = UserId
    FROM   dbo.aspnet_Users
    WHERE  ApplicationId = @ApplicationId AND LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
        EXEC dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, @IsUserAnonymous, @LastActivityDate, @UserId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    UPDATE dbo.aspnet_Users
    SET    LastActivityDate=@CurrentTimeUtc
    WHERE  UserId = @UserId

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF (EXISTS( SELECT *
               FROM   dbo.aspnet_Profile
               WHERE  UserId = @UserId))
        UPDATE dbo.aspnet_Profile
        SET    PropertyNames=@PropertyNames, PropertyValuesString = @PropertyValuesString,
               PropertyValuesBinary = @PropertyValuesBinary, LastUpdatedDate=@CurrentTimeUtc
        WHERE  UserId = @UserId
    ELSE
        INSERT INTO dbo.aspnet_Profile(UserId, PropertyNames, PropertyValuesString, PropertyValuesBinary, LastUpdatedDate)
             VALUES (@UserId, @PropertyNames, @PropertyValuesString, @PropertyValuesBinary, @CurrentTimeUtc)

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
    	SET @TranStarted = 0
    	COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetUserState]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_ResetUserState]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetUserState] (
    @Count                  int                 OUT,
    @ApplicationName        NVARCHAR(256),
    @InactiveSinceDate      DATETIME            = NULL,
    @UserName               NVARCHAR(256)       = NULL,
    @Path                   NVARCHAR(256)       = NULL)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationPerUser
        WHERE Id IN (SELECT PerUser.Id
                     FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
                     WHERE Paths.ApplicationId = @ApplicationId
                           AND PerUser.UserId = Users.UserId
                           AND PerUser.PathId = Paths.PathId
                           AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
                           AND (@UserName IS NULL OR Users.LoweredUserName = LOWER(@UserName))
                           AND (@Path IS NULL OR Paths.LoweredPath = LOWER(@Path)))

        SELECT @Count = @@ROWCOUNT
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_GetCountOfState]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_GetCountOfState]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_GetCountOfState] (
    @Count int OUT,
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @Path NVARCHAR(256) = NULL,
    @UserName NVARCHAR(256) = NULL,
    @InactiveSinceDate DATETIME = NULL)
AS
BEGIN

    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
        IF (@AllUsersScope = 1)
            SELECT @Count = COUNT(*)
            FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
            WHERE Paths.ApplicationId = @ApplicationId
                  AND AllUsers.PathId = Paths.PathId
                  AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
        ELSE
            SELECT @Count = COUNT(*)
            FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
            WHERE Paths.ApplicationId = @ApplicationId
                  AND PerUser.UserId = Users.UserId
                  AND PerUser.PathId = Paths.PathId
                  AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
                  AND (@UserName IS NULL OR Users.LoweredUserName LIKE LOWER(@UserName))
                  AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Membership_CreateUser]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Membership_CreateUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Membership_CreateUser]
    @ApplicationName                        nvarchar(256),
    @UserName                               nvarchar(256),
    @Password                               nvarchar(128),
    @PasswordSalt                           nvarchar(128),
    @Email                                  nvarchar(256),
    @PasswordQuestion                       nvarchar(256),
    @PasswordAnswer                         nvarchar(128),
    @IsApproved                             bit,
    @CurrentTimeUtc                         datetime,
    @CreateDate                             datetime = NULL,
    @UniqueEmail                            int      = 0,
    @PasswordFormat                         int      = 0,
    @UserId                                 uniqueidentifier OUTPUT
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @NewUserId uniqueidentifier
    SELECT @NewUserId = NULL

    DECLARE @IsLockedOut bit
    SET @IsLockedOut = 0

    DECLARE @LastLockoutDate  datetime
    SET @LastLockoutDate = CONVERT( datetime, ''17540101'', 112 )

    DECLARE @FailedPasswordAttemptCount int
    SET @FailedPasswordAttemptCount = 0

    DECLARE @FailedPasswordAttemptWindowStart  datetime
    SET @FailedPasswordAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )

    DECLARE @FailedPasswordAnswerAttemptCount int
    SET @FailedPasswordAnswerAttemptCount = 0

    DECLARE @FailedPasswordAnswerAttemptWindowStart  datetime
    SET @FailedPasswordAnswerAttemptWindowStart = CONVERT( datetime, ''17540101'', 112 )

    DECLARE @NewUserCreated bit
    DECLARE @ReturnValue   int
    SET @ReturnValue = 0

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
	    BEGIN TRANSACTION
	    SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    SET @CreateDate = @CurrentTimeUtc

    SELECT  @NewUserId = UserId FROM dbo.aspnet_Users WHERE LOWER(@UserName) = LoweredUserName AND @ApplicationId = ApplicationId
    IF ( @NewUserId IS NULL )
    BEGIN
        SET @NewUserId = @UserId
        EXEC @ReturnValue = dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, 0, @CreateDate, @NewUserId OUTPUT
        SET @NewUserCreated = 1
    END
    ELSE
    BEGIN
        SET @NewUserCreated = 0
        IF( @NewUserId <> @UserId AND @UserId IS NOT NULL )
        BEGIN
            SET @ErrorCode = 6
            GOTO Cleanup
        END
    END

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @ReturnValue = -1 )
    BEGIN
        SET @ErrorCode = 10
        GOTO Cleanup
    END

    IF ( EXISTS ( SELECT UserId
                  FROM   dbo.aspnet_Membership
                  WHERE  @NewUserId = UserId ) )
    BEGIN
        SET @ErrorCode = 6
        GOTO Cleanup
    END

    SET @UserId = @NewUserId

    IF (@UniqueEmail = 1)
    BEGIN
        IF (EXISTS (SELECT *
                    FROM  dbo.aspnet_Membership m WITH ( UPDLOCK, HOLDLOCK )
                    WHERE ApplicationId = @ApplicationId AND LoweredEmail = LOWER(@Email)))
        BEGIN
            SET @ErrorCode = 7
            GOTO Cleanup
        END
    END

    IF (@NewUserCreated = 0)
    BEGIN
        UPDATE dbo.aspnet_Users
        SET    LastActivityDate = @CreateDate
        WHERE  @UserId = UserId
        IF( @@ERROR <> 0 )
        BEGIN
            SET @ErrorCode = -1
            GOTO Cleanup
        END
    END

    INSERT INTO dbo.aspnet_Membership
                ( ApplicationId,
                  UserId,
                  Password,
                  PasswordSalt,
                  Email,
                  LoweredEmail,
                  PasswordQuestion,
                  PasswordAnswer,
                  PasswordFormat,
                  IsApproved,
                  IsLockedOut,
                  CreateDate,
                  LastLoginDate,
                  LastPasswordChangedDate,
                  LastLockoutDate,
                  FailedPasswordAttemptCount,
                  FailedPasswordAttemptWindowStart,
                  FailedPasswordAnswerAttemptCount,
                  FailedPasswordAnswerAttemptWindowStart )
         VALUES ( @ApplicationId,
                  @UserId,
                  @Password,
                  @PasswordSalt,
                  @Email,
                  LOWER(@Email),
                  @PasswordQuestion,
                  @PasswordAnswer,
                  @PasswordFormat,
                  @IsApproved,
                  @IsLockedOut,
                  @CreateDate,
                  @CreateDate,
                  @CreateDate,
                  @LastLockoutDate,
                  @FailedPasswordAttemptCount,
                  @FailedPasswordAttemptWindowStart,
                  @FailedPasswordAnswerAttemptCount,
                  @FailedPasswordAnswerAttemptWindowStart )

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
	    SET @TranStarted = 0
	    COMMIT TRANSACTION
    END

    RETURN 0

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_GetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_GetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_GetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        RETURN
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    SELECT p.PageSettings FROM dbo.aspnet_PersonalizationPerUser p WHERE p.PathId = @PathId AND p.UserId = @UserId
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_ResetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        RETURN
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    DELETE FROM dbo.aspnet_PersonalizationPerUser WHERE PathId = @PathId AND UserId = @UserId
    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationPerUser_SetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser_SetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationPerUser_SetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @UserName         NVARCHAR(256),
    @Path             NVARCHAR(256),
    @PageSettings     IMAGE,
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER
    DECLARE @UserId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL
    SELECT @UserId = NULL

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Paths_CreatePath @ApplicationId, @Path, @PathId OUTPUT
    END

    SELECT @UserId = u.UserId FROM dbo.aspnet_Users u WHERE u.ApplicationId = @ApplicationId AND u.LoweredUserName = LOWER(@UserName)
    IF (@UserId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Users_CreateUser @ApplicationId, @UserName, 0, @CurrentTimeUtc, @UserId OUTPUT
    END

    UPDATE   dbo.aspnet_Users WITH (ROWLOCK)
    SET      LastActivityDate = @CurrentTimeUtc
    WHERE    UserId = @UserId
    IF (@@ROWCOUNT = 0) -- Username not found
        RETURN

    IF (EXISTS(SELECT PathId FROM dbo.aspnet_PersonalizationPerUser WHERE UserId = @UserId AND PathId = @PathId))
        UPDATE dbo.aspnet_PersonalizationPerUser SET PageSettings = @PageSettings, LastUpdatedDate = @CurrentTimeUtc WHERE UserId = @UserId AND PathId = @PathId
    ELSE
        INSERT INTO dbo.aspnet_PersonalizationPerUser(UserId, PathId, PageSettings, LastUpdatedDate) VALUES (@UserId, @PathId, @PageSettings, @CurrentTimeUtc)
    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetExamResultByLoginUserIDDumi]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetExamResultByLoginUserIDDumi]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE procedure [dbo].[GetExamResultByLoginUserIDDumi]
@LoginUserID as int,
@ExamID as int
as
Begin


SELECT     EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.LoginUserID, 
                      CASE EXM_Question.Q_Type WHEN ''1'' THEN dbo.GetSingleChoiceMark(EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.EXM_AnswerID) 
                      WHEN ''2'' THEN dbo.GetMultiChoiceMark(EXM_UserAnswer.EXM_QuestionID, UserExam.UserExamID) 
                      ELSE dbo.GetSingleChoiceMark(EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.EXM_AnswerID) END AS Marks, EXM_Question.Q_Type, 
                      UserExam.UserExamID, UserExam.ExamID, Exam.ExamName, Exam.SubjectName, Exam.StartDate, Exam.EndDate, UserExam.StartTime, 
                      UserExam.EndDate AS EndTime
FROM         EXM_UserAnswer INNER JOIN
                      UserExam ON EXM_UserAnswer.LoginUserID = UserExam.LoginUserID INNER JOIN
                      EXM_Question ON EXM_UserAnswer.EXM_QuestionID = EXM_Question.EXM_QuestionID INNER JOIN
                      Exam ON EXM_Question.ExamID = Exam.ExamID
WHERE     (EXM_UserAnswer.LoginUserID = @LoginUserID) AND (UserExam.ExamID = @ExamID)
GROUP BY EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.LoginUserID, EXM_Question.Q_Type, 
                      CASE EXM_Question.Q_Type WHEN ''1'' THEN dbo.GetSingleChoiceMark(EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.EXM_AnswerID) 
                      WHEN ''2'' THEN dbo.GetMultiChoiceMark(EXM_UserAnswer.EXM_QuestionID, UserExam.UserExamID) 
                      ELSE dbo.GetSingleChoiceMark(EXM_UserAnswer.EXM_QuestionID, EXM_UserAnswer.EXM_AnswerID) END, UserExam.UserExamID, 
                      UserExam.ExamID, Exam.ExamName, Exam.SubjectName, Exam.StartDate, Exam.EndDate, UserExam.StartTime, UserExam.EndDate
ORDER BY EXM_UserAnswer.EXM_QuestionID

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetGroupObjectAccess]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetGroupObjectAccess]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create procedure [dbo].[GetGroupObjectAccess]
@LoginUserID as int,
@ObjectID as varchar(40),
@ObjectType as int
as
BEGIN

SELECT     Name, InstituteUserTypeID
		   ,[dbo].[EnableEditGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableEdit
		,[dbo].[EnableAddGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableAdd
		,[dbo].[EnableViewGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableView
		,[dbo].[EnableDeleteGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableDelete
		,[dbo].[EnableEditGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableEditByLoggedIn
FROM         InstituteUserType
Where InstituteUserTypeID in (SELECT     InstituteUserTypeID
FROM         InstituteUserInUserType
WHERE     (LoginUserID = @LoginUserID))



END' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetShareGroup]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetShareGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create procedure [dbo].[GetShareGroup]
@ObjectType as int,
@ObjectID as varchar(100)
as
BEGIN


SELECT     Name, InstituteUserTypeID
		   ,[dbo].[EnableEditGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableEdit
		,[dbo].[EnableAddGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableAdd
		,[dbo].[EnableViewGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableView
		,[dbo].[EnableDeleteGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableDelete
		,[dbo].[EnableEditGroup](@ObjectID,@ObjectType,InstituteUserTypeID) as EnableEditByLoggedIn
FROM         InstituteUserType





END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Roles_CreateRole]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Roles_CreateRole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_Roles_CreateRole]
    @ApplicationName  nvarchar(256),
    @RoleName         nvarchar(256)
AS
BEGIN
    DECLARE @ApplicationId uniqueidentifier
    SELECT  @ApplicationId = NULL

    DECLARE @ErrorCode     int
    SET @ErrorCode = 0

    DECLARE @TranStarted   bit
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
        SET @TranStarted = 0

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF (EXISTS(SELECT RoleId FROM dbo.aspnet_Roles WHERE LoweredRoleName = LOWER(@RoleName) AND ApplicationId = @ApplicationId))
    BEGIN
        SET @ErrorCode = 1
        GOTO Cleanup
    END

    INSERT INTO dbo.aspnet_Roles
                (ApplicationId, RoleName, LoweredRoleName)
         VALUES (@ApplicationId, @RoleName, LOWER(@RoleName))

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        COMMIT TRANSACTION
    END

    RETURN(0)

Cleanup:

    IF( @TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
        ROLLBACK TRANSACTION
    END

    RETURN @ErrorCode

END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_SetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path             NVARCHAR(256),
    @PageSettings     IMAGE,
    @CurrentTimeUtc   DATETIME)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Applications_CreateApplication @ApplicationName, @ApplicationId OUTPUT

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        EXEC dbo.aspnet_Paths_CreatePath @ApplicationId, @Path, @PathId OUTPUT
    END

    IF (EXISTS(SELECT PathId FROM dbo.aspnet_PersonalizationAllUsers WHERE PathId = @PathId))
        UPDATE dbo.aspnet_PersonalizationAllUsers SET PageSettings = @PageSettings, LastUpdatedDate = @CurrentTimeUtc WHERE PathId = @PathId
    ELSE
        INSERT INTO dbo.aspnet_PersonalizationAllUsers(PathId, PageSettings, LastUpdatedDate) VALUES (@PathId, @PageSettings, @CurrentTimeUtc)
    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_Profile_DeleteProfiles]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_Profile_DeleteProfiles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[aspnet_Profile_DeleteProfiles]
    @ApplicationName        nvarchar(256),
    @UserNames              nvarchar(4000)
AS
BEGIN
    DECLARE @UserName     nvarchar(256)
    DECLARE @CurrentPos   int
    DECLARE @NextPos      int
    DECLARE @NumDeleted   int
    DECLARE @DeletedUser  int
    DECLARE @TranStarted  bit
    DECLARE @ErrorCode    int

    SET @ErrorCode = 0
    SET @CurrentPos = 1
    SET @NumDeleted = 0
    SET @TranStarted = 0

    IF( @@TRANCOUNT = 0 )
    BEGIN
        BEGIN TRANSACTION
        SET @TranStarted = 1
    END
    ELSE
    	SET @TranStarted = 0

    WHILE (@CurrentPos <= LEN(@UserNames))
    BEGIN
        SELECT @NextPos = CHARINDEX(N'','', @UserNames,  @CurrentPos)
        IF (@NextPos = 0 OR @NextPos IS NULL)
            SELECT @NextPos = LEN(@UserNames) + 1

        SELECT @UserName = SUBSTRING(@UserNames, @CurrentPos, @NextPos - @CurrentPos)
        SELECT @CurrentPos = @NextPos+1

        IF (LEN(@UserName) > 0)
        BEGIN
            SELECT @DeletedUser = 0
            EXEC dbo.aspnet_Users_DeleteUser @ApplicationName, @UserName, 4, @DeletedUser OUTPUT
            IF( @@ERROR <> 0 )
            BEGIN
                SET @ErrorCode = -1
                GOTO Cleanup
            END
            IF (@DeletedUser <> 0)
                SELECT @NumDeleted = @NumDeleted + 1
        END
    END
    SELECT @NumDeleted
    IF (@TranStarted = 1)
    BEGIN
    	SET @TranStarted = 0
    	COMMIT TRANSACTION
    END
    SET @TranStarted = 0

    RETURN 0

Cleanup:
    IF (@TranStarted = 1 )
    BEGIN
        SET @TranStarted = 0
    	ROLLBACK TRANSACTION
    END
    RETURN @ErrorCode
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[UserExamResult]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserExamResult]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
Create Procedure [dbo].[UserExamResult]
@LoginUserID as int,
@ExamID as int
as
Begin
SELECT     UserExam.IsFinish, Exam.ExamName,[dbo].[GetTotalMarksByExamAndUserExamID](UserExam.ExamID,UserExam.UserExamID,UserExam.LoginUserID) as Marks 
FROM         UserExam INNER JOIN
                      Exam ON UserExam.ExamID = Exam.ExamID
where Exam.ExamID=@ExamID and UserExam.LoginUserID=@LoginUserID
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_GetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path              NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    SELECT p.PageSettings FROM dbo.aspnet_PersonalizationAllUsers p WHERE p.PathId = @PathId
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_DeleteAllState]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_DeleteAllState]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_DeleteAllState] (
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @Count int OUT)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        IF (@AllUsersScope = 1)
            DELETE FROM aspnet_PersonalizationAllUsers
            WHERE PathId IN
               (SELECT Paths.PathId
                FROM dbo.aspnet_Paths Paths
                WHERE Paths.ApplicationId = @ApplicationId)
        ELSE
            DELETE FROM aspnet_PersonalizationPerUser
            WHERE PathId IN
               (SELECT Paths.PathId
                FROM dbo.aspnet_Paths Paths
                WHERE Paths.ApplicationId = @ApplicationId)

        SELECT @Count = @@ROWCOUNT
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings] (
    @ApplicationName  NVARCHAR(256),
    @Path              NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    DECLARE @PathId UNIQUEIDENTIFIER

    SELECT @ApplicationId = NULL
    SELECT @PathId = NULL

    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
    BEGIN
        RETURN
    END

    SELECT @PathId = u.PathId FROM dbo.aspnet_Paths u WHERE u.ApplicationId = @ApplicationId AND u.LoweredPath = LOWER(@Path)
    IF (@PathId IS NULL)
    BEGIN
        RETURN
    END

    DELETE FROM dbo.aspnet_PersonalizationAllUsers WHERE PathId = @PathId
    RETURN 0
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_ResetSharedState]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_ResetSharedState]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_ResetSharedState] (
    @Count int OUT,
    @ApplicationName NVARCHAR(256),
    @Path NVARCHAR(256))
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        SELECT @Count = 0
    ELSE
    BEGIN
        DELETE FROM dbo.aspnet_PersonalizationAllUsers
        WHERE PathId IN
            (SELECT AllUsers.PathId
             FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
             WHERE Paths.ApplicationId = @ApplicationId
                   AND AllUsers.PathId = Paths.PathId
                   AND Paths.LoweredPath = LOWER(@Path))

        SELECT @Count = @@ROWCOUNT
    END
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[aspnet_PersonalizationAdministration_FindState]    Script Date: 08/14/2010 17:31:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAdministration_FindState]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[aspnet_PersonalizationAdministration_FindState] (
    @AllUsersScope bit,
    @ApplicationName NVARCHAR(256),
    @PageIndex              INT,
    @PageSize               INT,
    @Path NVARCHAR(256) = NULL,
    @UserName NVARCHAR(256) = NULL,
    @InactiveSinceDate DATETIME = NULL)
AS
BEGIN
    DECLARE @ApplicationId UNIQUEIDENTIFIER
    EXEC dbo.aspnet_Personalization_GetApplicationId @ApplicationName, @ApplicationId OUTPUT
    IF (@ApplicationId IS NULL)
        RETURN

    -- Set the page bounds
    DECLARE @PageLowerBound INT
    DECLARE @PageUpperBound INT
    DECLARE @TotalRecords   INT
    SET @PageLowerBound = @PageSize * @PageIndex
    SET @PageUpperBound = @PageSize - 1 + @PageLowerBound

    -- Create a temp table to store the selected results
    CREATE TABLE #PageIndex (
        IndexId int IDENTITY (0, 1) NOT NULL,
        ItemId UNIQUEIDENTIFIER
    )

    IF (@AllUsersScope = 1)
    BEGIN
        -- Insert into our temp table
        INSERT INTO #PageIndex (ItemId)
        SELECT Paths.PathId
        FROM dbo.aspnet_Paths Paths,
             ((SELECT Paths.PathId
               FROM dbo.aspnet_PersonalizationAllUsers AllUsers, dbo.aspnet_Paths Paths
               WHERE Paths.ApplicationId = @ApplicationId
                      AND AllUsers.PathId = Paths.PathId
                      AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              ) AS SharedDataPerPath
              FULL OUTER JOIN
              (SELECT DISTINCT Paths.PathId
               FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Paths Paths
               WHERE Paths.ApplicationId = @ApplicationId
                      AND PerUser.PathId = Paths.PathId
                      AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              ) AS UserDataPerPath
              ON SharedDataPerPath.PathId = UserDataPerPath.PathId
             )
        WHERE Paths.PathId = SharedDataPerPath.PathId OR Paths.PathId = UserDataPerPath.PathId
        ORDER BY Paths.Path ASC

        SELECT @TotalRecords = @@ROWCOUNT

        SELECT Paths.Path,
               SharedDataPerPath.LastUpdatedDate,
               SharedDataPerPath.SharedDataLength,
               UserDataPerPath.UserDataLength,
               UserDataPerPath.UserCount
        FROM dbo.aspnet_Paths Paths,
             ((SELECT PageIndex.ItemId AS PathId,
                      AllUsers.LastUpdatedDate AS LastUpdatedDate,
                      DATALENGTH(AllUsers.PageSettings) AS SharedDataLength
               FROM dbo.aspnet_PersonalizationAllUsers AllUsers, #PageIndex PageIndex
               WHERE AllUsers.PathId = PageIndex.ItemId
                     AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
              ) AS SharedDataPerPath
              FULL OUTER JOIN
              (SELECT PageIndex.ItemId AS PathId,
                      SUM(DATALENGTH(PerUser.PageSettings)) AS UserDataLength,
                      COUNT(*) AS UserCount
               FROM aspnet_PersonalizationPerUser PerUser, #PageIndex PageIndex
               WHERE PerUser.PathId = PageIndex.ItemId
                     AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
               GROUP BY PageIndex.ItemId
              ) AS UserDataPerPath
              ON SharedDataPerPath.PathId = UserDataPerPath.PathId
             )
        WHERE Paths.PathId = SharedDataPerPath.PathId OR Paths.PathId = UserDataPerPath.PathId
        ORDER BY Paths.Path ASC
    END
    ELSE
    BEGIN
        -- Insert into our temp table
        INSERT INTO #PageIndex (ItemId)
        SELECT PerUser.Id
        FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths
        WHERE Paths.ApplicationId = @ApplicationId
              AND PerUser.UserId = Users.UserId
              AND PerUser.PathId = Paths.PathId
              AND (@Path IS NULL OR Paths.LoweredPath LIKE LOWER(@Path))
              AND (@UserName IS NULL OR Users.LoweredUserName LIKE LOWER(@UserName))
              AND (@InactiveSinceDate IS NULL OR Users.LastActivityDate <= @InactiveSinceDate)
        ORDER BY Paths.Path ASC, Users.UserName ASC

        SELECT @TotalRecords = @@ROWCOUNT

        SELECT Paths.Path, PerUser.LastUpdatedDate, DATALENGTH(PerUser.PageSettings), Users.UserName, Users.LastActivityDate
        FROM dbo.aspnet_PersonalizationPerUser PerUser, dbo.aspnet_Users Users, dbo.aspnet_Paths Paths, #PageIndex PageIndex
        WHERE PerUser.Id = PageIndex.ItemId
              AND PerUser.UserId = Users.UserId
              AND PerUser.PathId = Paths.PathId
              AND PageIndex.IndexId >= @PageLowerBound AND PageIndex.IndexId <= @PageUpperBound
        ORDER BY Paths.Path ASC, Users.UserName ASC
    END

    RETURN @TotalRecords
END' 
END
GO
/****** Object:  Default [DF__aspnet_Ap__Appli__286302EC]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Ap__Appli__286302EC]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Applications]'))
Begin
ALTER TABLE [dbo].[aspnet_Applications] ADD  CONSTRAINT [DF__aspnet_Ap__Appli__286302EC]  DEFAULT (newid()) FOR [ApplicationId]

End
GO
/****** Object:  Default [DF__aspnet_Me__Passw__3D5E1FD2]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Me__Passw__3D5E1FD2]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
Begin
ALTER TABLE [dbo].[aspnet_Membership] ADD  CONSTRAINT [DF__aspnet_Me__Passw__3D5E1FD2]  DEFAULT ((0)) FOR [PasswordFormat]

End
GO
/****** Object:  Default [DF__aspnet_Pa__PathI__6E01572D]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Pa__PathI__6E01572D]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]'))
Begin
ALTER TABLE [dbo].[aspnet_Paths] ADD  CONSTRAINT [DF__aspnet_Pa__PathI__6E01572D]  DEFAULT (newid()) FOR [PathId]

End
GO
/****** Object:  Default [DF__aspnet_Perso__Id__75A278F5]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Perso__Id__75A278F5]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
Begin
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] ADD  CONSTRAINT [DF__aspnet_Perso__Id__75A278F5]  DEFAULT (newid()) FOR [Id]

End
GO
/****** Object:  Default [DF__aspnet_Ro__RoleI__5AEE82B9]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Ro__RoleI__5AEE82B9]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]'))
Begin
ALTER TABLE [dbo].[aspnet_Roles] ADD  CONSTRAINT [DF__aspnet_Ro__RoleI__5AEE82B9]  DEFAULT (newid()) FOR [RoleId]

End
GO
/****** Object:  Default [DF__aspnet_Us__UserI__2C3393D0]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__UserI__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] ADD  CONSTRAINT [DF__aspnet_Us__UserI__2C3393D0]  DEFAULT (newid()) FOR [UserId]

End
GO
/****** Object:  Default [DF__aspnet_Us__Mobil__2D27B809]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__Mobil__2D27B809]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] ADD  CONSTRAINT [DF__aspnet_Us__Mobil__2D27B809]  DEFAULT (NULL) FOR [MobileAlias]

End
GO
/****** Object:  Default [DF__aspnet_Us__IsAno__2E1BDC42]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__aspnet_Us__IsAno__2E1BDC42]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
Begin
ALTER TABLE [dbo].[aspnet_Users] ADD  CONSTRAINT [DF__aspnet_Us__IsAno__2E1BDC42]  DEFAULT ((0)) FOR [IsAnonymous]

End
GO
/****** Object:  Default [DF_LoginUser_UserId]    Script Date: 08/14/2010 17:31:00 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_LoginUser_UserId]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoginUser]'))
Begin
ALTER TABLE [dbo].[LoginUser] ADD  CONSTRAINT [DF_LoginUser_UserId]  DEFAULT (newid()) FOR [UserId]

End
GO
/****** Object:  ForeignKey [FK_Answer_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Answer_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Answer]'))
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_LoginUser]
GO
/****** Object:  ForeignKey [FK_Answer_Question]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Answer_Question]') AND parent_object_id = OBJECT_ID(N'[dbo].[Answer]'))
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Question] ([QuestionID])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question]
GO
/****** Object:  ForeignKey [FK_Article_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Article_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Article]'))
ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [FK_Article_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [FK_Article_LoginUser]
GO
/****** Object:  ForeignKey [FK__aspnet_Me__Appli__3B75D760]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Me__Appli__3B75D760]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
ALTER TABLE [dbo].[aspnet_Membership]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Me__Appli__3B75D760] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Membership] CHECK CONSTRAINT [FK__aspnet_Me__Appli__3B75D760]
GO
/****** Object:  ForeignKey [FK__aspnet_Me__UserI__3C69FB99]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Me__UserI__3C69FB99]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Membership]'))
ALTER TABLE [dbo].[aspnet_Membership]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Me__UserI__3C69FB99] FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_Membership] CHECK CONSTRAINT [FK__aspnet_Me__UserI__3C69FB99]
GO
/****** Object:  ForeignKey [FK__aspnet_Pa__Appli__6D0D32F4]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pa__Appli__6D0D32F4]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Paths]'))
ALTER TABLE [dbo].[aspnet_Paths]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Pa__Appli__6D0D32F4] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Paths] CHECK CONSTRAINT [FK__aspnet_Pa__Appli__6D0D32F4]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__PathI__72C60C4A]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__PathI__72C60C4A]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationAllUsers]'))
ALTER TABLE [dbo].[aspnet_PersonalizationAllUsers]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Pe__PathI__72C60C4A] FOREIGN KEY([PathId])
REFERENCES [dbo].[aspnet_Paths] ([PathId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationAllUsers] CHECK CONSTRAINT [FK__aspnet_Pe__PathI__72C60C4A]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__PathI__76969D2E]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__PathI__76969D2E]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Pe__PathI__76969D2E] FOREIGN KEY([PathId])
REFERENCES [dbo].[aspnet_Paths] ([PathId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] CHECK CONSTRAINT [FK__aspnet_Pe__PathI__76969D2E]
GO
/****** Object:  ForeignKey [FK__aspnet_Pe__UserI__778AC167]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pe__UserI__778AC167]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_PersonalizationPerUser]'))
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Pe__UserI__778AC167] FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_PersonalizationPerUser] CHECK CONSTRAINT [FK__aspnet_Pe__UserI__778AC167]
GO
/****** Object:  ForeignKey [FK__aspnet_Pr__UserI__5070F446]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Pr__UserI__5070F446]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Profile]'))
ALTER TABLE [dbo].[aspnet_Profile]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Pr__UserI__5070F446] FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_Profile] CHECK CONSTRAINT [FK__aspnet_Pr__UserI__5070F446]
GO
/****** Object:  ForeignKey [FK__aspnet_Ro__Appli__59FA5E80]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Ro__Appli__59FA5E80]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Roles]'))
ALTER TABLE [dbo].[aspnet_Roles]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Ro__Appli__59FA5E80] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Roles] CHECK CONSTRAINT [FK__aspnet_Ro__Appli__59FA5E80]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__Appli__2B3F6F97]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__Appli__2B3F6F97]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_Users]'))
ALTER TABLE [dbo].[aspnet_Users]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Us__Appli__2B3F6F97] FOREIGN KEY([ApplicationId])
REFERENCES [dbo].[aspnet_Applications] ([ApplicationId])
GO
ALTER TABLE [dbo].[aspnet_Users] CHECK CONSTRAINT [FK__aspnet_Us__Appli__2B3F6F97]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__RoleI__5EBF139D]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__RoleI__5EBF139D]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]'))
ALTER TABLE [dbo].[aspnet_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Us__RoleI__5EBF139D] FOREIGN KEY([RoleId])
REFERENCES [dbo].[aspnet_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[aspnet_UsersInRoles] CHECK CONSTRAINT [FK__aspnet_Us__RoleI__5EBF139D]
GO
/****** Object:  ForeignKey [FK__aspnet_Us__UserI__5DCAEF64]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__aspnet_Us__UserI__5DCAEF64]') AND parent_object_id = OBJECT_ID(N'[dbo].[aspnet_UsersInRoles]'))
ALTER TABLE [dbo].[aspnet_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [FK__aspnet_Us__UserI__5DCAEF64] FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[aspnet_UsersInRoles] CHECK CONSTRAINT [FK__aspnet_Us__UserI__5DCAEF64]
GO
/****** Object:  ForeignKey [FK_Comment_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Comment_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Comment]'))
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_LoginUser]
GO
/****** Object:  ForeignKey [FK_Cource_CourceCatagory]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Cource_CourceCatagory]') AND parent_object_id = OBJECT_ID(N'[dbo].[Cource]'))
ALTER TABLE [dbo].[Cource]  WITH CHECK ADD  CONSTRAINT [FK_Cource_CourceCatagory] FOREIGN KEY([CourceCatagoryID])
REFERENCES [dbo].[CourceCatagory] ([CourceCatagoryID])
GO
ALTER TABLE [dbo].[Cource] CHECK CONSTRAINT [FK_Cource_CourceCatagory]
GO
/****** Object:  ForeignKey [FK_Document_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Document_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Document]'))
ALTER TABLE [dbo].[Document]  WITH CHECK ADD  CONSTRAINT [FK_Document_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Document] CHECK CONSTRAINT [FK_Document_LoginUser]
GO
/****** Object:  ForeignKey [FK_DocumentCource_Document]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DocumentCource_Document]') AND parent_object_id = OBJECT_ID(N'[dbo].[DocumentCource]'))
ALTER TABLE [dbo].[DocumentCource]  WITH CHECK ADD  CONSTRAINT [FK_DocumentCource_Document] FOREIGN KEY([DocumentID])
REFERENCES [dbo].[Document] ([DocumentID])
GO
ALTER TABLE [dbo].[DocumentCource] CHECK CONSTRAINT [FK_DocumentCource_Document]
GO
/****** Object:  ForeignKey [FK_Event_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Event_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Event]'))
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_LoginUser]
GO
/****** Object:  ForeignKey [FK_Exam_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Exam_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Exam]'))
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_Exam_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_Exam_LoginUser]
GO
/****** Object:  ForeignKey [FK_EXM_Answer_EXM_Question]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXM_Answer_EXM_Question]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXM_Answer]'))
ALTER TABLE [dbo].[EXM_Answer]  WITH CHECK ADD  CONSTRAINT [FK_EXM_Answer_EXM_Question] FOREIGN KEY([EXM_QuestionID])
REFERENCES [dbo].[EXM_Question] ([EXM_QuestionID])
GO
ALTER TABLE [dbo].[EXM_Answer] CHECK CONSTRAINT [FK_EXM_Answer_EXM_Question]
GO
/****** Object:  ForeignKey [FK_EXM_Question_Exam]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXM_Question_Exam]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXM_Question]'))
ALTER TABLE [dbo].[EXM_Question]  WITH CHECK ADD  CONSTRAINT [FK_EXM_Question_Exam] FOREIGN KEY([ExamID])
REFERENCES [dbo].[Exam] ([ExamID])
GO
ALTER TABLE [dbo].[EXM_Question] CHECK CONSTRAINT [FK_EXM_Question_Exam]
GO
/****** Object:  ForeignKey [FK_Institute_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Institute_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Institute]'))
ALTER TABLE [dbo].[Institute]  WITH CHECK ADD  CONSTRAINT [FK_Institute_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Institute] CHECK CONSTRAINT [FK_Institute_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteCource_Cource]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCource_Cource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCource]'))
ALTER TABLE [dbo].[InstituteCource]  WITH CHECK ADD  CONSTRAINT [FK_InstituteCource_Cource] FOREIGN KEY([CourceID])
REFERENCES [dbo].[Cource] ([CourceID])
GO
ALTER TABLE [dbo].[InstituteCource] CHECK CONSTRAINT [FK_InstituteCource_Cource]
GO
/****** Object:  ForeignKey [FK_InstituteCource_Institute]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCource_Institute]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCource]'))
ALTER TABLE [dbo].[InstituteCource]  WITH CHECK ADD  CONSTRAINT [FK_InstituteCource_Institute] FOREIGN KEY([InstituteID])
REFERENCES [dbo].[Institute] ([InstituteID])
GO
ALTER TABLE [dbo].[InstituteCource] CHECK CONSTRAINT [FK_InstituteCource_Institute]
GO
/****** Object:  ForeignKey [FK_InstituteCourceUser_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCourceUser_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]'))
ALTER TABLE [dbo].[InstituteCourceUser]  WITH CHECK ADD  CONSTRAINT [FK_InstituteCourceUser_InstituteCource] FOREIGN KEY([InstituteCourceID])
REFERENCES [dbo].[InstituteCource] ([InstituteCourceID])
GO
ALTER TABLE [dbo].[InstituteCourceUser] CHECK CONSTRAINT [FK_InstituteCourceUser_InstituteCource]
GO
/****** Object:  ForeignKey [FK_InstituteCourceUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteCourceUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteCourceUser]'))
ALTER TABLE [dbo].[InstituteCourceUser]  WITH CHECK ADD  CONSTRAINT [FK_InstituteCourceUser_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[InstituteCourceUser] CHECK CONSTRAINT [FK_InstituteCourceUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteSubject_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteSubject_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteSubject]'))
ALTER TABLE [dbo].[InstituteSubject]  WITH CHECK ADD  CONSTRAINT [FK_InstituteSubject_InstituteCource] FOREIGN KEY([InstituteCourceID])
REFERENCES [dbo].[InstituteCource] ([InstituteCourceID])
GO
ALTER TABLE [dbo].[InstituteSubject] CHECK CONSTRAINT [FK_InstituteSubject_InstituteCource]
GO
/****** Object:  ForeignKey [FK_InstituteUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUser]'))
ALTER TABLE [dbo].[InstituteUser]  WITH CHECK ADD  CONSTRAINT [FK_InstituteUser_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[InstituteUser] CHECK CONSTRAINT [FK_InstituteUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_InstituteUserInUserType_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteUserInUserType_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUserInUserType]'))
ALTER TABLE [dbo].[InstituteUserInUserType]  WITH CHECK ADD  CONSTRAINT [FK_InstituteUserInUserType_InstituteUserType] FOREIGN KEY([InstituteUserTypeID])
REFERENCES [dbo].[InstituteUserType] ([InstituteUserTypeID])
GO
ALTER TABLE [dbo].[InstituteUserInUserType] CHECK CONSTRAINT [FK_InstituteUserInUserType_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_InstituteTypeRight_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_InstituteTypeRight_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[InstituteUserTypeAccess]'))
ALTER TABLE [dbo].[InstituteUserTypeAccess]  WITH CHECK ADD  CONSTRAINT [FK_InstituteTypeRight_InstituteUserType] FOREIGN KEY([InstituteUserTypeID])
REFERENCES [dbo].[InstituteUserType] ([InstituteUserTypeID])
GO
ALTER TABLE [dbo].[InstituteUserTypeAccess] CHECK CONSTRAINT [FK_InstituteTypeRight_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_Instructor_InstituteCource]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Instructor_InstituteCource]') AND parent_object_id = OBJECT_ID(N'[dbo].[Instructor]'))
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Instructor_InstituteCource] FOREIGN KEY([InstituteCourceID])
REFERENCES [dbo].[InstituteCource] ([InstituteCourceID])
GO
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [FK_Instructor_InstituteCource]
GO
/****** Object:  ForeignKey [FK_LoginUser_aspnet_Users]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_LoginUser_aspnet_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[LoginUser]'))
ALTER TABLE [dbo].[LoginUser]  WITH CHECK ADD  CONSTRAINT [FK_LoginUser_aspnet_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
ALTER TABLE [dbo].[LoginUser] CHECK CONSTRAINT [FK_LoginUser_aspnet_Users]
GO
/****** Object:  ForeignKey [FK_Message_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Message_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Message]'))
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_LoginUser] FOREIGN KEY([FromLoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_LoginUser]
GO
/****** Object:  ForeignKey [FK_OrderItem_Order]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order]
GO
/****** Object:  ForeignKey [FK_Payment_Order]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Payment_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[Payment]'))
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Order]
GO
/****** Object:  ForeignKey [FK_Question_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Question_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_LoginUser]
GO
/****** Object:  ForeignKey [FK_Question_QuestionType]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Question_QuestionType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Question]'))
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_QuestionType] FOREIGN KEY([QuestionTypeID])
REFERENCES [dbo].[QuestionType] ([QuestionTypeID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_QuestionType]
GO
/****** Object:  ForeignKey [FK_ShareGroup_InstituteUserType]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareGroup_InstituteUserType]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareGroup]'))
ALTER TABLE [dbo].[ShareGroup]  WITH CHECK ADD  CONSTRAINT [FK_ShareGroup_InstituteUserType] FOREIGN KEY([InstituteUserTypeID])
REFERENCES [dbo].[InstituteUserType] ([InstituteUserTypeID])
GO
ALTER TABLE [dbo].[ShareGroup] CHECK CONSTRAINT [FK_ShareGroup_InstituteUserType]
GO
/****** Object:  ForeignKey [FK_ShareGroup_Share]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareGroup_Share]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareGroup]'))
ALTER TABLE [dbo].[ShareGroup]  WITH CHECK ADD  CONSTRAINT [FK_ShareGroup_Share] FOREIGN KEY([ShareID])
REFERENCES [dbo].[Share] ([ShareID])
GO
ALTER TABLE [dbo].[ShareGroup] CHECK CONSTRAINT [FK_ShareGroup_Share]
GO
/****** Object:  ForeignKey [FK_ShareUser_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareUser_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareUser]'))
ALTER TABLE [dbo].[ShareUser]  WITH CHECK ADD  CONSTRAINT [FK_ShareUser_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[ShareUser] CHECK CONSTRAINT [FK_ShareUser_LoginUser]
GO
/****** Object:  ForeignKey [FK_ShareUser_Share]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ShareUser_Share]') AND parent_object_id = OBJECT_ID(N'[dbo].[ShareUser]'))
ALTER TABLE [dbo].[ShareUser]  WITH CHECK ADD  CONSTRAINT [FK_ShareUser_Share] FOREIGN KEY([ShareID])
REFERENCES [dbo].[Share] ([ShareID])
GO
ALTER TABLE [dbo].[ShareUser] CHECK CONSTRAINT [FK_ShareUser_Share]
GO
/****** Object:  ForeignKey [FK_Tutorial_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tutorial_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tutorial]'))
ALTER TABLE [dbo].[Tutorial]  WITH CHECK ADD  CONSTRAINT [FK_Tutorial_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[Tutorial] CHECK CONSTRAINT [FK_Tutorial_LoginUser]
GO
/****** Object:  ForeignKey [FK_Tutorial_TutorialType]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Tutorial_TutorialType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Tutorial]'))
ALTER TABLE [dbo].[Tutorial]  WITH CHECK ADD  CONSTRAINT [FK_Tutorial_TutorialType] FOREIGN KEY([TutorialTypeID])
REFERENCES [dbo].[TutorialType] ([TutorialTypeID])
GO
ALTER TABLE [dbo].[Tutorial] CHECK CONSTRAINT [FK_Tutorial_TutorialType]
GO
/****** Object:  ForeignKey [FK_User_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_LoginUser]
GO
/****** Object:  ForeignKey [FK_UserEducation_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserEducation_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserEducation]'))
ALTER TABLE [dbo].[UserEducation]  WITH CHECK ADD  CONSTRAINT [FK_UserEducation_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[UserEducation] CHECK CONSTRAINT [FK_UserEducation_LoginUser]
GO
/****** Object:  ForeignKey [FK_UserExam_Exam]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserExam_Exam]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExam]'))
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD  CONSTRAINT [FK_UserExam_Exam] FOREIGN KEY([ExamID])
REFERENCES [dbo].[Exam] ([ExamID])
GO
ALTER TABLE [dbo].[UserExam] CHECK CONSTRAINT [FK_UserExam_Exam]
GO
/****** Object:  ForeignKey [FK_UserExam_LoginUser]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_UserExam_LoginUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserExam]'))
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD  CONSTRAINT [FK_UserExam_LoginUser] FOREIGN KEY([LoginUserID])
REFERENCES [dbo].[LoginUser] ([LoginUserID])
GO
ALTER TABLE [dbo].[UserExam] CHECK CONSTRAINT [FK_UserExam_LoginUser]
GO
/****** Object:  ForeignKey [FK_Widget_Page]    Script Date: 08/14/2010 17:31:00 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Widget_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[Widget]'))
ALTER TABLE [dbo].[Widget]  WITH CHECK ADD  CONSTRAINT [FK_Widget_Page] FOREIGN KEY([PageID])
REFERENCES [dbo].[WidgetPage] ([PageID])
GO
ALTER TABLE [dbo].[Widget] CHECK CONSTRAINT [FK_Widget_Page]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Profile_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Profile_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Roles_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_CheckSchemaVersion] TO [aspnet_WebEvent_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_ChangePasswordQuestionAndAnswer] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_CreateUser] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_FindUsersByEmail] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_FindUsersByName] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetAllUsers] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetNumberOfUsersOnline] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetNumberOfUsersOnline] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetPassword] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetPasswordWithFormat] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByEmail] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByEmail] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByName] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByName] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByUserId] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_GetUserByUserId] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_ResetPassword] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_SetPassword] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_UnlockUser] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_UpdateUser] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Membership_UpdateUserInfo] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Paths_CreatePath] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Personalization_GetApplicationId] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAdministration_DeleteAllState] TO [aspnet_Personalization_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAdministration_FindState] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAdministration_GetCountOfState] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAdministration_ResetSharedState] TO [aspnet_Personalization_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAdministration_ResetUserState] TO [aspnet_Personalization_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAllUsers_GetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAllUsers_ResetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationAllUsers_SetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationPerUser_GetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationPerUser_ResetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_PersonalizationPerUser_SetPageSettings] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_DeleteInactiveProfiles] TO [aspnet_Profile_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_DeleteProfiles] TO [aspnet_Profile_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_GetNumberOfInactiveProfiles] TO [aspnet_Profile_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_GetProfiles] TO [aspnet_Profile_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_GetProperties] TO [aspnet_Profile_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Profile_SetProperties] TO [aspnet_Profile_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Profile_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Profile_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Roles_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_RegisterSchemaVersion] TO [aspnet_WebEvent_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Roles_CreateRole] TO [aspnet_Roles_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Roles_DeleteRole] TO [aspnet_Roles_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Roles_GetAllRoles] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Roles_RoleExists] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Membership_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Membership_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Personalization_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Profile_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Profile_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Roles_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UnRegisterSchemaVersion] TO [aspnet_WebEvent_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_Users_DeleteUser] TO [aspnet_Membership_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_AddUsersToRoles] TO [aspnet_Roles_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_FindUsersInRole] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_GetRolesForUser] TO [aspnet_Roles_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_GetRolesForUser] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_GetUsersInRoles] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_IsUserInRole] TO [aspnet_Roles_BasicAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_IsUserInRole] TO [aspnet_Roles_ReportingAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_UsersInRoles_RemoveUsersFromRoles] TO [aspnet_Roles_FullAccess]
GO
GRANT EXECUTE ON [dbo].[aspnet_WebEvent_LogEvent] TO [aspnet_WebEvent_FullAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Applications] TO [aspnet_Membership_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Applications] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Applications] TO [aspnet_Profile_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Applications] TO [aspnet_Roles_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_MembershipUsers] TO [aspnet_Membership_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Profiles] TO [aspnet_Profile_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Roles] TO [aspnet_Roles_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Users] TO [aspnet_Membership_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Users] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Users] TO [aspnet_Profile_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_Users] TO [aspnet_Roles_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_UsersInRoles] TO [aspnet_Roles_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_WebPartState_Paths] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_WebPartState_Shared] TO [aspnet_Personalization_ReportingAccess]
GO
GRANT SELECT ON [dbo].[vw_aspnet_WebPartState_User] TO [aspnet_Personalization_ReportingAccess]
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_BasicAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Membership_BasicAccess', @membername=N'aspnet_Membership_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Membership_ReportingAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Membership_ReportingAccess', @membername=N'aspnet_Membership_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_BasicAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Personalization_BasicAccess', @membername=N'aspnet_Personalization_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Personalization_ReportingAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Personalization_ReportingAccess', @membername=N'aspnet_Personalization_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_BasicAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Profile_BasicAccess', @membername=N'aspnet_Profile_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Profile_ReportingAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Profile_ReportingAccess', @membername=N'aspnet_Profile_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_BasicAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Roles_BasicAccess', @membername=N'aspnet_Roles_FullAccess'

END
GO
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'aspnet_Roles_ReportingAccess')
BEGIN
EXEC sys.sp_addrolemember @rolename=N'aspnet_Roles_ReportingAccess', @membername=N'aspnet_Roles_FullAccess'

END
GO
