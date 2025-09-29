using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        }
        public Dentista Buscar(int id)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemaContext())
            { 
                obj = ctx.Dentistas.Find(id);
            }
            return obj;
        }
        public List<Dentista> Listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas
                               select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
        }
        public void Editar(Dentista objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista objAntigo = ctx.Dentistas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Cro = objNovo.Cro;
                objAntigo.Especialidade = objNovo.Especialidade;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Email = objNovo.Email;
                objAntigo.Celular = objNovo.Celular;
                ctx.SaveChanges();
            }
        }
        public void Excluir(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }



    }
}
