using ProjetoFinalBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalBiblioteca1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownAnoPub_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // carrega os valores do Enum para o combobox/Listbox
            listBoxTipoGenerico.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipoGenerico.SelectedIndex = 0;
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxTipoCapa.DataSource = Enum.GetValues(typeof(EnumExemplarTipoCapa));
            comboBoxTipoCapa.SelectedIndex = 0;
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxGenero.DataSource = Enum.GetValues(typeof(EnumExemplarGeneroTipo));
            comboBoxGenero.SelectedIndex = 0;
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
            // carrega os valores do Enum para o combobox/Listbox
            comboBoxEbook.DataSource = Enum.GetValues(typeof(EnumEbookFormato));
            comboBoxEbook.SelectedIndex = 0;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Aqui você determina formulário de cadastro 
            Form1 formCadastroExemplar = new Form1();
            formCadastroExemplar.StartPosition = FormStartPosition.CenterScreen;
            formCadastroExemplar.TopMost = true;
            formCadastroExemplar.ShowDialog();
            this.Hide();
        }
    }
}
