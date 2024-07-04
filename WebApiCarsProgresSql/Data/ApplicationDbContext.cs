

namespace WebApiCarsProgresSql.Data
{

    using Microsoft.EntityFrameworkCore;
    using WebApiCarsProgresSql.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
   
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

         public DbSet<Car> Cars { get; set; }
    }
}
