using System;

namespace Ex_11_1.Models
{
    public class JogoViewModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public double Valor_locacao { get; set; }

        public DateTime Data_aquisicao { get; set; }

        public int CategoriaId { get; set; }

    }
}
