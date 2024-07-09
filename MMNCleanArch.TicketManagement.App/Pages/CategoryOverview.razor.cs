﻿using Microsoft.AspNetCore.Components;
using MMNCleanArch.TicketManagement.App.Contracts;
using MMNCleanArch.TicketManagement.App.ViewModels;

namespace MMNCleanArch.TicketManagement.App.Pages
{
    public partial class CategoryOverview
    {
        [Inject]
        public ICategoryDataService CategoryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public ICollection<CategoryEventsViewModel> Categories { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Categories = await CategoryDataService.GetAllCategoriesWithEvents(false);
        }

        protected async void OnIncludeHistoryChanged(ChangeEventArgs args)
        {
            if ((bool)args.Value)
            {
                Categories = await CategoryDataService.GetAllCategoriesWithEvents(true);
            }
            else
            {
                Categories = await CategoryDataService.GetAllCategoriesWithEvents(false);
            }
        }
    }
}