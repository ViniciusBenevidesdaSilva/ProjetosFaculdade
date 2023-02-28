using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex3_1.DAO;
using Ex3_1.Models;

namespace Ex3_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencheCampos();

                if (!ValidaCampos(jogo))
                    return;

                JogoDAO dao = new JogoDAO();

                dao.Inserir(jogo);
                MessageBox.Show("Jogo inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                JogoViewModel jogo = PreencheCampos();

                if (!ValidaCampos(jogo))
                    return; 
                
                JogoDAO dao = new JogoDAO();

                dao.Alterar(jogo);
                MessageBox.Show("Jogo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo excluir esse jogo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (resposta == DialogResult.No)
                return;

            try
            {
                int id = Convert.ToInt32(txtId.Value);

                JogoDAO dao = new JogoDAO();
                dao.Excluir(id);
                MessageBox.Show("Jogo excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public JogoViewModel PreencheCampos()
        {
            return new JogoViewModel()
            {
                Id = Convert.ToInt32(txtId.Value),
                Descricao = txtDescricao.Text,
                ValorLocacao = Convert.ToDouble(txtValorLocacao.Value),
                DataAquisicao = Convert.ToDateTime(txtDataAquisicao.Text),
                CategoriaId = Convert.ToInt32(txtCategoriaId.Value)
            };
        }

        public bool ValidaCampos(JogoViewModel jogo)
        {
            bool retorno = true;
            errorProvider.Clear();

            if (jogo.Id < 0)
            {
                errorProvider.SetError(txtId, "O Id não pode ser negativo");
                retorno = false;
            }

            if (string.IsNullOrEmpty(jogo.Descricao))
            {
                errorProvider.SetError(txtDescricao, "Informe uma descrição válida");
                retorno = false;
            }

            if (jogo.ValorLocacao < 0)
            {
                errorProvider.SetError(txtValorLocacao, "O Valor de Locação não pode ser negativo");
                retorno = false;
            }

            if (jogo.DataAquisicao > DateTime.Now)
            {
                errorProvider.SetError(txtDataAquisicao, "A Data de aquisição deve ser anterior a data atual");
                retorno = false;
            }

            if (jogo.CategoriaId < 0)
            {
                errorProvider.SetError(txtCategoriaId, "O Código da categoria não pode ser negativo");
                retorno = false;
            }


            return retorno;
        }
    }
}
