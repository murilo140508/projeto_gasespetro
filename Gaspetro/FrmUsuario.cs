using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
namespace Gaspetro
{
    public partial class FrmUsuario : Form
    {
        MySqlConnection conexao;

        public FrmUsuario()
        {
            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into usuario(nome,email,senha,cargo) values (@nome,@email,@senha,@cargo)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.ToString();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);

                command.Parameters.AddWithValue("nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", CboCargo.Text);
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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CboCargo.Items.Add("Administrador");
            CboCargo.Items.Add("Gerente");
            CboCargo.Items.Add("Vendedor");
            CboCargo.Items.Add("Estoquista");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=projeto";
                conexao = new MySqlConnection(data_source);
                string sql = "Update usuario set nome=@nome,email=@email,senha=@senha,cargo=@cargo where codigo=@id";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.ToString();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);

                command.Parameters.AddWithValue("nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", CboCargo.Text);
                command.Parameters.AddWithValue("@id", Convert.ToInt32(TxtCodigo.Text));
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Editado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Editar");
                }
                conexao.Close();
            }
            catch (Exception ex)

            {
                MessageBox.Show("Erro" + ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCodigo.Text))
                {

                    string data_source = "datasource=localhost;username=root;password='';database=projeto";
                    conexao = new MySqlConnection(data_source);
                    string sql = "Delete from usuario where codigo=@id";
                    MySqlCommand command = new MySqlCommand(sql, conexao);
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(TxtCodigo.Text));
                    conexao.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Excluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Excluir");
                    }
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Campo codigo está vazio");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }
    }
}
