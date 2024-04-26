using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PimProject.Application.Domain.Aggregates;

namespace PimProject.Application.Infra.Data.DBContext
{
    public class PimProjectDbContext : DbContext
    {
        public static string schema => "pim";
        public DbSet<Colaboradores> Colaboradores { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Produção> Produção { get; set; }
        public DbSet<Vendas> Vendas { get; set; }

        public PimProjectDbContext(DbContextOptions<PimProjectDbContext> options): base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.Entity<Colaboradores>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<Fornecedores>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<Produção>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<Vendas>().Property(x => x.Id).HasDefaultValue("NEWID()");

            base.OnModelCreating(modelBuilder);
        }

        public class IntegrationContextFactory : IDesignTimeDbContextFactory<PimProjectDbContext>
        {
            public PimProjectDbContext CreateDbContext(string[] args)
            {
                var optionBuilder = new DbContextOptionsBuilder<PimProjectDbContext>();

               optionBuilder.UseSqlServer("Data Source=localhost;Database=Pim_III;Trusted_Connection=True;Trust Server Certificate = true;");

                return new PimProjectDbContext(optionBuilder.Options);
            }
        }

    }
}
