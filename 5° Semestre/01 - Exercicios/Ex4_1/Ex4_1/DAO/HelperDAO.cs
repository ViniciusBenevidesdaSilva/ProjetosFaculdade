using System.Data;
using System.Data.SqlClient;

namespace Ex4_1.DAO
{
    public static class HelperDAO
    {
        public static void ExecutaSql(string sql, SqlParameter[] parametros = null)
        {
            using(SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    if (parametros != null)
                        comando.Parameters.AddRange(parametros);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ExecutaSelect(string sql, SqlParameter[] parametros = null)
        {
            using(SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(sql, conexao))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);

                    DataTable retorno = new DataTable();
                    adapter.Fill(retorno);

                    return retorno;
                }
            }
        }
    }
}
