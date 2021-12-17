using StrategyPattern.Concrete.Abstract;

namespace StrategyPattern.Services
{
    public class PaymentService
    {
        private IPayment _payment;

        public PaymentService(IPayment payment)
        {
            _payment = payment;
        }

        public void MakePayment()
        {
            _payment.MakePayment();
        }
    }
}
