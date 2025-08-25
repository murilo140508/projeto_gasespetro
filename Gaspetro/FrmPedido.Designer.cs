namespace Gaspetro
{
    partial class FrmPedido
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
            dgvPedido = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            data_pedido = new DateTimePicker();
            data_entrega = new DateTimePicker();
            cboCliente = new ComboBox();
            total = new Label();
            label5 = new Label();
            cboPagamento = new ComboBox();
            Valor = new Label();
            label7 = new Label();
            cboStatus = new ComboBox();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(51, 254);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.RowHeadersWidth = 51;
            dgvPedido.Size = new Size(664, 148);
            dgvPedido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 34);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 70);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Data do pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 105);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 3;
            label3.Text = "Data de entrega";
            // 
            // data_pedido
            // 
            data_pedido.Location = new Point(172, 67);
            data_pedido.Name = "data_pedido";
            data_pedido.Size = new Size(250, 27);
            data_pedido.TabIndex = 4;
            // 
            // data_entrega
            // 
            data_entrega.Location = new Point(174, 100);
            data_entrega.Name = "data_entrega";
            data_entrega.Size = new Size(250, 27);
            data_entrega.TabIndex = 5;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(172, 33);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 28);
            cboCliente.TabIndex = 6;
            cboCliente.SelectedIndexChanged += cboCliente_SelectedIndexChanged;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(65, 154);
            total.Name = "total";
            total.Size = new Size(78, 20);
            total.TabIndex = 7;
            total.Text = "Valor total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 196);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 8;
            label5.Text = "Forma de pagamneto";
            // 
            // cboPagamento
            // 
            cboPagamento.FormattingEnabled = true;
            cboPagamento.Location = new Point(260, 196);
            cboPagamento.Name = "cboPagamento";
            cboPagamento.Size = new Size(151, 28);
            cboPagamento.TabIndex = 9;
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(163, 154);
            Valor.Name = "Valor";
            Valor.Size = new Size(50, 20);
            Valor.TabIndex = 10;
            Valor.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(494, 34);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 11;
            label7.Text = "Status do pedido";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(623, 31);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 12;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(646, 196);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(cboStatus);
            Controls.Add(label7);
            Controls.Add(Valor);
            Controls.Add(cboPagamento);
            Controls.Add(label5);
            Controls.Add(total);
            Controls.Add(cboCliente);
            Controls.Add(data_entrega);
            Controls.Add(data_pedido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPedido);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedido;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker data_pedido;
        private DateTimePicker data_entrega;
        private ComboBox cboCliente;
        private Label total;
        private Label label5;
        private ComboBox cboPagamento;
        private Label Valor;
        private Label label7;
        private ComboBox cboStatus;
        private Button btnFinalizar;
    }
}