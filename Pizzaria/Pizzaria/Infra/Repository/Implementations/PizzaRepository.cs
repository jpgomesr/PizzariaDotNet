using Pizzaria.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Infra.Database;
using Pizzaria.Infra.Repository.Interfaces;

namespace Pizzaria.Infra.Repository.Implementations
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _context;

        public PizzaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Salvar(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        { 
            Pizza pizza = GetPizzaById(id);
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
        }

        public void Alterar(Pizza pizza)
        {
            _context.Pizzas.Update(pizza);
            _context.SaveChanges();
        }
        public Pizza? GetPizzaById(int id)
        {
            return _context.Pizzas.Find(id);
        }
        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }
    }
}
