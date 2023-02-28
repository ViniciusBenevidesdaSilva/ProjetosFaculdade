using Ex4_2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_2.DAO
{
    public class JogoDAO
    {
        private SqlParameter[] GeraParametros(JogoViewModel jogo)
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
            string sql = "INSERT INTO jogos (id, descricao, valor_locacao, data_aquisicao, categoriaId) " +
                "VALUES (@Id, @Descricao, @ValorLocacao, @DataAquisicao, @CategoriaId;";

            HelperDAO.ExecutaSql(sql, GeraParametros(jogo));
        }

        public void Alterar(JogoViewModel jogo)
        {
            string sql = "UPDATE jogos " +
                "SET descricao = @Descricao, valor_locacao =  @ValorLocacao, data_aquisica =  @DataAquisicao, categoriaId =  @CategoriaId " +
                "WHERE id = @Id;";

            HelperDAO.ExecutaSql(sql, GeraParametros(jogo));
        }

        public void Excluir(int Id)
        {
            string sql = $"DELETE FROM jogos WHERE id = {Id};";

            HelperDAO.ExecutaSql(sql);
        }

        public JogoViewModel PequisarJogo(int Id)
        {
            string sql = $"SELECT * FROM jogos WHERE id = {Id}";

            DataTable tabela = HelperDAO.ExecutaSelect(sql);

            if (tabela.Rows.Count == 0)
                return null;

            return MontaModel(tabela.Rows[0]);
        }

        public List<JogoViewModel> Pequisar()
        {
            string sql = $"SELECT * FROM jogos";

            DataTable tabela = HelperDAO.ExecutaSelect(sql);

            if (tabela.Rows.Count == 0)
                return null;
            
            
            List<JogoViewModel> retorno = new List<JogoViewModel>();
            
            foreach(DataRow registro in tabela.Rows)
                retorno.Add(MontaModel(registro));

            return retorno;
        }

        private JogoViewModel MontaModel(DataRow registro)
        {
            return new JogoViewModel()
            {
                Id = Convert.ToInt32(registro["Id"]),
                Descricao = registro["descricao"].ToString(),
                ValorLocacao = Convert.ToDouble(registro["valor_locacao"]),
                DataAquisicao = Convert.ToDateTime(registro["data_aquisicao"]),
                CategoriaId = Convert.ToInt32(registro["categoriaId"])
            };
        }
    }
}
