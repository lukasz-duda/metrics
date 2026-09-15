using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;

var serviceName = "Service";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService(serviceName))
    .WithMetrics(metrics => metrics
        .AddAspNetCoreInstrumentation()
        .AddHttpClientInstrumentation()
        .AddPrometheusExporter());

var app = builder.Build();

app.MapGet("/", () => serviceName);

app.MapPrometheusScrapingEndpoint();

app.Run();
