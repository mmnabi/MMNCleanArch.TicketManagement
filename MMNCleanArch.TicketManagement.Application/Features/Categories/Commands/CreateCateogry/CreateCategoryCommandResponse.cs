using MMNCleanArch.TicketManagement.Application.Responses;

namespace MMNCleanArch.TicketManagement.Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateCategoryCommandResponse : BaseResponse
    {
        public CreateCategoryCommandResponse() : base()
        {

        }

        public CreateCategoryDto Category { get; set; } = default!;
    }
}