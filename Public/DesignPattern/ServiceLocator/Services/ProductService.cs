using ServiceLocatorDesignPattern.Concrete.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorDesignPattern.Services
{
    public class ProductService : IProductService
    {
        public string GetTitle()
        {
            return "Test Product";
        }
    }
}
