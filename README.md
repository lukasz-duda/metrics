# Observability - Metrics

https://learn.microsoft.com/en-us/dotnet/core/diagnostics/metrics-instrumentation

https://mikroserwisy-revisited.pl/

Requirements:

1. [.NET 10](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
2. [Docker](https://docs.docker.com/engine/install/ubuntu/)

Start sales services:

```bash
./start
```

Open [Grafana](http://localhost:3000):

1. Login as user `admin` with password `admin`.
1. Open the automatically provisioned `Sales` dashboard.

Test order with 1s delay between requests:

```bash
./test.sh
```

[sales-dashboard.webm](https://github.com/user-attachments/assets/f4e1b5cb-36cb-4b39-85df-e00150fda32d)
