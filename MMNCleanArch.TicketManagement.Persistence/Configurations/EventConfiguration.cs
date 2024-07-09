using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMNCleanArch.TicketManagement.Domain.Entities;

namespace MMNCleanArch.TicketManagement.Persistence.Configurations
{
    public class EventConfiguration
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);


        }
    }
}
