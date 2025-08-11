using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaspetro.classe
{
    public class conexao
    {
        MySqlConnection conn;
        //criar o metodo para obter as informações do banco
        public DataTable obterDados(string sql)
        {
            //criar a tabela
            DataTable dt = new DataTable();
            //caminho do servidor
            string datasource = "datasource=localhost;username=root;password='';database=projeto";
            conn = new MySqlConnection(datasource);
            MySqlCommand comando = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
