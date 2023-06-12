
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MVC_Example.BusinessLayer.Services
{
    public class EmailService : IEmailService
{
    private readonly SmtpClient _smtpClient;

    public EmailService(string host, int port, string username, string password)
    {
        _smtpClient = new SmtpClient(host, port)
        {
            Credentials = new NetworkCredential(username, password),
            EnableSsl = true
        };
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        MailMessage mailMessage = new MailMessage
        {
            From = new MailAddress("noreply@example.com"),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };
        mailMessage.To.Add(to);

        await _smtpClient.SendMailAsync(mailMessage);
    }
}
}