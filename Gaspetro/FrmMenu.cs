using Gaspetro.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaspetro
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Sessaousuario.UsuarioLogador;
            toolStripStatusLabel2.Text = Sessaousuario.Cargousuario.ToString();

        }
    }
}
