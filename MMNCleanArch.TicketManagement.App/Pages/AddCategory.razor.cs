using Microsoft.AspNetCore.Components;
using MMNCleanArch.TicketManagement.App.Contracts;
using MMNCleanArch.TicketManagement.App.Services;
using MMNCleanArch.TicketManagement.App.Services.Base;
using MMNCleanArch.TicketManagement.App.ViewModels;

namespace MMNCleanArch.TicketManagement.App.Pages
{
    public partial class AddCategory
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryViewModel CategoryViewModel { get; set; }
        public string Message { get; set; }

        protected override void OnInitialized()
        {
            CategoryViewModel = new CategoryViewModel();
        }

        protected async Task HandleValidSubmit()
        {
            var response = await CategoryDataService.CreateCategory(CategoryViewModel);
            HandleResponse(response);
        }

        private void HandleResponse(ApiResponse<CategoryDto> response)
        {
            if (response.Success)
            {
                Message = "Category added";
            }
            else
            {
                Message = response.Message;
                if (!string.IsNullOrEmpty(response.ValidationErrors))
                    Message += response.ValidationErrors;
            }
        }
    }
}
