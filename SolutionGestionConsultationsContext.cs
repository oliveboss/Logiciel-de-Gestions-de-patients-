using Microsoft.EntityFrameworkCore;
using SolutionGestionConsultations.Core.Entities;

namespace SolutionGestionConsultations.Infrastructure
{
    public class SolutionGestionConsultationsContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<DossierMédical> DossiersMédicals { get; set; }

        // Constructeur avec options pour le contexte
        public SolutionGestionConsultationsContext(DbContextOptions<SolutionGestionConsultationsContext> options)
            : base(options)
        { }

        // Constructeur pour configurer la chaîne de connexion à SQL Server
        public SolutionGestionConsultationsContext() : base(new DbContextOptionsBuilder<SolutionGestionConsultationsContext>()
            .UseSqlServer(@"Server=OLIVE_COMPUTER\sqlexpress;Database=GestionConsultations;Integrated Security=True;TrustServerCertificate=True;")
            .Options)
        { }
    }
}
