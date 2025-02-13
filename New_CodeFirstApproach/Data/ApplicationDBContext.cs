using Microsoft.EntityFrameworkCore;
using New_CodeFirstApproach.Model.Entities;

namespace New_CodeFirstApproach.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Candidate> Candidates { get; set; }    //Represent of table
    }
}
