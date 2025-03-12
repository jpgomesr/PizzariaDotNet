using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Service.Interfaces;
using Pizzaria.Domain.Entity;

namespace Pizzaria.Domain.Service
{
    public class PizzaDomainService : IPizzaDomainService
    {
        public void Validar(Pizza pizza)
        {
            if (string.IsNullOrEmpty(pizza.Nome))
            {
                throw new Exception("Nome é obrigatório");
            }
            if (pizza.Preco < 0)
            {
                throw new Exception("Preço precisa ser positivo");
            }
            if (pizza == null)
            {
                throw new Exception("Pizza não pode ser nula"); 
            }
        }
    }
}
