using System.Data.SqlClient;

namespace Ex4_2.DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strConexao = @"Data Source = DESKTOP-34G837R\SQLEXPRESS; DataBase = AULADB; integrated security = true";
            SqlConnection conexao = new SqlConnection(strConexao);
            conexao.Open();

            return conexao;
        }
    }
}
