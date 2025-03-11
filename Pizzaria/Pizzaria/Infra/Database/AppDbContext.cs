using Pizzaria.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Infra.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pizzaria.db");
            Console.WriteLine($"Banco de dados em: {path}");
            options.UseSqlite($"Data Source={path}");
        }
    }
}