using Ex4_1.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Ex4_1.DAO
{
    public class JogoDAO
    {
        public JogoViewModel Consulta(int Id)
        {
            string sql = $"SELECT * FROM jogos WHERE id = {Id}";

            DataTable tabela = HelperDAO.ExecutaSelect(sql);

            if (tabela.Rows.Count == 0)
                return null;

            return MontaModel(tabela.Rows[0]);
        }

        private JogoViewModel MontaModel(DataRow registro)
        {
            return new JogoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Descricao = registro["descricao"].ToString(),
                ValorLocacao = Convert.ToDouble(registro["valor_locacao"]),
                DataAquisicao = Convert.ToDateTime(registro["data_aquisicao"]),
                CategoriaId = Convert.ToInt32(registro["categoriaId"])
            };
        }

        public void Inserir(JogoViewModel jogo)
        {
            string sql = "INSERT INTO jogos (id, descricao, valor_locacao, data_aquisicao, categoriaId) " +
                "values (@Id, @Descricao, @ValorLocacao, @DataAquisicao, @CategoriaId);";

            HelperDAO.ExecutaSql(sql, RetornaParametros(jogo));
        }

        public void Alterar(JogoViewModel jogo)
        {
            string sql = "UPDATE jogos " +
                "SET descricao = @Descricao, valor_locacao = @ValorLocacao, data_aquisicao = @DataAquisicao, categoriaId = @CategoriaId " +
                "WHERE id = @Id;";

            HelperDAO.ExecutaSql(sql, RetornaParametros(jogo));
        }

        public void Excluir(int Id)
        {
            string sql = $"DELETE FROM jogos WHERE id = {Id};";

            HelperDAO.ExecutaSql(sql);
        }

        private SqlParameter[] RetornaParametros(JogoViewModel jogo)
        {
            return new SqlParameter[]
            {
                new SqlParameter(nameof(jogo.Id), jogo.Id),
                new SqlParameter(nameof(jogo.Descricao), jogo.Descricao),
                new SqlParameter(nameof(jogo.ValorLocacao), jogo.ValorLocacao),
                new SqlParameter(nameof(jogo.DataAquisicao), jogo.DataAquisicao),
                new SqlParameter(nameof(jogo.CategoriaId), jogo.CategoriaId),

            };
        }
    }
}
