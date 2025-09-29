using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface iDentista
    {
        [OperationContract]
        void Cadastrar(Dentista obj);

        [OperationContract]
        Dentista Buscar(int id);
        [OperationContract]
        List<Dentista> Listar();
        [OperationContract]
        void Editar(Dentista objNovo);
        [OperationContract]
        void Excluir(int id);





    }
}
