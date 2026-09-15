using System.Threading;

namespace Sales;

public static class OrdersApi
{
    private static long _orderNumber;

    public static IEndpointRouteBuilder MapOrders(this IEndpointRouteBuilder app)
    {

        app.MapPost("/orders", (OrdersMetrics metrics) =>
        {
            var orderNumber = Interlocked.Increment(ref _orderNumber);
            Thread.Sleep(orderNumber % 10 == 0 ? 1000 : 200);
            metrics.OrderPlaced();
            return Results.Accepted();
        });

        return app;
    }
}