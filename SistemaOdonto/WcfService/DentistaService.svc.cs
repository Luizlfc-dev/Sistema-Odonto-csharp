using System;
using Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Controllers.Repositorios;
using Entidades;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class DentistaService : iDentista
    {
        private DentistaRep rep = new DentistaRep();

        public void Cadastrar(Dentista obj)
        {
            rep.Cadastrar(obj);
        }
        public Dentista Buscar(int id)
        {
            return rep.Buscar(id);
        }
        public List<Dentista> Listar()
        {
            return rep.Listar();
        }
        public void Editar(Dentista objNovo)
        {
            rep.Editar(objNovo);
        }
        public void Excluir(int id)
        {
            rep.Excluir(id);
        }
        
    }
}
