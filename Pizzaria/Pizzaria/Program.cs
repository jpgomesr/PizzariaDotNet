using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Infra.Database;
using Pizzaria.Infra.Repository.Interfaces;
using Pizzaria.Infra.Repository.Implementations;
using System.Windows.Forms;

namespace Pizzaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options => 
                options.UseSqlite("Data Source=pizzaria.db"));

            services.AddScoped<IPizzaRepository, PizzaRepository>();

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(serviceProvider));
        }
    }
}