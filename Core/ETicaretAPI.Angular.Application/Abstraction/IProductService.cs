using ETicaretAPI.Angular.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Angular.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
