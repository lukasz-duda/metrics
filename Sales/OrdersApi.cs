namespace Sales;

public static class OrdersApi
{
    public static IEndpointRouteBuilder MapOrders(this IEndpointRouteBuilder app)
    {

        app.MapPost("/orders", (OrdersMetrics metrics) =>
        {
            metrics.OrderPlaced();
            return Results.Accepted();
        });

        return app;
    }
}