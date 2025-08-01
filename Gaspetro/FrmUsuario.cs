using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Data;
namespace Gaspetro
{
    public partial class FrmUsuario : Form
    {
        MySqlConnection conexao;
        int idcargo;

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
                string sql = "insert into usuario(nome,email,senha,cargo,ativo) values (@nome,@email,@senha,@cargo,1)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = TxtSenha.Text.ToString();
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);

                command.Parameters.AddWithValue("nome", TxtNome.Text);
                command.Parameters.AddWithValue("@email", TxtEmail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", idcargo);
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
            /*
            CboCargo.Items.Add("Administrador");
            CboCargo.Items.Add("Gerente");
            CboCargo.Items.Add("Vendedor");
            CboCargo.Items.Add("Estoquista");
            */
            CboCargo.DataSource = obterDados("Select * from cargo");
            CboCargo.ValueMember = "codigocargo";
            CboCargo.DisplayMember = "cargo";
            dataGridView1.DataSource = obterDados("select * from usuario");
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
                command.Parameters.AddWithValue("@cargo", idcargo);
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

                    string datasource = "datasource=localhost;username=root;password='';database=projeto";
                    conexao = new MySqlConnection(datasource);
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

        private void CboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            idcargo = Convert.ToInt32(((DataRowView)CboCargo.SelectedItem)["codigocargo"]);
        }
        public DataTable obterDados(string sql)
        {
            DataTable dt = new DataTable();
            string datasource = "datasource=localhost;username=root;password='';database=projeto";
            conexao = new MySqlConnection(datasource);
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            conexao.Close();
            return dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            TxtCodigo.Text=codigo.ToString();
            TxtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            TxtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            TxtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            CboCargo.Text = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            bool ativo = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["ativo"].Value);
            chkAtivo.Visible = true;
            if (ativo == true)
            {
                chkAtivo.Checked = true;   
            }
            else 
            {
               chkAtivo.Checked = false;
            }

        }
    }

}
