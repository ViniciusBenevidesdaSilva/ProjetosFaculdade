using Ex_11_1.Models;
using System.Data.SqlClient;

namespace Ex_11_1.DAO
{
    public class JogoDAO
    {

        private SqlParameter[] CriaParametros(JogoViewModel jogo)
        {
            return new SqlParameter[5]
            {
                new SqlParameter(nameof(jogo.Id), jogo.Id),
                new SqlParameter(nameof(jogo.Descricao), jogo.Descricao),
                new SqlParameter(nameof(jogo.Valor_locacao), jogo.Valor_locacao),
                new SqlParameter(nameof(jogo.Data_aquisicao), jogo.Data_aquisicao),
                new SqlParameter(nameof(jogo.CategoriaId), jogo.CategoriaId)
            };
        }

        public void Inserir(JogoViewModel jogo)
        {
            SqlConnection conexao = ConexaoDB.GetConexao();

            try
            {
                string sql = "INSERT INTO jogos(id, descricao, valor_locacao, data_aquisicao, categoriaId) " +
                    "VALUES (@Id, @Descricao, @Valor_locacao, @Data_aquisicao, @CategoriaId);";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(CriaParametros(jogo));

                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Alterar(JogoViewModel jogo)
        {
            SqlConnection conexao = ConexaoDB.GetConexao();

            try
            {
                string sql = "UPDATE jogos " +
                    "SET Descricao = @Descricao, Valor_locacao = @Valor_locacao, Data_aquisicao = @Data_aquisicao, CategoriaId = @CategoriaId " +
                    "WHERE Id = @Id;";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddRange(CriaParametros(jogo));

                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Excluir(int Id)
        {
            SqlConnection conexao = ConexaoDB.GetConexao();

            try
            {
                string sql = "DELETE FROM jogos " +
                    $"WHERE Id = {Id};";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
