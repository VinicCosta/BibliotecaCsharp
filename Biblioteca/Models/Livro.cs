using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Livro
    {
        public int IdLivro { get; }
        public string Nome { get; set; }
        public int Paginas { get; set; }
        public int Quantidade { get; set; }
        public string Genero { get; set; }

        public Livro(int idLivro, string nome, int paginas, int quantidade, string genero)
        {
            IdLivro = idLivro;
            Nome = nome;
            Paginas = paginas;
            Quantidade = quantidade;
            Genero = genero;
        }
    }
}
