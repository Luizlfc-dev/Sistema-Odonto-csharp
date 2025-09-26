using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        public void Cadastrar(Dentista obj)
        {
            using(var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                ctx.SaveChanges();
            }
            public Dentista Buscar(int id)
            {
                using (var ctx = new SistemaContext())
                {
                    return ctx.Dentistas.FirstOrDefault(x => x.Id == id);
                }
            }
        }


    }
}
