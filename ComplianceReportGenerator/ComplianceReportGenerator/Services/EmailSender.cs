using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace AspNetCoreEmailConfirmationSendGrid.Services
{
    public class EmailSender : IEmailSender
    {
        private string _sendgridApiKey;

        public EmailSender(string sendgridApiKey)
        {
            _sendgridApiKey = sendgridApiKey;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
    
            return Execute(_sendgridApiKey, subject, htmlMessage, email);
        }

        public Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("crgsquad2022@gmail.com", "ComplianceReportGenerator via SendGrid"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }
    }
}
