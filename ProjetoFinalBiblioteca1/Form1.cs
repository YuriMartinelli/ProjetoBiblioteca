namespace ProjetoFinalBiblioteca1
{
    public partial class Form1 : Form
    {
        private Form2 formPessoa;
        private Form3 formExemplar;
        public Form1()
        {
            InitializeComponent();
            formPessoa = new Form2();
            formExemplar = new Form3();
        }

        private void buttonCadastroPessoa_Click(object sender, EventArgs e)
        {
            // Aqui você determina formulário de cadastro Pessoa
            formPessoa.StartPosition = FormStartPosition.CenterParent;
            formPessoa.Show();
            this.Hide();
        }

        private void buttonCadastroExemplar_Click(object sender, EventArgs e)
        {
            // Aqui você determina formulário de cadastro Exemplar
            formExemplar.StartPosition = FormStartPosition.CenterScreen;
            formExemplar.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
