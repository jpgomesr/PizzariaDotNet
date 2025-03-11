using Pizzaria.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.App.Services.Interfaces
{
    public interface IPizzaAppService
    {
        void CadastrarPizza(string nome, decimal preco);
        void AlterarPizza(int id, string nome, decimal preco);
        void ExcluirPizza(int id);
        List<Pizza> GetPizzas();
    }
}
