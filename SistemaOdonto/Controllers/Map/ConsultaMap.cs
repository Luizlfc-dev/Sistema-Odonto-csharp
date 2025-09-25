using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    internal class ConsultaMap : EntityTypeConfiguration<Consulta>
    {
        public ConsultaMap()
        { 
        this.ToTable("Consulta");
        this.HasKey(d => d.IdConsulta);
        this.Property(d => d.IdConsulta).HasColumnName("ID_CONSULTA");
        this.Property(d => d.IdPaciente).HasColumnName("ID_PACIENTE").IsRequired();
        this.Property(d => d.IdDentista).HasColumnName("ID_DENTISTA").IsRequired();
        this.Property(d => d.Data).HasColumnName("DATA_CONSULTA").IsRequired();
        this.Property(d => d.HoraMarcada).HasColumnName("HORA_MARCADA").IsRequired();
        this.Property(d => d.HoraInicio).HasColumnName("HORA_INICIO");
        this.Property(d => d.HoraFim).HasColumnName("HORA_FIM");
        this.Property(d => d.Observacao).HasColumnName("OBSERVACAO_CONSULTA").IsRequired().HasMaxLength(500);
        this.Property(d => d.Status).HasColumnName("STATUS_CONSULTA").IsRequired().HasMaxLength(20);

        }
    }
}
