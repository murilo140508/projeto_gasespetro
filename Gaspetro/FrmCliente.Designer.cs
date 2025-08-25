namespace Gaspetro
{
    partial class FrmCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtCNPJ = new TextBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtcomplemento = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            dgvCliente = new DataGridView();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 54);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 138);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 179);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 4;
            label5.Text = "CNPJ/CPF";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 222);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 5;
            label6.Text = "Cep:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 269);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 312);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 7;
            label8.Text = "complemento";
            label8.Click += label8_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(116, 6);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(116, 54);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(116, 93);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(116, 176);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(125, 27);
            txtCNPJ.TabIndex = 12;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(116, 219);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(125, 27);
            txtCep.TabIndex = 13;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(116, 266);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 14;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(116, 309);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(125, 27);
            txtcomplemento.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 357);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(116, 357);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 17;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(216, 357);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(316, 357);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(310, 43);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.Size = new Size(455, 261);
            dgvCliente.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 269);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 21;
            label9.Text = "n casa:";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(dgvCliente);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtcomplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtCep);
            Controls.Add(txtCNPJ);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtCNPJ;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtcomplemento;
        private Button btnCadastrar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnPesquisar;
        private DataGridView dgvCliente;
        private Label label9;
    }
}