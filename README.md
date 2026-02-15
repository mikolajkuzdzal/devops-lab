# devops-lab

# DevOps Lab – Aplikacja Webowa 

## Opis projektu

Projekt przedstawia prostą aplikację webową (API) przygotowaną w ramach zajęć z przedmiotu DevOps. Celem projektu było przejście przez pełny proces wytwarzania i wdrażania aplikacji z wykorzystaniem dobrych praktyk DevOps. Projekt obejmuje stworzenie aplikacji w ASP.NET Core, jej konteneryzację przy użyciu Dockera, konfigurację procesu Continuous Integration (CI) w GitHub Actions (build, testy, budowa obrazu Docker), a następnie konfigurację Continuous Deployment (CD) do Microsoft Azure App Service. W projekcie wykorzystano GitHub Secrets do bezpiecznego przechowywania danych konfiguracyjnych oraz Docker Hub jako rejestr obrazów kontenerów. Aplikacja jest automatycznie budowana, testowana oraz wdrażana po wykonaniu merge do gałęzi `main`.

## Technologie

Projekt został wykonany przy użyciu następujących technologii:
- ASP.NET Core
- Docker
- GitHub Actions (CI/CD)
- Docker Hub
- Microsoft Azure App Service (Linux)

## Działanie aplikacji

Aplikacja udostępnia prosty endpoint HTTP:

GET /

Odpowiedź aplikacji:

{
  "status": "ok"
}

## Uruchomienie projektu lokalnie

Wymagania:
- Zainstalowany .NET SDK
- Zainstalowany Docker

Uruchomienie bez Dockera:

1. Przywrócenie zależności:
   dotnet restore
2. Budowa projektu:
   dotnet build
3. Uruchomienie:
   dotnet run

Aplikacja będzie dostępna pod adresem:
http://localhost:8080

Uruchomienie przy użyciu Dockera:

1. Zbudowanie obrazu:
   docker build -t devops-lab-app .
2. Uruchomienie kontenera:
   docker run -p 8080:8080 devops-lab-app

Aplikacja będzie dostępna pod adresem:
http://localhost:8080

## Proces CI/CD

W projekcie skonfigurowano pipeline GitHub Actions, który realizuje:
- automatyczny build projektu
- uruchamianie testów jednostkowych
- budowę obrazu Docker
- push obrazu do Docker Hub
- automatyczne wdrożenie do Azure App Service

Pipeline uruchamia się automatycznie po wykonaniu merge do gałęzi `main`.

## Wdrożenie

Aplikacja została wdrożona w Microsoft Azure App Service (Linux, Docker). Wdrożenie odbywa się automatycznie poprzez pipeline CI/CD. Aplikacja jest publicznie dostępna pod adresem wygenerowanym przez Azure (`https://devops-lab-mk.azurewebsites.net`).


