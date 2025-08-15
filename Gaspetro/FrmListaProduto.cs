using Gaspetro.classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaspetro
{
    public partial class FrmListaProduto : Form
    {
        public List<ItemCarrinho> CarrinhoAtual = new List<ItemCarrinho>();
        public FrmListaProduto()
        {
            InitializeComponent();
        }
        public class ItemCarrinho
        {
            public int ProdutoId { get; set; }
            public string Nome { get; set; }
            public Decimal valor { get; set; }
            public int Quantidade { get; set; }
            public decimal Subtotal => valor * Quantidade;
        }

        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conexao conexao = new conexao();
            dt = conexao.obterDados("select * from produto");
            int registro = 0;
            int x = 10, y = 10;
            for (registro = 0; registro < dt.Rows.Count; registro++)
            {
                Panel produtos = new Panel();
                produtos.BorderStyle = BorderStyle.FixedSingle;
                produtos.Location = new Point(x, y);
                produtos.Height = 250;
                produtos.Width = 250;
                Label codigoproduto = new Label();
                codigoproduto.Text = dt.Rows[registro][0].ToString();
                codigoproduto.Location = new Point(20, 52);
                Label nome = new Label();
                nome.Text = dt.Rows[registro][5].ToString();
                nome.Location = new Point(20, 75);
                Label descricao = new Label();
                descricao.Text = dt.Rows[registro][1].ToString();
                descricao.Location = new Point(20, 95);
                PictureBox foto = new PictureBox();
                foto.Name = "foto";
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Image = Image.FromFile(dt.Rows[registro][4].ToString());
                foto.Location = new Point(35, 2);
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registro][2].ToString();
                preco.Location = new Point(20, 100);
                Label quantidade = new Label();
                quantidade.Text = dt.Rows[registro][3].ToString();
                quantidade.Location = new Point(20, 138);
                TextBox qtde = new TextBox();
                qtde.Name = "qtde";
                qtde.Location = new Point(35, 160);
                CheckBox selecionar = new CheckBox();
                selecionar.Text = dt.Rows[registro][0].ToString();
                selecionar.Location = new Point(15, 10);
                selecionar.Click += new EventHandler((sender1, e1) => selecionarClik(sender1, e1, codigoproduto.Text, nome.Text, preco.Text, qtde.Text));

                produtos.Controls.Add(codigoproduto);
                produtos.Controls.Add(foto);
                produtos.Controls.Add(nome);
                produtos.Controls.Add(descricao);
                produtos.Controls.Add(preco);
                produtos.Controls.Add(quantidade);
                produtos.Controls.Add(qtde);
                produtos.Controls.Add(selecionar);

                flowLayoutPanel1.Controls.Add(produtos);
                y += 100;
                x += 0;

            }
        }
        private void selecionarClik(object sender, EventArgs e, string id, string nome, string preco, string quantidade)
        {
            int codigoId = Convert.ToInt32(id);
            decimal valor = Convert.ToDecimal(preco);
            int qtde = Convert.ToInt32(quantidade);
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                ItemCarrinho itemExiste = CarrinhoAtual.FirstOrDefault(item => item.ProdutoId == codigoId);
                if (itemExiste != null)
                {
                    itemExiste.Quantidade++;
                }
                else
                {
                    if (!string.IsNullOrEmpty(quantidade))
                    {
                        CarrinhoAtual.Add(new ItemCarrinho
                        {
                            ProdutoId = codigoId,
                            Nome = nome,
                            valor = valor,
                            Quantidade = qtde,
                        });

                    }
                    else
                    {
                        MessageBox.Show("quantidade precisa definir um valor");
                    }
                }

            }
            else
            {
                ItemCarrinho itemExiste = CarrinhoAtual.FirstOrDefault(item => item.ProdutoId == codigoId);
                if (itemExiste != null)
                {
                    if (itemExiste.Quantidade > 1)
                    {
                        itemExiste.Quantidade--;
                    }
                    else
                    {
                        CarrinhoAtual.Remove(itemExiste);
                    }
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (CarrinhoAtual.Any())
            {
                FrmPedido pedidoatual = new FrmPedido(CarrinhoAtual);
                pedidoatual.Show();
            }
        }
    }
}
