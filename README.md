# Observability - Metrics

https://learn.microsoft.com/en-us/dotnet/core/diagnostics/metrics-instrumentation

https://mikroserwisy-revisited.pl/

Requirements:

1. [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
2. [Docker](https://docs.docker.com/engine/install/ubuntu/)

Start:

```
./start
```

Setup [Graphana](http://localhost:3000):

1. Login as user `admin` with password `admin`.
1. Add new Prometheus connection `  `.
1. Import Dashboard `sales-dashboard.json`.
