using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace SolutionGestionConsultations.Infrastructure
{
    public class SolutionGestionConsultationsContextFactory : IDesignTimeDbContextFactory<SolutionGestionConsultationsContext>
    {
        public SolutionGestionConsultationsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SolutionGestionConsultationsContext>();
            optionsBuilder.UseSqlServer(@"Server=OLIVE_COMPUTER\sqlexpress;Database=GestionConsultations;Integrated Security=True;TrustServerCertificate=True;");
            return new SolutionGestionConsultationsContext(optionsBuilder.Options);
        }
    }
}
