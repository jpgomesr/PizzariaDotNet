using Microsoft.Extensions.DependencyInjection;
using Pizzaria.App.Services.Interfaces;

namespace Pizzaria
{
    public partial class FrmLogin : Form
    {
        private readonly IPizzaAppService _servico;
        public FrmLogin(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _servico = serviceProvider.GetRequiredService<IPizzaAppService>();
        }
        
    }
}
