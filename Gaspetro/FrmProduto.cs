using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Gaspetro.classe;
using MySql.Data.MySqlClient;
using Gaspetro.classe;

namespace Gaspetro
{
    public partial class FrmProduto : Form
    {
        MySqlConnection conn;
        int codigoTipo = 0;
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //chama a caixa de dialogo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem| *.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Selecione a Imagem do Produto";
            // verifica se pressionou o ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //pega o caminho da foto
                string caminhocompletofotooriginal = openFileDialog.FileName;
                //pega o nome do arquivo
                string nomeArquivo = Path.GetFileName(caminhocompletofotooriginal);
                //criando o caminho da pasta de imagem no sistema
                string pastaDestino = Path.Combine(Application.StartupPath, "Produto");
                //verifica se existe o diretorio
                if (!Directory.Exists(pastaDestino))
                {
                    //cria o diretorio
                    Directory.CreateDirectory(pastaDestino);

                }
                string caminhodestino = Path.Combine(pastaDestino, nomeArquivo);
                try
                {
                    //copiando o arquivo para o destino
                    File.Copy(caminhocompletofotooriginal, caminhodestino, true);
                    //mostrando o texto com o nome da foto
                    lblFoto.Text = Path.Combine(pastaDestino, nomeArquivo);
                    //carregando a foto na picture
                    Foto.Image = Image.FromFile(lblFoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao copiar a imagem:{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFoto.Text = "";
                }

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string datasource = "datasource=localhost;username=root;password='';database=projeto";
                conn = new MySqlConnection(datasource);
                string sql = "Insert into produto(nome,descricao,tipo,valor,quantidade,foto) values(@nome,@descricao,@tipo,@valor,@quantidade,@foto)";
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                comando.Parameters.AddWithValue("@tipo", codigoTipo);
                comando.Parameters.AddWithValue("@quantidade", Convert.ToInt32(txtQuantidade.Text));
                comando.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
                comando.Parameters.AddWithValue("@foto", lblFoto.Text);
                conn.Open();
                //testar se gravou no banco de dados
                if (Convert.ToInt32(comando.ExecuteNonQuery()) == 1)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            cboTipo.DataSource = conexao.obterDados("select codigotipo,descricao from tipo");
            cboTipo.ValueMember = "codigotipo";
            cboTipo.DisplayMember = "descricao";
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoTipo = Convert.ToInt32(((DataRowView)cboTipo.SelectedItem)["codigotipo"]);
        }
    }

}

