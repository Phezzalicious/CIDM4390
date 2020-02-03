using Microsoft.EntityFrameworkCore;
using CodeClub.Models;

namespace CodeClub.Data
{
    public class CodeClubContext : DbContext
    {
        public CodeClubContext (DbContextOptions<CodeClubContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Project> Project { get; set; }
    }
}