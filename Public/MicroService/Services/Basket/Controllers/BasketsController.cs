using Microsoft.AspNetCore.Mvc;
using MicroService.Shared.Controller;
using Basket.Abstract;
using MicroService.Shared.Abstract;
using MicroService.Shared.Dtos;
using Basket.Dtos;

namespace Basket.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BasketsController : CustomControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _identityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService identityService)
        {
            _basketService = basketService;
            _identityService = identityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {
            Response<BasketDto> result = await _basketService.GetBasket(_identityService.GetUserId);

            return CreateActionResultInstance(result);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {

        }
    }
}
