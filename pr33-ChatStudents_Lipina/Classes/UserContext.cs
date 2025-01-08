using Microsoft.EntityFrameworkCore;
using pr33_ChatStudents_Lipina.Classes.Common;
using pr33_ChatStudents_Lipina.Models;

namespace pr33_ChatStudents_Lipina.Classes
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UsersContext() =>
            Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Config.config);


    }
}
