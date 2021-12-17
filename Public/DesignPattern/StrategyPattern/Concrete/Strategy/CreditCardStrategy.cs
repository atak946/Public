using StrategyPattern.Concrete.Abstract;
using System.Diagnostics;

namespace StrategyPattern.Concrete.Strategy
{
    public class CreditCardStrategy : IPayment
    {
        public void MakePayment()
        {
            Debug.WriteLine("Kredi kartı yöntemi ile ödeme yapıldı");
        }
    }
}
