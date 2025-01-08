using Microsoft.EntityFrameworkCore;
using pr33_ChatStudents_Lipina.Classes.Common;
using pr33_ChatStudents_Lipina.Models;

namespace pr33_ChatStudents_Lipina.Classes
{
    public class MessagesContext : DbContext
    {
        public DbSet<Messages> Messages { get; set; }
        public MessagesContext() =>
            Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(Config.config);
    }
}
