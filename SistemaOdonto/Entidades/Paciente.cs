using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string Email { get; set; }
        public string Complemento { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Sexo { get; set; }
    }
}
