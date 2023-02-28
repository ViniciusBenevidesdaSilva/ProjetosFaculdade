using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex3_1.Models;

namespace Ex3_1.DAO
{
    public class JogoDAO
    {
        private SqlParameter[] CriaParametros(JogoViewModel jogo)
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


        public void Inserir(JogoViewModel jogo)
        {
            string sql = "insert into jogos (id, descricao, valor_locacao, data_aquisicao, categoriaId) " +
                $"values (@Id, @Descricao, @ValorLocacao, @DataAquisicao, @CategoriaId);";

            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Alterar(JogoViewModel jogo)
        {
            string sql = "update jogos set descricao = @Descricao, valor_locacao = @ValorLocacao, data_aquisicao = @DataAquisicao, categoriaId = @CategoriaId " +
                "where id = @Id;";

            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Excluir(int id)
        {
            string sql = $"delete from jogos where Id = {id};";
            HelperDAO.ExecutaSQL(sql);
        }
    }
}
