using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using Store;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<OrdersMetrics>();

builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService(Service.Name))
    .WithMetrics(metrics => metrics
        .AddMeter(Service.Name)
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddPrometheusExporter());

var app = builder.Build();

app.MapGet("/", () => Service.Name);

app.MapOrders();

app.MapPrometheusScrapingEndpoint();

app.Run();
