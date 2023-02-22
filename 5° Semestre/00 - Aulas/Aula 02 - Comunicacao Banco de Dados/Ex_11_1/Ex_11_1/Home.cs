using Ex_11_1.Models;
using Ex_11_1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_11_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private JogoViewModel PreencheDadosJogo()
        {
            return new JogoViewModel()
            {
                Id = (int)txtId.Value,
                Descricao = txtDescricao.Text,
                Valor_locacao = (double)txtValorLocacao.Value,
                Data_aquisicao = Convert.ToDateTime(txtDataAquisicao.Text),
                CategoriaId = (int)txtIdCategoria.Value
            };
        }

        private void ValidaJogo(JogoViewModel jogo)
        {
            if (jogo.Id < 0)
                throw new Exception("Id não pode ser negativo!");

            if (string.IsNullOrEmpty(jogo.Descricao))
                throw new Exception("Informe a descrição do Jogo!");

            if (jogo.Valor_locacao < 0)
                throw new Exception("Valor da locação não pode ser negativa!");

            if (jogo.Data_aquisicao > DateTime.Now)
                throw new Exception("Data de aquisição inválida!"); 
            
            if (jogo.CategoriaId < 0)
                throw new Exception("Código da categoria não ser negativo!");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoViewModel jogo = PreencheDadosJogo();
                ValidaJogo(jogo);

                JogoDAO dao = new JogoDAO();
                dao.Inserir(jogo);

                MessageBox.Show("Jogo Salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                JogoViewModel jogo = PreencheDadosJogo();

                JogoDAO dao = new JogoDAO();
                dao.Excluir(jogo.Id);

                MessageBox.Show("Jogo Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int id = (int)txtId.Value;

                if (DialogResult.No == MessageBox.Show($"Deseja mesmo excluir o jogo de Id {id}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;

                JogoDAO dao = new JogoDAO();
                dao.Excluir(id);

                MessageBox.Show("Jogo Excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
