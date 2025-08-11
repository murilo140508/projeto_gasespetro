namespace Gaspetro
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem1 = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, cadastrarToolStripMenuItem, pedidoToolStripMenuItem, relatorioToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, produtoToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(224, 26);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(224, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem1 });
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.Size = new Size(69, 24);
            pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // produtoToolStripMenuItem1
            // 
            produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            produtoToolStripMenuItem1.Size = new Size(145, 26);
            produtoToolStripMenuItem1.Text = "Produto";
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(84, 24);
            relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(62, 24);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(151, 20);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}