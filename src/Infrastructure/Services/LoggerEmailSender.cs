using System.Threading.Tasks;
using Trendora.ApplicationCore.Interfaces;

namespace Trendora.Infrastructure.Services;

public class LoggerEmailSender(IAppLogger<LoggerEmailSender> logger): IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        logger.LogInformation("to: {email}, subject: {emailSubject}, message: {emailMessage}", email, subject, message);
        return Task.CompletedTask;
    }
}

