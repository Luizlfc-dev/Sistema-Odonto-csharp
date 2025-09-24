using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using Controllers.Map;

namespace Controllers.Context
{
    internal class SistemaContext : DbContext
    {
        public SistemaContext() : base("server=DESKTOP-FTQ8NT7\\SQLEXPRESS01; Database=Sistema_Odonto; Integrated Security = True; ")    
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
