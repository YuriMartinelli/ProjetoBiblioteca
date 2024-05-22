using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yuri Martinelli

namespace ProjetoFinalBiblioteca
{
    public interface ILeitor
    {
        bool EmprestaItem(Exemplar exemplar, Leitor leitorDestino);
        bool DevolveItem(Exemplar exemplar, Leitor leitorDestino);
        bool DoaExemplar(Exemplar exemplar, Leitor leitorDestino);
        bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem);
    }
    public class Leitor : Pessoa, ILeitor
    {
        public List<Exemplar> ExemplaresLeitor { get; set; }
        public List<Emprestimo> EmprestimosLeitor { get; set; }
        public string Tipo { get; set; }

        public Leitor()
        {
            ExemplaresLeitor = new List<Exemplar>();
            EmprestimosLeitor = new List<Emprestimo>();
        }

        public bool EmprestaItem(Exemplar exemplar, Leitor leitordestino) { return true; }
        public bool DevolveItem(Exemplar exemplar, Leitor leitordestino) { return true; }
        public bool DoaExemplar(Exemplar exemplar, Leitor leitordestino) { return true; }
        public bool TrocaExemplar(Exemplar exemplarVai, Leitor leitorVai, Exemplar exemplarVem) { return true; }

        public override string ToString()
        {
            return "";
        }

        public override void ListaLeitor(Leitor leitor) {  }
        public override void EditaLeitor(Leitor leitor) {  }
        public override void AdicionaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void RemoveExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void EditaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
        public override void ListaExemplarLeitor(Exemplar exemplar, Leitor leitor) { }
    }
}
