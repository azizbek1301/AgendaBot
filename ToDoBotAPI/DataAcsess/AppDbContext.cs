using Microsoft.EntityFrameworkCore;
using ToDoBotAPI.Models;

namespace ToDoBotAPI.DataAcsess
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TaskToDo> TaskToDo { get; set; }
    }
}
