namespace ProjetoFinalBiblioteca1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastroPessoa = new Button();
            this.buttonCadastroExemplar = new Button();
            this.groupBoxCadastro = new GroupBox();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.labelTitulo = new Label();
            this.textBoxTitulo = new TextBox();
            this.SuspendLayout();

            // 
            // buttonCadastroPessoa
            // 
            this.buttonCadastroPessoa.Dock = DockStyle.Fill;
            this.buttonCadastroPessoa.Location = new Point(3, 3);
            this.buttonCadastroPessoa.Name = "buttonCadastroPessoa";
            this.buttonCadastroPessoa.Size = new Size(192, 23);
            this.buttonCadastroPessoa.TabIndex = 0;
            this.buttonCadastroPessoa.Text = "Cadastro Pessoa";
            this.buttonCadastroPessoa.UseVisualStyleBackColor = true;

            // 
            // buttonCadastroExemplar
            // 
            this.buttonCadastroExemplar.Dock = DockStyle.Fill;
            this.buttonCadastroExemplar.Location = new Point(3, 32);
            this.buttonCadastroExemplar.Name = "buttonCadastroExemplar";
            this.buttonCadastroExemplar.Size = new Size(192, 23);
            this.buttonCadastroExemplar.TabIndex = 1;
            this.buttonCadastroExemplar.Text = "Cadastro Exemplar";
            this.buttonCadastroExemplar.UseVisualStyleBackColor = true;

            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxCadastro.Location = new Point(30, 60);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new Size(210, 100);
            this.groupBoxCadastro.TabIndex = 2;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastro";

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCadastroPessoa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCadastroExemplar, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new Size(198, 58);
            this.tableLayoutPanel1.TabIndex = 0;

            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new Point(30, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new Size(37, 15);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Título";

            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new Point(73, 27);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new Size(167, 23);
            this.textBoxTitulo.TabIndex = 4;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxCadastro);
            this.Name = "Form1";
            this.Text = "Cadastro de Biblioteca";
            this.groupBoxCadastro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button buttonCadastroPessoa;
        private Button buttonCadastroExemplar;
        private GroupBox groupBoxCadastro;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitulo;
        private TextBox textBoxTitulo;
    }
}
