using System;

namespace ConexaoBD.Models
{
    // Classe utilizada para armazenar os dados trazidos do banco
    // Realiza a comunicação entre a View e a Model

    public class AlunoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Mensalidade { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
