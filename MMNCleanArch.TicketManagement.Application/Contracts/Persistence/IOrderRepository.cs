using MMNCleanArch.TicketManagement.Domain.Entities;

namespace MMNCleanArch.TicketManagement.Application.Contracts.Persistence
{

    public interface IOrderRepository : IAsyncRepository<Order>
    {

    }
}
