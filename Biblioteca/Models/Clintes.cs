using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Clintes : Pessoa
    {
        private int Id { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Lougradouro { get; set; }

        public Clintes(int id, string bairro, string cidade, string estado, string lougradouro)
        {
            Id = id;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Lougradouro = lougradouro;
        }

        

        
    }
}
