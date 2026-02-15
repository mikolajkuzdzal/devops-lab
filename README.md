# devops-lab
# DevOps Lab – CI/CD + Azure App Service

## Opis projektu
Projekt demonstracyjny DevOps pokazujący pełny pipeline:

- Repozytorium GitHub
- Dockerfile
- GitHub Actions (CI)
- Continuous Deployment (CD)
- Azure App Service (Linux, kontener)
- Publikacja obrazu do Docker Hub

---

## Pipeline

1. Build aplikacji
2. Budowa obrazu Docker
3. Push do Docker Hub
4. Deploy na Azure App Service

Pipeline realizowany przez GitHub Actions.


## Deployment

Aplikacja wdrożona na:
Azure App Service (Linux, B1)

Publiczny URL:
`https://devops-lab-mk.azurewebsites.net`

---

## Konfiguracja

W projekcie użyto GitHub Secrets:
- DOCKER_USERNAME
- DOCKER_PASSWORD
- AZURE_WEBAPP_PUBLISH_PROFILE

---

## Status

Projekt ukończony.
CI/CD działa poprawnie.
Deployment zakończony sukcesem.
