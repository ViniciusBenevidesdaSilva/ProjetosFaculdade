using ConexaoBD.Models;
using System;
using System.Data.SqlClient;

namespace ConexaoBD.DAO
{
    public class AlunoDAO
    {
        public void Inserir(AlunoViewModel aluno)
        {
            SqlConnection conexao = ConexaoDB.GetConexao();

            // Se entrar no try, a conexão foi aberta, portanto precisa ser concluida
            try
            {
                string mensalidade = aluno.Mensalidade.ToString().Replace(',', '.');

                string sql = String.Format(
                    
                    "set dateformat dmy; " +
                    
                    "insert into alunos(id, nome, mensalidade, cidadeId, dataNascimento)" +
                    "values ( {0}, '{1}', {2}, {3}, '{4}')",

                    aluno.Id, aluno.Nome, mensalidade, aluno.CidadeId, aluno.DataNascimento);

                // Usado para instruções que não retornam nenhum valor
                SqlCommand comando = new SqlCommand(sql, conexao);
                
                // Pode retornar a quantidade de registros alterados
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
