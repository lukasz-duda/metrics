#!/bin/bash
for i in {1..600}; do
  echo -n "Place an order $i... "
  curl -X POST http://localhost:8080/orders \
    -H "Content-Type: application/json" \
    -d '{}'
  echo "wait 1s..."
  sleep 1
done