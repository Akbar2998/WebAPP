using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5DVR9HH\\SQLEXPRESS;DataBase=CodeFirstDB; Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
