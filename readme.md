# Workshop/Demo

In deze Repo staan alle benodigheden voor het uitvoeren van de SQL/XSS Injection (en Identity Server / Azure Identity)
workshop.

## Introductie SQL/XSS Injection

Tijdens het volgens van deze demo is het de bedoeling dat de studenten een opdracht uitvoeren met betrekking tot
injections. Het is hierbij de bedoeling dat de studenten zelf een SQL en XSS injection gaan uitvoeren om zo de werking
te ondervinden.

### SQL Injection

Het is de bedoeling dat de student een SQL injection uitvoert om alle gebruikers uit de database te halen.

### XSS Injection

De student gaat proberen om via een XSS injection een script te laten uitvoeren via een chat functie op de site.

## Starten van de applicatie

Let op: Iedere keer dat de applicatie gestart wordt, zal de database automatisch geleegd en voorzien worden van
testdata.

### LocalDB

Om de database te starten met een lokale database (aangeraden voor Windows-gebruikers), kopieer je het
bestand `appsettings.LocalDB.json` en hernoem je de kopie naar `appsettings.json`. Start de applicatie en alles draait
met een lokale database.

### Docker

Om de applicatie te starten (aangeraden voor Mac-/Linux-gebruikers), controleer je of je zowel Docker als Docker Compose
op je systeem hebt draaien (run `docker -v`
en `docker-compose -v`. Als beide commando's een versienummer teruggeven, is alles correct ingesteld).

Kopieer het bestand `appsettings.Docker.json` en hernoem de kopie naar `appsettings.json`. Open een nieuw
terminal-venster (en navigeer naar de root van het project, waar ook de nieuwe `appsettings.json` staat) en run het
volgende commando: `docker-compose -f Docker/docker-compose.yml up`. Start de applicatie en alles draait met de database
in Docker. Je kunt eventueel zelf de data inzien door te verbinden via een database-programma op poort 1433.
