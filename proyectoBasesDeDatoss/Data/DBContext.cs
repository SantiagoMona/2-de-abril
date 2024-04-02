using Microsoft.EntityFrameworkCore;
using proyectoBasesDeDatoss.Moldels;

namespace proyectoBasesDeDatossa.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            
        }
        public DbSet <User> Users {get; set;}
    }
}