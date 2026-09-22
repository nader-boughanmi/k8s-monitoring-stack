# Kubernetes Monitoring Stack

## Overview

Containerized monitoring and application platform deployed on Kubernetes.

The project combines application hosting, database services, monitoring, logging and traffic management using cloud-native technologies.

## Technology Stack

### Platform

- Kubernetes
- Helm
- NGINX Ingress Controller

### Monitoring & Observability

- Prometheus
- Grafana
- Loki

### Application Services

- .NET 8 Web API
- PostgreSQL
- Redis

## Architecture

```text
                    NGINX Ingress
                           |
                           v

      +--------------------------------------+
      |             Kubernetes               |
      +--------------------------------------+

                |                  |
                v                  v

        Inventory API         Monitoring Stack
           (.NET)               Grafana
                |               Prometheus
                v               Loki

          PostgreSQL

                |
                v

              Redis
```

## Features

- Kubernetes workload deployment
- Application hosting with .NET
- PostgreSQL database integration
- Redis caching services
- Metrics collection with Prometheus
- Dashboard visualization with Grafana
- Centralized logging with Loki
- Traffic routing through NGINX Ingress
- Helm-based deployments

## Repository Structure

```text
k8s-monitoring-stack
│
├── Applications
│   └── inventory-api
│
├── Kubernetes
│   ├── Grafana
│   └── Postgres
│
└── README.md
```

## Components

### Inventory API

REST API developed with .NET and deployed on Kubernetes.

### PostgreSQL

Primary relational database used by the application.

### Redis

In-memory datastore used for caching.

### Prometheus

Metrics collection and monitoring platform.

### Grafana

Visualization platform providing dashboards and operational insights.

### Loki

Centralized log aggregation system.

### NGINX Ingress Controller

Ingress management and HTTP traffic routing.

## Deployment

Infrastructure services are deployed using Helm charts and Kubernetes manifests.

## Status

Active development.
