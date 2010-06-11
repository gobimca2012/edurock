﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataEntity;
using System.Diagnostics;
namespace BusinessLogic
{
    public class EXM_AnswerController
    {


        #region AutoGenerated

        public List<EXM_Answer> GetbyEXM_AnswerID(int EXM_AnswerID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyEXM_AnswerID(EXM_AnswerID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyEXM_QuestionID(int EXM_QuestionID, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyEXM_QuestionID(EXM_QuestionID, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyAnswer(string Answer, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyAnswer(Answer, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyIsRight(bool IsRight, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyIsRight(IsRight, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyModifiedDate(DateTime ModifiedDate, int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyModifiedDate(ModifiedDate, PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }



        public List<EXM_Answer> GetbyEXM_AnswerID(int EXM_AnswerID)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyEXM_AnswerID(EXM_AnswerID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyEXM_QuestionID(int EXM_QuestionID)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyEXM_QuestionID(EXM_QuestionID);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyAnswer(string Answer)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyAnswer(Answer);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyIsRight(bool IsRight)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyIsRight(IsRight);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> GetbyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                return new DataProvider().EXM_AnswerGetbyModifiedDate(ModifiedDate);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }

        public List<EXM_Answer> Get(int PageSize, int PageNumber)
        {
            try
            {
                return new DataProvider().EXM_AnswerGet(PageSize, PageNumber);
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }
        public List<EXM_Answer> Get()
        {
            try
            {
                return new DataProvider().EXM_AnswerGet();
            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                }
                return new List<EXM_Answer>();
            }
        }



        public bool Add(int EXM_AnswerID, int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().EXM_AnswerAdd(EXM_AnswerID, EXM_QuestionID, Answer, IsRight, ModifiedDate);
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

        



        public bool DeletebyEXM_AnswerID(int EXM_AnswerID)
        {
            try
            {
                new DataProvider().EXM_AnswerDeletebyEXM_AnswerID(EXM_AnswerID);
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


        public bool DeletebyEXM_QuestionID(int EXM_QuestionID)
        {
            try
            {
                new DataProvider().EXM_AnswerDeletebyEXM_QuestionID(EXM_QuestionID);
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


        public bool DeletebyAnswer(string Answer)
        {
            try
            {
                new DataProvider().EXM_AnswerDeletebyAnswer(Answer);
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


        public bool DeletebyIsRight(bool IsRight)
        {
            try
            {
                new DataProvider().EXM_AnswerDeletebyIsRight(IsRight);
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


        public bool DeletebyModifiedDate(DateTime ModifiedDate)
        {
            try
            {
                new DataProvider().EXM_AnswerDeletebyModifiedDate(ModifiedDate);
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




        public bool UpdateByEXM_AnswerID(int EXM_AnswerID, int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {

            try
            {
                new DataProvider().EXM_AnswerUpdateByEXM_AnswerID(EXM_AnswerID, EXM_QuestionID, Answer, IsRight, ModifiedDate);
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






        #endregion
        #region EXM_Answer
        public bool IsRightAnswerAdded(int QuestionID)
        {
            try
            {
                return new DataProvider().IsRightAnswerAdded(QuestionID);
            }
            catch
            {
                return false;
            }
        }
        public Dictionary<string,string> Add(int EXM_QuestionID, string Answer, bool IsRight, DateTime ModifiedDate)
        {
            Dictionary<string, string> Status = new Dictionary<string, string>();
            try
            {
                var data = new EXM_QuestionController().GetbyEXM_QuestionID(EXM_QuestionID);
                if (data[0].Q_Type == (int)QuestionType.SingleChoice || data[0].Q_Type == (int)QuestionType.SingleFillintheBlanks)
                {
                    if (IsRight && IsRightAnswerAdded(EXM_QuestionID))
                    {
                        Status.Add("ID", " 0");
                        Status.Add("Error", "You allready Added Right Answer");
                        
                    }
                    else
                    {
                        int AnswerID = new DataProvider().EXM_AnswerAdd(EXM_QuestionID, Answer, IsRight, ModifiedDate);
                        Status.Add("ID", AnswerID.ToString());
                        Status.Add("Error", "");
                        
                    }
                }
                else if (data[0].Q_Type == (int)QuestionType.MultipleChoice || data[0].Q_Type == (int)QuestionType.MultipleFillintheBlanks)
                {
                    if (IsRight && IsRightAnswerAdded(EXM_QuestionID))
                    {
                        Status.Add("ID", " 0");
                        Status.Add("Error", "You allready Added Right Answer");

                    }
                    else
                    {
                        int AnswerID = new DataProvider().EXM_AnswerAdd(EXM_QuestionID, Answer, IsRight, ModifiedDate);
                        Status.Add("ID", AnswerID.ToString());
                        Status.Add("Error", "");

                    }
                }
                return Status;

            }
            catch (Exception ex)
            {
                if (SettingProvider.IsLoggerEnable())
                {
                    StackTrace st = new StackTrace(new StackFrame(true)); Console.WriteLine(" Stack trace for current level: {0}", st.ToString()); StackFrame sf = st.GetFrame(0); string FunctionData = ""; FunctionData += string.Format(" File: {0}", sf.GetFileName()); FunctionData += string.Format(" SaveAnswer: {0}", sf.GetMethod().Name); FunctionData += string.Format(" Line Number: {0}", sf.GetFileLineNumber()); FunctionData += string.Format(" Column Number: {0}", sf.GetFileColumnNumber());
                    Logger.TimeLog.ErrorWrite(FunctionData, ex.Message, "0");
                    Status.Add("ID", " 0");
                    Status.Add("Error", ex.Message);
                }

                return Status;
            }
        }
        #endregion






    }
}
