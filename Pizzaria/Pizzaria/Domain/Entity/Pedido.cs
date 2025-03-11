using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Entity
{
    public class Pedido
    {
        [Required]
        public string NomeCliente { get; set; }
        [Required]
        public List<Pedido> Pedidos { get; set; }
        [Required]
        public decimal? ValorTotal { get; set; }
        [Required]
        public DateTime? HorarioPedido { get; set; }
    }
}
