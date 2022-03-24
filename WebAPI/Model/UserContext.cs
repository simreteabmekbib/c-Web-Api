using Microsoft.EntityFrameworkCore;

namespace WebAPI.Model
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options){}
     
        public DbSet<User> User { get; set; }
    }
}
