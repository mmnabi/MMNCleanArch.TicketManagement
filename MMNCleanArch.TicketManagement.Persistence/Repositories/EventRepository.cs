using MMNCleanArch.TicketManagement.Application.Contracts.Persistence;
using MMNCleanArch.TicketManagement.Domain.Entities;

namespace MMNCleanArch.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        public EventRepository(FirstRowTicketsDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matches);
        }
    }
}
