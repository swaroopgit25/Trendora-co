using Ardalis.Specification;
using Trendora.ApplicationCore.Entities.OrderAggregate;

namespace Trendora.ApplicationCore.Specifications;

public class CustomerOrdersSpecification : Specification<Order>
{
    public CustomerOrdersSpecification(string buyerId)
    {
        Query.Where(o => o.BuyerId == buyerId)
            .Include(o => o.OrderItems);
    }
}

