using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yuri Martinelli

namespace ProjetoFinalBiblioteca
{
    public class Revista : Exemplar
    {
        public int Edicao { get; set; }
        public int Paginas { get; set; }
        public Revista()
        {
        }
        public Revista(string titulo, string autor, int anoPublicacao, int edicao, int paginas)
        {
            Edicao = edicao;
            Paginas = paginas;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
