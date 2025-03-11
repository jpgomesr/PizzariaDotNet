using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Entity
{
    public class ItemPedido
    {
        [Required]
        public Pizza Pizza { get; set; }
        [Required]
        public int Quantidade { get; set; }
    }
}
