using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PimProject.Application.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimProject.Application.Infra.Data.Configurations
{
    public class ColaboradoresConfiguration : IEntityTypeConfiguration<Colaboradores>
    {
        public void Configure(EntityTypeBuilder<Colaboradores> builder)
        {
            builder.ToTable(name: nameof(Colaboradores));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Nome).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Data_Nascimento).HasMaxLength(128).IsRequired();
            builder.Property(x => x.CPF).HasMaxLength(128).IsRequired();

        }



    }
}
