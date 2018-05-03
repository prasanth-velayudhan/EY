using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace flydubai.Common
{
    public class EmailMapBusinessCommon : IEmailMapBusinessCommon
    {
        private readonly string ContactUsSmtpServer;
        private readonly string ContactUsSmtpUsername;
        private readonly string ContactUsSmtpPassword;
        private readonly string ContactUsSmtpServerPort;
        private readonly string ExceptionMailAddress;
        private readonly string ExceptionMailFromAddress;

        public EmailMapBusinessCommon(string ContactUsSmtpServer, string ContactUsSmtpUsername, string ContactUsSmtpPassword, string ContactUsSmtpServerPort, string ExceptionMailAddress, string ExceptionMailFromAddress)
        {
            this.ContactUsSmtpServer = ContactUsSmtpServer;
            this.ContactUsSmtpUsername = ContactUsSmtpUsername;
            this.ContactUsSmtpPassword = ContactUsSmtpPassword;
            this.ContactUsSmtpServerPort = ContactUsSmtpServerPort;
            this.ExceptionMailAddress = ExceptionMailAddress;
            this.ExceptionMailFromAddress = ExceptionMailFromAddress;
        }

        /// <summary>
        /// Sends the specified recipient email.
        /// </summary>
        /// <param name="recipientEmail">The recipient email.</param>
        /// <param name="emailPoints">The email points.</param>
        /// <returns>boolean</returns>
        public bool Send(string ServerName, string ServerDate, string StackTrace, string GUID, string PrevPage, string path)
        {

            using (var client = new SmtpClient(this.ContactUsSmtpServer, Convert.ToInt32(this.ContactUsSmtpServerPort)))
            {
                if (!string.IsNullOrWhiteSpace(this.ExceptionMailAddress))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(this.ContactUsSmtpUsername, this.ContactUsSmtpPassword);
                }

                //try
                //{
                    using (var message = new MailMessage())
                    {
                        message.From = new MailAddress(this.ExceptionMailFromAddress);                        
                        foreach (var addrs in this.ExceptionMailAddress.Split(';'))
                        {                            
                            message.To.Add(addrs);
                        }
                        
                        message.Subject = "Exception mail";
                        message.IsBodyHtml = true;
                        message.Body = this.getBody(ServerName, ServerDate, StackTrace, GUID, PrevPage, path);
                        //try
                        //{
                            client.Send(message);
                        //}
                        //catch (SmtpException ex)
                        //{
                        //    client.Send(message);
                        //}
                    }
                //}
                //catch (SmtpException ex)
                //{
                //    //return false;
                //}
                //catch (Exception ex)
                //{
                //    //return false;
                //}
            }

            return true;
        }

        private string getBody(string ServerName, string ServerDate, string StackTrace, string GUID, string PrevPage, string path)
        {
            string body = string.Empty;
            string subTable = string.Empty;
            using (StreamReader reader = new StreamReader(path + "template.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{ServerName}", ServerName);
            body = body.Replace("{ServerDate}", ServerDate);            
            body = body.Replace("{GUID}", GUID);
            body = body.Replace("{PrevPage}", PrevPage);
            body = body.Replace("{StackTrace}", StackTrace);
            return body;
        }
    }
}
