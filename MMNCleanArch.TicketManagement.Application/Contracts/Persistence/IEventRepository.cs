using MMNCleanArch.TicketManagement.Domain.Entities;

namespace MMNCleanArch.TicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);

    }
}
