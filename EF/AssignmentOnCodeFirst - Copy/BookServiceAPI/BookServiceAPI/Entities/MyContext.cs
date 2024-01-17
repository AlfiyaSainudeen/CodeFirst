using Microsoft.EntityFrameworkCore;

namespace BookServiceAPI.Entities
{
    public class MyContext : DbContext
    {
        private readonly IConfiguration configuration;

        public MyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public DbSet<Book> Books { get; set; }

        //confine connect

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=INTERNS112\SQL2022;Initial Catalog=TrainingDB;Persist Security Info=True;User ID=sa;Password=Password123.;Encrypt=True;Trust Server Certificate=True");

            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }
    }
}
