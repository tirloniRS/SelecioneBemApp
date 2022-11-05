using Microsoft.EntityFrameworkCore;
using SelecioneBemApp.Models;

namespace SelecioneBemApp.Data
{
    public class SelecioneBemAppContext : DbContext
    {
        public SelecioneBemAppContext (DbContextOptions<SelecioneBemAppContext> options) : base(options)
        {

        }
        public DbSet<Candidate> Candidate { get; set; } = default!;
        public DbSet<Competence> Competence { get; set; } = default!;
        public DbSet<Interview> Interview { get; set; } = default!;
        public DbSet<Opportunity> Opportunity { get; set; } = default!;
        public DbSet<Question> Question { get; set; } = default!;

    }
}
