using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrategyPattern.Concrete.Strategy;
using StrategyPattern.Models;
using StrategyPattern.Services;

namespace StrategyPattern.Pages
{
    public class IndexModel : PageModel
    {
        #region Query Parameters
        [BindProperty(SupportsGet = false)]
        public ePaymentType PaymentType { get; set; }
        #endregion

        #region Ctor variables
        private readonly ILogger<IndexModel> _logger; 
        private PaymentService _paymentService;
        #endregion

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _paymentService = PaymentType switch
            {
                ePaymentType.MailOrder => new PaymentService(new MailOrderStrategy()),
                ePaymentType.BankTransfer => new PaymentService(new BankTransferStrategy()),
                ePaymentType.CreditCard => new PaymentService(new CreditCardStrategy()),
                _ => throw new NullReferenceException(),
            };

            _paymentService.MakePayment();
        }
    }
}