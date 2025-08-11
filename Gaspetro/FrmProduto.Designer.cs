namespace Gaspetro
{
    partial class FrmProduto
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
            statusStrip1 = new StatusStrip();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtQuantidade = new TextBox();
            txtCodigo = new TextBox();
            txtValor = new TextBox();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            cboTipo = new ComboBox();
            label7 = new Label();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnFoto = new Button();
            dgvProduto = new DataGridView();
            Foto = new PictureBox();
            lblFoto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Foto).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 475);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 111);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 3;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 144);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 4;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 215);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 5;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 177);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 6;
            label6.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(167, 174);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 7;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(167, 42);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 8;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(167, 141);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 9;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(167, 108);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(167, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 11;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(167, 207);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 12;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(541, 42);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 13;
            label7.Text = "Foto";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(76, 259);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(176, 259);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(276, 259);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(376, 259);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(620, 40);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(123, 29);
            btnFoto.TabIndex = 18;
            btnFoto.Text = "Adicionar Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // dgvProduto
            // 
            dgvProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduto.Location = new Point(114, 309);
            dgvProduto.Name = "dgvProduto";
            dgvProduto.RowHeadersWidth = 51;
            dgvProduto.Size = new Size(582, 123);
            dgvProduto.TabIndex = 19;
            // 
            // Foto
            // 
            Foto.Location = new Point(528, 80);
            Foto.Name = "Foto";
            Foto.Size = new Size(215, 155);
            Foto.TabIndex = 20;
            Foto.TabStop = false;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(575, 263);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(121, 20);
            lblFoto.TabIndex = 21;
            lblFoto.Text = "Caminho da foto";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 497);
            Controls.Add(lblFoto);
            Controls.Add(Foto);
            Controls.Add(dgvProduto);
            Controls.Add(btnFoto);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(label7);
            Controls.Add(cboTipo);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(txtValor);
            Controls.Add(txtCodigo);
            Controls.Add(txtQuantidade);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtQuantidade;
        private TextBox txtCodigo;
        private TextBox txtValor;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private ComboBox cboTipo;
        private Label label7;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnFoto;
        private DataGridView dgvProduto;
        private PictureBox Foto;
        private Label lblFoto;
    }
}