namespace ProjetoFinalBiblioteca1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            // Inicialização dos controles do formulário
            Exemplar = new GroupBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            dateTimePickerNascimento = new DateTimePicker();
            textBoxNome = new TextBox();
            TabControlLeitorFuncionario = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            listBoxTipo = new ListBox();
            tabPage2 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxFuncao = new TextBox();
            numericUpDownCargaH = new NumericUpDown();
            numericUpDownSalario = new NumericUpDown();
            comboBoxCargo = new ComboBox();
            buttonSalvar = new Button();

            // Configuração do GroupBox Exemplar
            Exemplar.SuspendLayout();
            Exemplar.Controls.Add(maskedTextBoxTelefone);
            Exemplar.Controls.Add(maskedTextBoxCpf);
            Exemplar.Controls.Add(label5);
            Exemplar.Controls.Add(label4);
            Exemplar.Controls.Add(label3);
            Exemplar.Controls.Add(label2);
            Exemplar.Controls.Add(label1);
            Exemplar.Controls.Add(textBoxEmail);
            Exemplar.Controls.Add(dateTimePickerNascimento);
            Exemplar.Controls.Add(textBoxNome);
            Exemplar.Location = new Point(23, 27);
            Exemplar.Name = "Exemplar";
            Exemplar.Size = new Size(355, 392);
            Exemplar.TabIndex = 0;
            Exemplar.TabStop = false;
            Exemplar.Text = "Exemplar";

            // Configuração dos campos dentro do GroupBox Exemplar
            maskedTextBoxTelefone.Location = new Point(37, 340);
            maskedTextBoxTelefone.Mask = "(00)0000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 11;

            maskedTextBoxCpf.Location = new Point(41, 210);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(100, 23);
            maskedTextBoxCpf.TabIndex = 10;

            label5.AutoSize = true;
            label5.Location = new Point(41, 309);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefone";

            label4.AutoSize = true;
            label4.Location = new Point(37, 245);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";

            label3.AutoSize = true;
            label3.Location = new Point(37, 179);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 7;
            label3.Text = "Cpf";

            label2.AutoSize = true;
            label2.Location = new Point(37, 119);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Nascimento";

            label1.AutoSize = true;
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";

            textBoxEmail.Location = new Point(37, 263);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 2;

            dateTimePickerNascimento.Location = new Point(37, 137);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(200, 23);
            dateTimePickerNascimento.TabIndex = 1;

            textBoxNome.Location = new Point(37, 49);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 0;

            // Configuração do TabControl
            TabControlLeitorFuncionario.Controls.Add(tabPage1);
            TabControlLeitorFuncionario.Controls.Add(tabPage2);
            TabControlLeitorFuncionario.Location = new Point(416, 42);
            TabControlLeitorFuncionario.Name = "TabControlLeitorFuncionario";
            TabControlLeitorFuncionario.SelectedIndex = 0;
            TabControlLeitorFuncionario.Size = new Size(372, 377);
            TabControlLeitorFuncionario.TabIndex = 1;

            // Configuração da tabPage1 (Leitor)
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(listBoxTipo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(364, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Leitor";
            tabPage1.UseVisualStyleBackColor = true;

            label6.AutoSize = true;
            label6.Location = new Point(19, 13);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10;
            label6.Text = "Tipo";
            label6.Click += label6_Click;

            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 15;
            listBoxTipo.Items.AddRange(new object[]
            {
                "Leitor Casual",
                "Leitor Ávido",
                "Leitor de Ficção",
                "Leitor Crítico",
                "Leitor de Clássicos",
                "Leitor Acadêmico"
            });
            listBoxTipo.Location = new Point(19, 35);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(299, 289);
            listBoxTipo.TabIndex = 0;

            // Configuração da tabPage2 (Funcionario)
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBoxFuncao);
            tabPage2.Controls.Add(numericUpDownCargaH);
            tabPage2.Controls.Add(numericUpDownSalario);
            tabPage2.Controls.Add(comboBoxCargo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(364, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Funcionario";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;

            label10.AutoSize = true;
            label10.Location = new Point(24, 261);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 13;
            label10.Text = "Função";

            label9.AutoSize = true;
            label9.Location = new Point(23, 178);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 12;
            label9.Text = "Carga Horária";

            label8.AutoSize = true;
            label8.Location = new Point(24, 98);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 11;
            label8.Text = "Salário";

            label7.AutoSize = true;
            label7.Location = new Point(23, 22);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 10;
            label7.Text = "Cargo";

            textBoxFuncao.Location = new Point(24, 279);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(100, 23);
            textBoxFuncao.TabIndex = 1;

            numericUpDownCargaH.Location = new Point(24, 196);
            numericUpDownCargaH.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDownCargaH.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownCargaH.Name = "numericUpDownCargaH";
            numericUpDownCargaH.Size = new Size(120, 23);
            numericUpDownCargaH.TabIndex = 2;
            numericUpDownCargaH.Value = new decimal(new int[] { 4, 0, 0, 0 });

            numericUpDownSalario.DecimalPlaces = 2;
            numericUpDownSalario.Location = new Point(24, 120);
            numericUpDownSalario.Maximum = new decimal(new int[] { 350000, 0, 0, 0 });
            numericUpDownSalario.Minimum = new decimal(new int[] { 800, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(120, 23);
            numericUpDownSalario.TabIndex = 1;
            numericUpDownSalario.Value = new decimal(new int[] { 800, 0, 0, 0 });

            comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[]
            {
                "1 - Gerente",
                "2 - Atendente",
                "3 - Caixa",
                "4 - Estagiário"
            });
            comboBoxCargo.Location = new Point(23, 40);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(121, 23);
            comboBoxCargo.TabIndex = 0;
            comboBoxCargo.SelectedIndexChanged += comboBoxCargo_SelectedIndexChanged;

            // Configuração do botão SALVAR
            buttonSalvar.Location = new Point(23, 423);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(758, 23);
            buttonSalvar.TabIndex = 2;
            buttonSalvar.Text = "SALVAR";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;

            // Configuração do formulário
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSalvar);
            Controls.Add(TabControlLeitorFuncionario);
            Controls.Add(Exemplar);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Exemplar.ResumeLayout(false);
            Exemplar.PerformLayout();
            TabControlLeitorFuncionario.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
            ResumeLayout(false);
        }
        #endregion

        // Declaração de variáveis dos controles
        private GroupBox Exemplar;
        private TextBox textBoxNome;
        private TabControl TabControlLeitorFuncionario;
        private TabPage tabPage2;
        private Button buttonSalvar;
        private TabPage tabPage1;
        private ListBox listBoxTipo;
        private NumericUpDown numericUpDownSalario;
        private ComboBox comboBoxCargo;
        private TextBox textBoxEmail;
        private DateTimePicker dateTimePickerNascimento;
        private TextBox textBoxFuncao;
        private NumericUpDown numericUpDownCargaH;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxCpf;
    }
}
