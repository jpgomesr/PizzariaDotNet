using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Entity
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        public enum Role
        {
            Usuario,
            Admin
        }
    }
}
