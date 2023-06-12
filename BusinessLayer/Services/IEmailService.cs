namespace MVC_Example.BusinessLayer.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toAddress, string subject, string body);
    }
}