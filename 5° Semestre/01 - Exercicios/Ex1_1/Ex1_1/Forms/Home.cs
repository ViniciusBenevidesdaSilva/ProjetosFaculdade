using Ex1_1.DAO;
using Ex1_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_1
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
                AlunoViewModel aluno = PreencheDadosVO();
                if (!ValidaAluno(aluno))
                    return;

                AlunoDAO dao = new AlunoDAO();
                dao.Inserir(aluno);

                MessageBox.Show("Aluno inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoViewModel aluno = PreencheDadosVO();
                if (!ValidaAluno(aluno))
                    return;

                AlunoDAO dao = new AlunoDAO();
                dao.Alterar(aluno);

                MessageBox.Show("Aluno alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo excluir esse aluno?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.No)
                return;

            try
            {
                int id = Convert.ToInt32(txtId.Value);

                AlunoDAO dao = new AlunoDAO();
                dao.Excluir(id);

                MessageBox.Show("Aluno Excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private AlunoViewModel PreencheDadosVO()
        {
            return new AlunoViewModel()
            {
                Id = Convert.ToInt32(txtId.Value),
                Nome = txtNome.Text,
                Mensalidade = Convert.ToDouble(txtMensalidade.Value),
                DataNascimento = Convert.ToDateTime(txtDataNascimento.Text),
                CidadeId = Convert.ToInt32(txtCidadeId.Value)
            };
        }

        private bool ValidaAluno(AlunoViewModel aluno)
        {
            bool retorno = true;

            errorProvider.Clear();

            if (aluno.Id < 0)
            {
                errorProvider.SetError(txtId, "O Id não pode ser negativo");
                retorno = false;
            }

            if (string.IsNullOrEmpty(aluno.Nome))
            {
                errorProvider.SetError(txtNome, "Informe um nome válido");
                retorno = false;
            }

            if (aluno.Mensalidade < 0)
            {
                errorProvider.SetError(txtMensalidade, "A Mensalidade não pode ser negativa");
                retorno = false;
            }

            if (aluno.DataNascimento > DateTime.Now)
            {
                errorProvider.SetError(txtDataNascimento, "A Data de nascimento deve ser anterior a data atual");
                retorno = false;
            }

            if (aluno.CidadeId < 0)
            {
                errorProvider.SetError(txtCidadeId, "O Código da cidade não pode ser negativo");
                retorno = false;
            }

            return retorno;
        }
    }
}
