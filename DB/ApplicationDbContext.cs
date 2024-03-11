using Microsoft.EntityFrameworkCore;

namespace DbASP_NET_11_03_2024.DB
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Transistors> Transistors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            string? connectionSring = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionSring);
        }
    }
}
