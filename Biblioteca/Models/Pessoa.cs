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

        string Email { get; set; }
        private string Senha { get; set; }
        string Telefone { get; set; }



        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime dataNascimento, string cPF, string email, string senha, string telefone)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cPF;
            Email = email;
            Senha = senha;
            Telefone = telefone;
        }
    }
}
