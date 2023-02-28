using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_1.Models
{
    public class JogoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double ValorLocacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public int CategoriaId { get; set; }
    }
}
