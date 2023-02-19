using ConexaoBD.DAO;
using ConexaoBD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoBD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {


            AlunoViewModel aluno = new AlunoViewModel();
            try
            {
                aluno.Id = (int)txtId.Value;
                aluno.Nome = txtNome.Text;
                aluno.Mensalidade = (float)txtMensalidade.Value;
                aluno.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                aluno.CidadeId = (int)txtCidade.Value;
            }
            catch
            {
                MessageBox.Show("Preencha os dados corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            AlunoDAO alunoDAO = new AlunoDAO();

            try
            {
                alunoDAO.Inserir(aluno);
                MessageBox.Show("Sucesso na inserção dos dados", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Erro na conexão de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
