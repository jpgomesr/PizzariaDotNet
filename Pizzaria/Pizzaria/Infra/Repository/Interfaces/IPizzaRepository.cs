using Pizzaria.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.Repository.Interfaces
{
    public interface IPizzaRepository
    {
        public void Salvar(Pizza pizza);
        public void Deletar(int id);
        public void Alterar(Pizza pizza);
        public Pizza? GetPizzaById(int id);
        public List<Pizza> GetAll();
    }
}
