using Microsoft.EntityFrameworkCore;

namespace Friends_info.Data.Context
{
    public class Friends_infoDbContext : DbContext
    {
        public Friends_infoDbContext(DbContextOptions<Friends_infoDbContext> options) : base(options)
        {
            
        }
        public DbSet<Friend> Friends { get; set; }
    } 
}
