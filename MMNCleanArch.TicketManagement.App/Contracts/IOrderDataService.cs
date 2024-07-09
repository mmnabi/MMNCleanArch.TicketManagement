using MMNCleanArch.TicketManagement.App.ViewModels;

namespace MMNCleanArch.TicketManagement.App.Contracts
{
    public interface IOrderDataService
    {
        Task<PagedOrderForMonthViewModel> GetPagedOrderForMonth(DateTime date, int page, int size);
    }
}
