using System.Net.Mail;
using System.Net;

namespace LCPSoftwareSolutions.Utilities
{
    public class Notificcion
    {
        public void SendEmail(string EmailTo, string Code)
        {
            try
            {
                string? HostMail = "smtp-relay.sendinblue.com";
                string? PortMail = "587";
                string? UserMail = "lcpdesarrollos@gmail.com";
                string? PasswordMail = "nXr7aFcMkj5Hf0Lg";

                using (var smtpClient = new SmtpClient())
                {
                    NetworkCredential credential = new NetworkCredential();
                    credential.UserName = UserMail;
                    credential.Password = PasswordMail;

                    smtpClient.Credentials = credential;
                    smtpClient.Host = HostMail;
                    smtpClient.Port = Convert.ToInt32(PortMail);
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;

                    //string BodyHtml = _templateRepository.GetTemplateByName("TemplateSendCodeAuth");
                    //string User = EmailTo.Split("@")[0];
                    //BodyHtml = BodyHtml.Replace("{@User}", User);
                    //BodyHtml = BodyHtml.Replace("{@Code}", Code);


                    MailMessage message = new MailMessage(UserMail, EmailTo);
                    message.Subject = "";
                    message.IsBodyHtml = true;
                    message.Body = "";

                    smtpClient.Send(message);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
