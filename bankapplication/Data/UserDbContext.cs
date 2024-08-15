using Microsoft.EntityFrameworkCore;

namespace bankapplication.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseMySql(
        //            "Server=127.0.0.1;Database=mydatabase;User=root;Password=rootpassword;",
        //            new MySqlServerVersion(new Version(8, 0, 32))
        //        );
        //    }
        //    //optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=mydatabase;User=root;Password=rootpassword");
        //}
    }
}

