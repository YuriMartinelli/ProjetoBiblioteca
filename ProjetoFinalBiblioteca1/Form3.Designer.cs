namespace ProjetoFinalBiblioteca1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pessoa = new GroupBox();
            comboBoxGenero = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownAnoPub = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            textBoxSubtitulo = new TextBox();
            textBoxEscritor = new TextBox();
            textBoxEditora = new TextBox();
            textBoxTitulo = new TextBox();
            TabControlExemplar = new TabControl();
            Livro = new TabPage();
            numericUpDownTamanhoEbook = new NumericUpDown();
            comboBoxEbook = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            checkBoxEbook = new CheckBox();
            textBoxISBN = new TextBox();
            comboBoxTipoCapa = new ComboBox();
            numericUpDownPaginas = new NumericUpDown();
            Revista = new TabPage();
            label9 = new Label();
            label8 = new Label();
            numericUpDownpagReivsta = new NumericUpDown();
            numericUpDownEdicaoRevista = new NumericUpDown();
            Hq = new TabPage();
            label11 = new Label();
            label10 = new Label();
            textBoxIlustrador = new TextBox();
            numericUpDownEdi = new NumericUpDown();
            tabPageGenerico = new TabPage();
            label12 = new Label();
            listBoxTipoGenerico = new ListBox();
            buttonSalvar = new Button();
            Pessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPub).BeginInit();
            TabControlExemplar.SuspendLayout();
            Livro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanhoEbook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).BeginInit();
            Revista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownpagReivsta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).BeginInit();
            Hq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdi).BeginInit();
            tabPageGenerico.SuspendLayout();
            SuspendLayout();
            // 
            // Pessoa
            // 
            Pessoa.Controls.Add(comboBoxGenero);
            Pessoa.Controls.Add(label7);
            Pessoa.Controls.Add(label6);
            Pessoa.Controls.Add(label5);
            Pessoa.Controls.Add(label4);
            Pessoa.Controls.Add(label3);
            Pessoa.Controls.Add(label2);
            Pessoa.Controls.Add(label1);
            Pessoa.Controls.Add(numericUpDownAnoPub);
            Pessoa.Controls.Add(comboBoxStatus);
            Pessoa.Controls.Add(textBoxSubtitulo);
            Pessoa.Controls.Add(textBoxEscritor);
            Pessoa.Controls.Add(textBoxEditora);
            Pessoa.Controls.Add(textBoxTitulo);
            Pessoa.Location = new Point(24, 12);
            Pessoa.Name = "Pessoa";
            Pessoa.Size = new Size(355, 392);
            Pessoa.TabIndex = 1;
            Pessoa.TabStop = false;
            Pessoa.Text = "Exemplar";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "1 - Romance", "2 - Novela", "3 - Conto", "4 - Crônica", "5 - Poema", "6 - Canção", "7 - Drama histórico", "8 - Teatro de vanguarda" });
            comboBoxGenero.Location = new Point(37, 299);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 325);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 273);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 12;
            label6.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 221);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Ano Publicação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 177);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 10;
            label4.Text = "Editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Escritor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 68);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Subtitulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Titulo";
            // 
            // numericUpDownAnoPub
            // 
            numericUpDownAnoPub.Location = new Point(37, 242);
            numericUpDownAnoPub.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownAnoPub.Minimum = new decimal(new int[] { 1400, 0, 0, 0 });
            numericUpDownAnoPub.Name = "numericUpDownAnoPub";
            numericUpDownAnoPub.Size = new Size(120, 23);
            numericUpDownAnoPub.TabIndex = 6;
            numericUpDownAnoPub.Value = new decimal(new int[] { 1400, 0, 0, 0 });
            numericUpDownAnoPub.ValueChanged += numericUpDownAnoPub_ValueChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "1 - Pendente", "2 - Lido", "3 - Emprestado", "4 - Devolvido", "5 - Perdido" });
            comboBoxStatus.Location = new Point(37, 343);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 3;
            // 
            // textBoxSubtitulo
            // 
            textBoxSubtitulo.Location = new Point(37, 84);
            textBoxSubtitulo.Name = "textBoxSubtitulo";
            textBoxSubtitulo.Size = new Size(100, 23);
            textBoxSubtitulo.TabIndex = 5;
            // 
            // textBoxEscritor
            // 
            textBoxEscritor.Location = new Point(37, 139);
            textBoxEscritor.Name = "textBoxEscritor";
            textBoxEscritor.Size = new Size(100, 23);
            textBoxEscritor.TabIndex = 4;
            // 
            // textBoxEditora
            // 
            textBoxEditora.Location = new Point(37, 195);
            textBoxEditora.Name = "textBoxEditora";
            textBoxEditora.Size = new Size(100, 23);
            textBoxEditora.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(37, 39);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 0;
            textBoxTitulo.TextChanged += textBox1_TextChanged;
            // 
            // TabControlExemplar
            // 
            TabControlExemplar.Controls.Add(Livro);
            TabControlExemplar.Controls.Add(Revista);
            TabControlExemplar.Controls.Add(Hq);
            TabControlExemplar.Controls.Add(tabPageGenerico);
            TabControlExemplar.Location = new Point(407, 27);
            TabControlExemplar.Name = "TabControlExemplar";
            TabControlExemplar.SelectedIndex = 0;
            TabControlExemplar.Size = new Size(372, 377);
            TabControlExemplar.TabIndex = 2;
            // 
            // Livro
            // 
            Livro.Controls.Add(numericUpDownTamanhoEbook);
            Livro.Controls.Add(comboBoxEbook);
            Livro.Controls.Add(label15);
            Livro.Controls.Add(label14);
            Livro.Controls.Add(label13);
            Livro.Controls.Add(checkBoxEbook);
            Livro.Controls.Add(textBoxISBN);
            Livro.Controls.Add(comboBoxTipoCapa);
            Livro.Controls.Add(numericUpDownPaginas);
            Livro.Location = new Point(4, 24);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3);
            Livro.Size = new Size(364, 349);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            Livro.Click += tabPage1_Click;
            // 
            // numericUpDownTamanhoEbook
            // 
            numericUpDownTamanhoEbook.Location = new Point(27, 260);
            numericUpDownTamanhoEbook.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTamanhoEbook.Minimum = new decimal(new int[] { 49, 0, 0, 0 });
            numericUpDownTamanhoEbook.Name = "numericUpDownTamanhoEbook";
            numericUpDownTamanhoEbook.Size = new Size(120, 23);
            numericUpDownTamanhoEbook.TabIndex = 19;
            numericUpDownTamanhoEbook.Value = new decimal(new int[] { 49, 0, 0, 0 });
            // 
            // comboBoxEbook
            // 
            comboBoxEbook.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEbook.FormattingEnabled = true;
            comboBoxEbook.Items.AddRange(new object[] { "1 - Portable Document Format (PDF)" });
            comboBoxEbook.Location = new Point(26, 228);
            comboBoxEbook.Name = "comboBoxEbook";
            comboBoxEbook.Size = new Size(121, 23);
            comboBoxEbook.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 120);
            label15.Name = "label15";
            label15.Size = new Size(32, 15);
            label15.TabIndex = 17;
            label15.Text = "ISBN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 61);
            label14.Name = "label14";
            label14.Size = new Size(74, 15);
            label14.TabIndex = 16;
            label14.Text = "Tipo de capa";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 8);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 14;
            label13.Text = "Paginas";
            // 
            // checkBoxEbook
            // 
            checkBoxEbook.AutoSize = true;
            checkBoxEbook.Location = new Point(26, 203);
            checkBoxEbook.Name = "checkBoxEbook";
            checkBoxEbook.Size = new Size(69, 19);
            checkBoxEbook.TabIndex = 15;
            checkBoxEbook.Text = "E-BOOK";
            checkBoxEbook.UseVisualStyleBackColor = true;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(26, 138);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(100, 23);
            textBoxISBN.TabIndex = 14;
            // 
            // comboBoxTipoCapa
            // 
            comboBoxTipoCapa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoCapa.FormattingEnabled = true;
            comboBoxTipoCapa.Items.AddRange(new object[] { "1 - Capa Dura", "2 - Capa Flexível ou Brochura", "3 - Capa de Papel Cartão", "4 - Capa com Sobrecapa (Jacket)", "5 - Capa com Relevo", "6 - Capa com Verniz UV", "7 - Capa Metalizada", "8 - Capa de Tecido", "9 - Capa com Janela", "10 - Capa Transparente", "11 - Capa Digital" });
            comboBoxTipoCapa.Location = new Point(25, 79);
            comboBoxTipoCapa.Name = "comboBoxTipoCapa";
            comboBoxTipoCapa.Size = new Size(121, 23);
            comboBoxTipoCapa.TabIndex = 14;
            // 
            // numericUpDownPaginas
            // 
            numericUpDownPaginas.Location = new Point(26, 27);
            numericUpDownPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPaginas.Minimum = new decimal(new int[] { 49, 0, 0, 0 });
            numericUpDownPaginas.Name = "numericUpDownPaginas";
            numericUpDownPaginas.Size = new Size(120, 23);
            numericUpDownPaginas.TabIndex = 14;
            numericUpDownPaginas.Value = new decimal(new int[] { 49, 0, 0, 0 });
            // 
            // Revista
            // 
            Revista.Controls.Add(label9);
            Revista.Controls.Add(label8);
            Revista.Controls.Add(numericUpDownpagReivsta);
            Revista.Controls.Add(numericUpDownEdicaoRevista);
            Revista.Location = new Point(4, 24);
            Revista.Name = "Revista";
            Revista.Padding = new Padding(3);
            Revista.Size = new Size(364, 349);
            Revista.TabIndex = 1;
            Revista.Text = "Revista";
            Revista.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(143, 138);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 7;
            label9.Text = "Paginas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(143, 45);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 6;
            label8.Text = "Edição";
            // 
            // numericUpDownpagReivsta
            // 
            numericUpDownpagReivsta.Location = new Point(104, 177);
            numericUpDownpagReivsta.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDownpagReivsta.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownpagReivsta.Name = "numericUpDownpagReivsta";
            numericUpDownpagReivsta.Size = new Size(120, 23);
            numericUpDownpagReivsta.TabIndex = 2;
            numericUpDownpagReivsta.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // numericUpDownEdicaoRevista
            // 
            numericUpDownEdicaoRevista.Location = new Point(104, 63);
            numericUpDownEdicaoRevista.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEdicaoRevista.Name = "numericUpDownEdicaoRevista";
            numericUpDownEdicaoRevista.Size = new Size(120, 23);
            numericUpDownEdicaoRevista.TabIndex = 1;
            numericUpDownEdicaoRevista.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Hq
            // 
            Hq.Controls.Add(label11);
            Hq.Controls.Add(label10);
            Hq.Controls.Add(textBoxIlustrador);
            Hq.Controls.Add(numericUpDownEdi);
            Hq.Location = new Point(4, 24);
            Hq.Name = "Hq";
            Hq.Padding = new Padding(3);
            Hq.Size = new Size(364, 349);
            Hq.TabIndex = 2;
            Hq.Text = "HQ";
            Hq.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(135, 82);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 9;
            label11.Text = "Ilustrador";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(135, 27);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 8;
            label10.Text = "Edição";
            // 
            // textBoxIlustrador
            // 
            textBoxIlustrador.Location = new Point(111, 100);
            textBoxIlustrador.Name = "textBoxIlustrador";
            textBoxIlustrador.Size = new Size(100, 23);
            textBoxIlustrador.TabIndex = 7;
            // 
            // numericUpDownEdi
            // 
            numericUpDownEdi.Location = new Point(100, 45);
            numericUpDownEdi.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownEdi.Name = "numericUpDownEdi";
            numericUpDownEdi.Size = new Size(120, 23);
            numericUpDownEdi.TabIndex = 2;
            // 
            // tabPageGenerico
            // 
            tabPageGenerico.Controls.Add(label12);
            tabPageGenerico.Controls.Add(listBoxTipoGenerico);
            tabPageGenerico.Location = new Point(4, 24);
            tabPageGenerico.Name = "tabPageGenerico";
            tabPageGenerico.Padding = new Padding(3);
            tabPageGenerico.Size = new Size(364, 349);
            tabPageGenerico.TabIndex = 3;
            tabPageGenerico.Text = "Generico";
            tabPageGenerico.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 11);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 6;
            label12.Text = "Tipo";
            // 
            // listBoxTipoGenerico
            // 
            listBoxTipoGenerico.FormattingEnabled = true;
            listBoxTipoGenerico.ItemHeight = 15;
            listBoxTipoGenerico.Items.AddRange(new object[] { "1 - Jornais", "2 - Calendários e Agendas", "3 - Mapas e Atlas", "4 - Postais e Cartões de Saudação", "5 - Papéis de Presente e Material de Embalagem", "6 - DVDs e Blu-rays", "7 - CDs e Vinis", "8 - K7", "9 - Jogos de Tabuleiro e Quebra-Cabeças", "10 - Material de Papelaria e Escritório", "11 - Produtos Relacionados à Cultura Pop", "12 - Audiolivros", "13 - Outros" });
            listBoxTipoGenerico.Location = new Point(20, 29);
            listBoxTipoGenerico.Name = "listBoxTipoGenerico";
            listBoxTipoGenerico.Size = new Size(299, 289);
            listBoxTipoGenerico.TabIndex = 1;
            listBoxTipoGenerico.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(21, 415);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(758, 23);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "SALVAR";
            buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalvar);
            Controls.Add(TabControlExemplar);
            Controls.Add(Pessoa);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            Pessoa.ResumeLayout(false);
            Pessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnoPub).EndInit();
            TabControlExemplar.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamanhoEbook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).EndInit();
            Revista.ResumeLayout(false);
            Revista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownpagReivsta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdicaoRevista).EndInit();
            Hq.ResumeLayout(false);
            Hq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdi).EndInit();
            tabPageGenerico.ResumeLayout(false);
            tabPageGenerico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Pessoa;
        private TextBox textBoxEscritor;
        private TextBox textBoxEditora;
        private TextBox textBoxTitulo;
        private TabControl TabControlExemplar;
        private TabPage Livro;
        private TabPage Revista;
        private NumericUpDown numericUpDownpagReivsta;
        private NumericUpDown numericUpDownEdicaoRevista;
        private TextBox textBoxSubtitulo;
        private Button buttonSalvar;
        private NumericUpDown numericUpDownAnoPub;
        private ComboBox comboBoxStatus;
        private TabPage Hq;
        private TabPage tabPageGenerico;
        private TextBox textBoxIlustrador;
        private NumericUpDown numericUpDownEdi;
        private ListBox listBoxTipoGenerico;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label13;
        private CheckBox checkBoxEbook;
        private TextBox textBoxISBN;
        private ComboBox comboBoxTipoCapa;
        private NumericUpDown numericUpDownPaginas;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEbook;
        private NumericUpDown numericUpDownTamanhoEbook;
    }
}