using System;
using Entidades;
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
            this.Property(d => d.Telefone).HasColumnName("TELEFONE_PACIENTE").IsRequired();
            this.Property(d => d.Celular).HasColumnName("CELULAR_PACIENTE").IsRequired();
            this.Property(d => d.Email).HasColumnName("EMAIL_PACIENTE").IsRequired().HasMaxLength(100);
            this.Property(d => d.DataNascimento).HasColumnName("DATA_NASCIMENTO_PACIENTE").IsRequired();
            this.Property(d => d.Endereco).HasColumnName("ENDERECO_PACIENTE").IsRequired().HasMaxLength(14);
            this.Property(d => d.Complemento).HasColumnName("COMPLEMENTO_ENDERECO_PACIENTE").IsRequired().HasMaxLength(50);
            this.Property(d => d.Cep).HasColumnName("CEP_PACIENTE").IsRequired().HasMaxLength(10);
            this.Property(d => d.Sexo).HasColumnName("SEXO_PACIENTE").IsRequired().HasMaxLength(10);

        }



    }
}
