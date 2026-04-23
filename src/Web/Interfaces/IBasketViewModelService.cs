using Trendora.ApplicationCore.Entities.BasketAggregate;
using Trendora.Web.Pages.Basket;

namespace Trendora.Web.Interfaces;

public interface IBasketViewModelService
{
    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    Task<int> CountTotalBasketItems(string username);
    Task<BasketViewModel> Map(Basket basket);
}

