using System.Collections.Generic;

namespace GerenciadorCartoesCredito.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }
        public string NomeBanco { get; set; } 
        public string NumeroCartao { get; set; }
        public int Limite { get; set; }
        public ICollection<Gasto> Gastos { get; set; }
    }
}
