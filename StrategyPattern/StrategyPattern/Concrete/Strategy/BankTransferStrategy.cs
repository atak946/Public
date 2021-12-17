using StrategyPattern.Concrete.Abstract;
using System.Diagnostics;

namespace StrategyPattern.Concrete.Strategy
{
    public class BankTransferStrategy : IPayment
    {
        public void MakePayment()
        {
            Debug.WriteLine("Havale yöntemi ile ödeme yapıldı");
        }
    }
}
