using Trendora.ApplicationCore.Entities.OrderAggregate;
using Trendora.ApplicationCore.Interfaces;
using Trendora.ApplicationCore.Specifications;
using Trendora.Web.Features.OrderDetails;
using NSubstitute;
using Xunit;

namespace Trendora.UnitTests.MediatorHandlers.OrdersTests;

public class GetOrderDetails
{
    private readonly IReadRepository<Order> _mockOrderRepository =  Substitute.For<IReadRepository<Order>>();
    
    public GetOrderDetails()
    {
        var item = new OrderItem(new CatalogItemOrdered(1, "ProductName", "URI"), 10.00m, 10);
        var address = new Address("", "", "", "", "");
        Order order = new Order("buyerId", address, new List<OrderItem> { item });
                
        _mockOrderRepository.FirstOrDefaultAsync(Arg.Any<OrderWithItemsByIdSpec>(), Arg.Any<CancellationToken>())
            .Returns(order);
    }

    [Fact]
    public async Task NotBeNullIfOrderExists()
    {
        var request = new Trendora.Web.Features.OrderDetails.GetOrderDetails("SomeUserName", 0);

        var handler = new GetOrderDetailsHandler(_mockOrderRepository);

        var result = await handler.Handle(request, TestContext.Current.CancellationToken);

        Assert.NotNull(result);
    }
}



