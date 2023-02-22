using System.Data.SqlClient;

namespace Ex_11_1.DAO
{
    public static class ConexaoDB
    {

        public static SqlConnection GetConexao()
        {
            string strCon = @"Data Source=DESKTOP-34G837R\SQLEXPRESS; Database=AULADB; Integrated Security=True;";
            //string strCon = "Data Source=LOCALHOST; Database=AULADB; user id=sa; password=123456"

            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();

            return conexao;
        }


    }
}
