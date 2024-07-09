using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MMNCleanArch.TicketManagement.Identity.Models;

namespace MMNCleanArch.TicketManagement.Identity
{
    public class FirstRowTicketsIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public FirstRowTicketsIdentityDbContext()
        {

        }

        public FirstRowTicketsIdentityDbContext(DbContextOptions<FirstRowTicketsIdentityDbContext> options) : base(options)
        {
        }
    }
}
