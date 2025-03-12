using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.Domain.Entity;

namespace Pizzaria.Domain.Service.Interfaces
{
    public interface IPizzaDomainService
    {
        void Validar(Pizza pizza);
    }
}
