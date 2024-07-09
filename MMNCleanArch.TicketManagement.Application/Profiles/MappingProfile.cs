using AutoMapper;
using MMNCleanArch.TicketManagement.Application.Features.Categories.Commands.CreateCateogry;
using MMNCleanArch.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using MMNCleanArch.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using MMNCleanArch.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using MMNCleanArch.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using MMNCleanArch.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using MMNCleanArch.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using MMNCleanArch.TicketManagement.Domain.Entities;

namespace MMNCleanArch.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

        }
    }
}
