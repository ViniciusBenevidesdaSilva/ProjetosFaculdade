﻿using System.Data.SqlClient;

// DAO = Data Access Object

namespace ConexaoBD.DAO
{
    public static class ConexaoDB
    {
        /// <summary>
        /// Método Estático que retorna uma conexão aberta com o BD
        /// </summary>
        /// <returns>Conexão Aberta com o BD</returns>
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Database=AULADB; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
