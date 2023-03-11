using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Pessoa
    {
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        private string CPF { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
        }
    }
}
