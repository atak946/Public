using StrategyPattern.Concrete.Abstract;
using System.Diagnostics;

namespace StrategyPattern.Concrete.Strategy
{
    public class MailOrderStrategy : IPayment
    {
        public void MakePayment()
        {
            Debug.WriteLine("Mail order yöntemi ile ödeme yapıldı");
        }
    }
}
