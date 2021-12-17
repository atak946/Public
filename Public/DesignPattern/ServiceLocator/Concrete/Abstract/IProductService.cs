using System.ServiceModel;

namespace ServiceLocatorDesignPattern.Concrete.Abstract
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string GetTitle();
    }
}
