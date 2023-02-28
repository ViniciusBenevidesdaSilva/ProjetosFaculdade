using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_1.DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strConexao = @"DATA SOURCE = DESKTOP-34G837R\SQLEXPRESS; DATABASE=AULADB; integrated security=true";
            //string strConexao = "DATA SOURCE = LOCALHOST; DATABASE=AULADB; USER  ID=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strConexao);
            conexao.Open();
            return conexao;
        }
    }
}
