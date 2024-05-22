using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yuri Martinelli

namespace ProjetoFinalBiblioteca
{
    public class Ebook : Livro
    {
        public decimal Tamanho { get; set; }
        public string Url { get; set; }
        public Ebook()
        {
        }
        public Ebook(string titulo, string autor, int anoPublicacao, int paginas, string tipoCapa, string isbn, decimal tamanho, string url)
        {
            Tamanho = tamanho;
            Url = url;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
