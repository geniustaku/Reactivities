using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }
          //Activities down there is the name of the table in the database
        public  DbSet<Activity> Activities{ get; set; }
    }
   
}