using System.Data.SqlClient;

namespace Ex4_1.DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strConexao = @"Data Source = DESKTOP-34G837R\SQLEXPRESS; Database = AULADB; integrated security = true";
            SqlConnection conexao = new SqlConnection(strConexao);
            conexao.Open();

            return conexao;
        }
    }
}
