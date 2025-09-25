using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    internal class DentistaMap : EntityTypeConfiguration<Dentista>
    {
        public DentistaMap()
        {
            this.ToTable("Dentista");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_DENTITSTA");
            this.Property(x => x.Nome).HasColumnName("NOME_DENTITSTA").IsRequired().HasMaxLength(100);
            this.Property(x => x.Cro).HasColumnName("CRO").IsRequired().HasMaxLength(15);
            this.Property(x => x.Especialidade).HasColumnName("ESPECIALIDADE_DENTISTA").IsRequired().HasMaxLength(50);
            this.Property(x => x.Telefone).HasColumnName("TELEFONE_DENTISTA").IsRequired();
            this.Property(x => x.Email).HasColumnName("EMAIL_DENTISTA").IsRequired().HasMaxLength(100);
            this.Property(d => d.Celular).HasColumnName("CELULAR_DENTISTA").IsRequired();
        }
    }
}
