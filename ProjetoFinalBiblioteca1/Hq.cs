using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yuri Martinelli

namespace ProjetoFinalBiblioteca
{
    public class Hq : Exemplar
    {
        public int Edicao { get; set; }
        public string Ilustrador { get; set; }
        public Hq()
        {
        }
        public Hq(string titulo, string autor,int edicao,string ilustrador)
        {
            Edicao = edicao;
            Ilustrador = ilustrador;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
