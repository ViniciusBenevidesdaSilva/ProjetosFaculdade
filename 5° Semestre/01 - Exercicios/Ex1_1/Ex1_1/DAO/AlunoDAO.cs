using Ex1_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_1.DAO
{
    public class AlunoDAO
    {
        public void Inserir(AlunoViewModel aluno)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string mensalidade = aluno.Mensalidade.ToString().Replace(',', '.');
                string sql = "set dateformat dmy; " +
                    "insert into alunos (id, nome, mensalidade, cidadeId, dataNascimento)" +
                    $"values ({aluno.Id}, '{aluno.Nome}', {mensalidade}, {aluno.CidadeId}, '{aluno.DataNascimento}')";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Alterar(AlunoViewModel aluno)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string mensalidade = aluno.Mensalidade.ToString().Replace(',', '.');
                string sql = "set dateformat dmy; " +
                    $"update alunos set nome = '{aluno.Nome}', mensalidade = {mensalidade}, cidadeId = {aluno.CidadeId}, dataNascimento = '{aluno.DataNascimento}' " +
                    $"where id = {aluno.Id};";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Excluir(int id)
        {
            SqlConnection conexao = ConexaoBD.GetConexao();

            try
            {
                string sql = $"delete from alunos where id = {id};";
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
