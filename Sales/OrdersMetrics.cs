using System.Diagnostics.Metrics;

namespace Sales;

public class OrdersMetrics
{
    private readonly Counter<long> _ordersPlaced;

    public OrdersMetrics(IMeterFactory meterFactory)
    {
        var meter = meterFactory.Create(Service.Name);
        _ordersPlaced = meter.CreateCounter<long>("store.orders_placed");
    }

    public void OrderPlaced()
    {
        _ordersPlaced.Add(1);
    }
}