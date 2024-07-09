using MMNCleanArch.TicketManagement.Application.Models.Mail;

namespace MMNCleanArch.TicketManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
