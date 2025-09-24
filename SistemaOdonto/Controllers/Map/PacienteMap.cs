using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    internal class PacienteMap : EntityTypeConfiguration<Paciente>
    {
      public PacienteMap() {
            this.ToTable("Paciente");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_PACIENTE");
            this.Property(d => d.Nome).HasColumnName("NOME_PACIENTE").IsRequired().HasMaxLength(100);
            this.Property(d => d.Telefone).HasColumnName("TELEFONE_PACIENTE").IsRequired().HasMaxLength(15);
            this.Property(d => d.Celular).HasColumnName("CELULAR_PACIENTE").IsRequired().HasMaxLength(15);
            this.Property(d => d.Email).HasColumnName("EMAIL_PACIENTE").IsRequired().HasMaxLength(100);


        }



    }
}
