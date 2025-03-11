using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Entity
{
    public class Pizza
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }

        public Pizza(string Nome, decimal Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
        public Pizza(int Id, string Nome, decimal Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}
