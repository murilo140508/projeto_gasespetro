using MySql.Data.MySqlClient;
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
    public partial class FrmCliente : Form
    {
        MySqlConnection conexao;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into cliente (nome,telefone, email, cpf_cnpj, cep, num_casa, complemento) " +
                    "values (@nome,@Telefone, @email, @cnpj, @cep, @num_casa, @complemento)";
                MySqlCommand command = new MySqlCommand(sql, conexao);

                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                command.Parameters.AddWithValue("@cep",txtCep.Text);
                command.Parameters.AddWithValue("@num_casa", txtNumero.Text);
                command.Parameters.AddWithValue("@complemento", txtcomplemento.Text);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadasro com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                conexao.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }
    }
    
}
