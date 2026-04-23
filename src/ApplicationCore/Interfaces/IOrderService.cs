using System.Threading.Tasks;
using Trendora.ApplicationCore.Entities.OrderAggregate;

namespace Trendora.ApplicationCore.Interfaces;

public interface IOrderService
{
    Task CreateOrderAsync(int basketId, Address shippingAddress);
}

