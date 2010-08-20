using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    class GlobelEnum
    {
    }
    public enum CookieName
    {
        ExamID=1,
        UserExamID=2

    }
    public enum CatagoryTypeEnum
    {
        CollegeCourceCatagory=1,
        BusinessIndustry=2
    }
    public enum CourceTypeEnum
    {
        Technology=1,
        Business=2
    }
    public enum ObjectEnum
    {
        Question=1

    }
    public enum DocumentTypeEnum
    {
        Document=4,
        Image=1,
        Audio=3,
        Video=2,
        UploadInstitutePic=5,
        EditorPhoto=6
    }
    public enum InstituteCourceUserEnum
    {
        Normal=1
    }
    public enum ContentTypeEnum
    {
        All=0,
        Document = 4,
        Image = 1,
        Audio = 3,
        Video = 2,
        Question=5,
        HomeWork=6,
        Exam=7,
        Article=8,
        Event=9
    }
    public enum AnswerStatusEnum
    {
        Open=0,
        Accepted=1
    }

    public class FileInformation
    {
        public static string getFileExtention(string path)
        {
            string[] parts = path.Split('.');
            string ext = parts[parts.Length - 1];
            return ext;
        }
        public static bool IsImage(string ext)
        {
            bool result = false;
            if (ext.ToLower() == "jpeg" || ext.ToLower() == "jpg" || ext.ToLower() == "png" || ext.ToLower() == "gif")
            {
                result = true;
            }
            return result;
        }
        public static bool IsAudio(string ext)
        {
            bool result = false;
            if (ext.ToLower() == "mp3" )
            {
                result = true;
            }
            return result;
        }
        public static bool IsVideo(string ext)
        {
            bool result = false;
            if (ext.ToLower() == "flv")
            {
                result = true;
            }
            return result;
        }
        public static bool IsDocument(string ext)
        {
            bool result = false;
            if (ext.ToLower() == "pdf" || ext.ToLower() == "txt" || ext.ToLower() == "doc" || ext.ToLower() == "docx")
            {
                result = true;
            }
            return result;
        }
    }
}
