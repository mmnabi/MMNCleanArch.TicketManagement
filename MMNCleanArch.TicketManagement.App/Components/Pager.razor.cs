﻿using Microsoft.AspNetCore.Components;

namespace MMNCleanArch.TicketManagement.App.Components
{
    public partial class Pager
    {
        [Parameter]
        public int PageIndex { get; set; }

        [Parameter]
        public int TotalPages { get; set; }

        [Parameter]
        public bool HasPreviousPage { get; set; }

        [Parameter]
        public bool HasNextPage { get; set; }

        [Parameter]
        public EventCallback<int> OnClick { get; set; }
    }
}
