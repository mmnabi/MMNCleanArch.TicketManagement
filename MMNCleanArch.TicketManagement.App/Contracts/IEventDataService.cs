using MMNCleanArch.TicketManagement.App.Services.Base;
using MMNCleanArch.TicketManagement.App.ViewModels;

namespace MMNCleanArch.TicketManagement.App.Contracts
{
    public interface IEventDataService
    {
        Task<List<EventListViewModel>> GetAllEvents();
        Task<EventDetailViewModel> GetEventById(Guid id);
        Task<ApiResponse<Guid>> CreateEvent(EventDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> UpdateEvent(EventDetailViewModel eventDetailViewModel);
        Task<ApiResponse<Guid>> DeleteEvent(Guid id);
    }
}
