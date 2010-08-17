using System;using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BusinessLogic;
//using System.Net.Mail;
using System.Web.Mail;
using System.Configuration;
using System.IO;
using System.Web;
namespace BusinessLogic
{
    public class EmailController
    {
        public bool EmailSend(string from, string to, string messagebody, string strSubject)
        {
            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                string Subject = strSubject;
                msg.To.Add(new System.Net.Mail.MailAddress(to));
                msg.Subject = Subject;
                msg.Body = messagebody;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress(from);
                msg.Priority = System.Net.Mail.MailPriority.Normal;
                System.Net.Mail.SmtpClient mSmtpClient = new System.Net.Mail.SmtpClient();
                mSmtpClient.Host = ConfigurationSettings.AppSettings["SMTPserver"].ToString();
                // Send the mail message
                mSmtpClient.Send(msg);
                //SmtpClient.  .SmtpServer = ConfigurationSettings.AppSettings["SMTPserver"].ToString();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public string TemplateEmail(string templateName)
        {
            try
            {
                string messagebody = File.ReadAllText(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["EmailTempletePath"]) + templateName);
                return messagebody;
            }
            catch (Exception e)
            {
                return "";
            }
        }
    }
}
