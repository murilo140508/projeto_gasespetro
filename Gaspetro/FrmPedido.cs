using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gaspetro.FrmListaProduto;

namespace Gaspetro
{
    public partial class FrmPedido : Form
    {
        private List<ItemCarrinho> _itemCarrinho;
        public FrmPedido(List<ItemCarrinho>CarrinhoRecibido)
        {
            _itemCarrinho = CarrinhoRecibido;
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            dgvPedido.DataSource = _itemCarrinho;
        }
    }
}
