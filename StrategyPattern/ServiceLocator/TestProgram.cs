using ServiceLocatorDesignPattern.Concrete.Abstract;
using ServiceLocatorDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorDesignPattern
{
    public  class TestProgram
    {
        public void Test()
        {
            IProductService productClientService = ServiceLocator.GetService<IProductService>();

            string productTitle = productClientService.GetTitle();

            Console.WriteLine($"{productTitle} --> TestProgram.cs");
        }
    }
}
