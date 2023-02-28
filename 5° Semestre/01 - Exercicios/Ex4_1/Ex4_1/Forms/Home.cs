using Ex4_1.DAO;
using Ex4_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private JogoViewModel LeJogo()
        {
            return new JogoViewModel()
            {
                Id = Convert.ToInt32(txtId.Value),
                Descricao = txtDescricao.Text.Trim(),
                ValorLocacao = Convert.ToDouble(txtValorLocacao.Value),
                DataAquisicao = Convert.ToDateTime(txtDataAquisicao.Text),
                CategoriaId = Convert.ToInt32(txtCategoriaId.Value)
            };
        }


        private bool ValidaJogo(JogoViewModel jogo)
        {
            bool retorno = true;
            errorProvider.Clear();

            if(jogo.Id < 0)
            {
                retorno = false;
                errorProvider.SetError(txtId, "O Id do Jogo não pode ser negativo");
            }

            if (string.IsNullOrEmpty(jogo.Descricao))
            {
                retorno = false;
                errorProvider.SetError(txtDescricao, "A descrição do Jogo não pode estar vazia");
            }

            if (jogo.ValorLocacao <= 0)
            {
                retorno = false;
                errorProvider.SetError(txtValorLocacao, "O valor de locação do Jogo deve ser maior que zero");
            }

            if (jogo.DataAquisicao > DateTime.Today)
            {
                retorno = false;
                errorProvider.SetError(txtDataAquisicao, "A data de aquisição do Jogo deve ser anterior ao dia de hoje");
            }

            if (jogo.CategoriaId < 0)
            {
                retorno = false;
                errorProvider.SetError(txtId, "O Id da Categoria do Jogo não pode ser negativo");
            }
            
            return retorno;
        }

        private void PreencheTela(JogoViewModel jogo)
        {
            if (jogo == null)
                return;

            txtId.Value = jogo.Id;
            txtDescricao.Text = jogo.Descricao;
            txtValorLocacao.Value = (decimal)jogo.ValorLocacao;
            txtDataAquisicao.Text = jogo.DataAquisicao.ToShortDateString();
            txtCategoriaId.Value = jogo.CategoriaId;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                int Id = Convert.ToInt32(txtId.Value); 
                
                JogoDAO dao = new JogoDAO();

                JogoViewModel jogo = dao.Consulta(Id);

                if(jogo != null)
                {
                    PreencheTela(jogo);
                    SystemSounds.Beep.Play();
                }
                else
                    MessageBox.Show("Registro não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = LeJogo();

                if (!ValidaJogo(jogo))
                {
                    SystemSounds.Hand.Play();
                    return;
                }

                JogoDAO dao = new JogoDAO();

                dao.Inserir(jogo);

                MessageBox.Show("Jogo Inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = LeJogo();

                if (!ValidaJogo(jogo))
                {
                    SystemSounds.Hand.Play();
                    return;
                }

                JogoDAO dao = new JogoDAO();

                dao.Alterar(jogo);

                MessageBox.Show("Jogo Alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();

                int Id = Convert.ToInt32(txtId.Value);

                JogoDAO dao = new JogoDAO();
                dao.Excluir(Id);

                MessageBox.Show("Jogo Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
