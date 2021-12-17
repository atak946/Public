using ServiceLocatorDesignPattern;
using ServiceLocatorDesignPattern.Concrete.Abstract;
using ServiceLocatorDesignPattern.Services;

IProductService productService = new ProductService();

ServiceLocator.RegisterService(productService);

IProductService productClientService = ServiceLocator.GetService<IProductService>();

string productTitle = productClientService.GetTitle();

Console.WriteLine($"{productTitle} --> Program.cs");

TestProgram testProgram = new TestProgram();

testProgram.Test();