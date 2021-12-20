using Basket.Abstract;
using Basket.Dtos;
using MicroService.Shared.Dtos;
using System.Text.Json;

namespace Basket.Concrete
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> Delete(string userId)
        {
            var status = await _redisService.GetDb().KeyDeleteAsync(userId);
            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket not found", 404);
        }

        public async Task<Response<BasketDto>> GetBasket(string userId)
        {
            var existBasket = await _redisService.GetDb().StringGetAsync(userId);

            if (existBasket.IsNullOrEmpty)
            {
                return Response<BasketDto>.Fail("Basket not found", 404);
            }

            BasketDto result = JsonSerializer.Deserialize<BasketDto>(existBasket) ?? new BasketDto();

            return Response<BasketDto>.Success(result, 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketDto)
        {
            string basketJson = JsonSerializer.Serialize(basketDto);

            var status = await _redisService.GetDb().StringSetAsync(basketDto.UserId, basketJson);

            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket could not update or save", 500);
        }
    }
}
