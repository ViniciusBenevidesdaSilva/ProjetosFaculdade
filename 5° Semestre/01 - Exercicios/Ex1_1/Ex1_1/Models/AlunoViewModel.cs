using System;

namespace Ex1_1.Models
{
    public class AlunoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Mensalidade { get; set; }
        public int CidadeId { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
