using MMNCleanArch.TicketManagement.App.Services;
using MMNCleanArch.TicketManagement.App.Services.Base;
using MMNCleanArch.TicketManagement.App.ViewModels;

namespace MMNCleanArch.TicketManagement.App.Contracts
{
    public interface ICategoryDataService
    {
        Task<List<CategoryViewModel>> GetAllCategories();
        Task<List<CategoryEventsViewModel>> GetAllCategoriesWithEvents(bool includeHistory);
        Task<ApiResponse<CategoryDto>> CreateCategory(CategoryViewModel categoryViewModel);
    }
}
