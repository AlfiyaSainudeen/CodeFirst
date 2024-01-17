using Microsoft.EntityFrameworkCore;

namespace BookServiceAPIUsingCodeFirst.Entities
{
    public class MyContext:DbContext
    {
        public DbSet<Book> Book { get; set; }

        //confine connect
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       
        {
            optionsBuilder.UseSqlServer(@"Data Source=INTERNS112\SQL2022;Initial Catalog=TrainingDB;Persist Security Info=True;User ID=sa;Password=Password123.;Encrypt=True;Trust Server Certificate=True");

            //base.OnConfiguring(optionsBuilder);
        }
    }
}
