# H1

Template projekt til H1 (Aspire lokalt, Docker/Dokploy i produktion).

| | |
|---|---|
| **Live** | https://h1.mercantec.tech |
| **DB UI** | https://h1-db.mercantec.tech |
| **Oversigt** | https://h.mercantec.tech |

## Deploy

```bash
cp .env.example .env
docker compose up -d --build
```

Lokalt med host-porte:

```bash
docker compose -f docker-compose.yml -f docker-compose.local.yml up --build
```
