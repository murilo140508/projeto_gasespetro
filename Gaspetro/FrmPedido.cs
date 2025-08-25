using MySql.Data.MySqlClient;
using Gaspetro.classe;
using Org.BouncyCastle.Asn1.Cmp;
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
using System.Reflection.Metadata.Ecma335;
using Google.Protobuf.WellKnownTypes;

namespace Gaspetro
{
    public partial class FrmPedido : Form
    {
        MySqlConnection con;
        int idUsuario;
        decimal totalpedido;
        private List<ItemCarrinho> _itemCarrinho;
        public FrmPedido(List<ItemCarrinho> CarrinhoRecibido)
        {
            _itemCarrinho = CarrinhoRecibido;
            InitializeComponent();
        }
        private void AtualizarCarrinho()
        {
            dgvPedido.DataSource = _itemCarrinho;
            dgvPedido.Refresh();
            Valor.Text = _itemCarrinho.Sum(item => item.Subtotal).ToString();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            AtualizarCarrinho();
            conexao con = new conexao();

            cboCliente.DataSource = con.obterDados("select codigoCliente, nome from cliente");
            cboCliente.ValueMember = "codigocliente";
            cboCliente.DisplayMember = "nome";

            cboPagamento.Items.Add("cartão debito");
            cboPagamento.Items.Add("cartão credito");
            cboPagamento.Items.Add("cartão Pix");

            cboStatus.Items.Add("pedido recebido");
            cboStatus.Items.Add("em produção");
            cboStatus.Items.Add("a caminho");
            cboStatus.Items.Add("entregue");


        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsuario = Convert.ToInt32(((DataRowView)cboCliente.SelectedItem)["codigoCliente"]);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root,password='';database=projeto";

            con = new MySqlConnection(data_source);
            try
            {
                if (cboCliente.Text == "")
                {
                    MessageBox.Show("Cliente está vazio");
                    return;
                }
                if (cboPagamento.Text == "")
                {
                    MessageBox.Show("Forma de pagamento esta vazio"); return;
                }
                if (cboStatus.Text == "")
                {
                    MessageBox.Show("Status está vazio"); return;
                }
                string sqlpedido = "Insert into pedido(data_pedido, data_entrega,codigoUsuario, codigoCliente, formapagamento, status)" +
                    "values(@datapedido, @dataentrega, @Usuario, @Cliente, @formapagamento, @status)";
                MySqlCommand comandopedido = new MySqlCommand(sqlpedido, con);
                comandopedido.Parameters.AddWithValue("@ususario", Sessaousuario.Codigo);
                comandopedido.Parameters.AddWithValue("datapedido", data_pedido.Value);
                comandopedido.Parameters.AddWithValue("dataentrega", data_entrega.Value);
                comandopedido.Parameters.AddWithValue("@cliente", idUsuario);
                comandopedido.Parameters.AddWithValue("@forma", cboPagamento.Text);
                comandopedido.Parameters.AddWithValue("@status", cboStatus.Text);
                con.Open();
                comandopedido.ExecuteNonQuery();
                int idpedido = Convert.ToInt32(comandopedido.LastInsertedId);
                string sqlitens = "insert into pedido_itens(codigopediddo, codigoproduto, quantidade,valor,total)"+
                    "values(@pediddo, @produto, @quantidade, @valor, @total)";

                foreach (var item in _itemCarrinho)
                {
                    MySqlCommand cmd = new MySqlCommand(sqlitens, con);
                    cmd.Parameters.AddWithValue("@pedido", idpedido);
                    cmd.Parameters.AddWithValue("@produto", item.ProdutoId);
                    cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                    cmd.Parameters.AddWithValue("@valor", item.valor);
                    cmd.Parameters.AddWithValue("@total", item.Subtotal);
                    cmd.ExecuteNonQuery();
                    totalpedido += item.Subtotal;
                }
                total.Text=totalpedido.ToString();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }
    }     
}
