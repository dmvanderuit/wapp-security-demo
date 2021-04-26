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
bestand `appsettings.LocalDB.json` en hernoem je de kopie naar `appsettings.json`. Vervolgens moet de database aangemaakt
worden. Dit gebeurd doormiddel van EF Core. Voeren het volgende commando uit in de therminal ``` CRTL+` ``` om een database aan te maken
```
dotnet ef database update
```
Start de applicatie en alles draait
met een lokale database.

### Docker

Om de applicatie te starten (aangeraden voor Mac-/Linux-gebruikers), controleer je of je zowel Docker als Docker Compose
op je systeem hebt draaien (run `docker -v`
en `docker-compose -v`. Als beide commando's een versienummer teruggeven, is alles correct ingesteld).

Kopieer het bestand `appsettings.Docker.json` en hernoem de kopie naar `appsettings.json`. Open een nieuw
terminal-venster (en navigeer naar de root van het project, waar ook de nieuwe `appsettings.json` staat) en run het
volgende commando: `docker-compose -f Docker/docker-compose.yml up`. Start de applicatie en alles draait met de database
in Docker. Je kunt eventueel zelf de data inzien door te verbinden via een database-programma op poort 1433.

Start de applicatie en alles draait
met een lokale database.

### Uitvoeren
Open de browser en ga naar `https://localhost:44365/`. 
Je bent nu op de website van een bank. 
Klik op `Rekening inzien` voor het uitvoeren van een SQL Injection. 

1. Zoek op brankrekening nummer 001 en bekijk de data die is opgehaald.
2. Voer vervolgens een SQL injection in het zoek veld. `1 or 1=1` 
3. Bekijk de injection en vraag jezelf af wat je hier nu precies doet.
4. Alle rekeningnummers zijn nu opgehaald uit de database, Gefeliciteerd je bent een hacker!.
6. Klik linksboven op de navigeer balk op `HANBank`.

Je bent nu weer op de hoofdpagina, klik op `Plaats support aanvraag` voor het uitvoeren van een XSS Injection.
Op de pagina zien we een Title en een Beschrijving veld. Deze velden kunnen we gebruiken om een XSS Injection uit te voeren.
De vraag die we hier stellen aan support wordt opgeslagen en weergegeven als er op de knop `Stel je vraag` klikt.
Doordat hier de input geladen wordt. Kunnen we een XSS Injection invoeren. 

1. Geef de vraag een willekeurige titel.
2. Voer het volgende script toe aan de beschrijving ```<script>alert('XSS-Injection')</script>```
3. Klik op `Stel je vraag`
4. Het zojuist ingevoerde script is nu uitgevoerd.

Je hebt nu twee vormen van injections uitgevoert een SQL en XSS Injection


