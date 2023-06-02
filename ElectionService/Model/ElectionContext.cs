using Microsoft.EntityFrameworkCore;

namespace ElectionService.Model
{
    public class ElectionContext : DbContext 
    {
        public ElectionContext(DbContextOptions<ElectionContext> options): base(options){}
        public DbSet<Bulletin>Bulletins { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<Liste> Listes { get; set; }
        public DbSet<Suffrage> Suffrages { get; set; }
    }
}
