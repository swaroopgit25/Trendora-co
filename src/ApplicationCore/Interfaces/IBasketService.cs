using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using Trendora.ApplicationCore.Entities.BasketAggregate;

namespace Trendora.ApplicationCore.Interfaces;

public interface IBasketService
{
    Task TransferBasketAsync(string anonymousId, string userName);
    Task<Basket> AddItemToBasket(string username, int catalogItemId, decimal price, int quantity = 1, string selectedOptionsJson = "[]");
    Task<Result<Basket>> SetQuantities(int basketId, Dictionary<string, int> quantities);
    Task DeleteBasketAsync(int basketId);
}

