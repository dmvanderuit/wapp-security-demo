# Uitwerking

In dit bestand vind je stap voor stap wat nodig is om de applicatie veilig te maken.

## SQL Injection

1. Open `Controllers/BankAccountController.cs`
2. Vervang `var retrievedAccount = ...` door het volgende:

```c#
var retrievedAccount =
    await _context.BankAccounts.Where(acc =>
    acc.AccountNumber == account.AccountNumber).ToListAsync();
```

3. Je hebt de applicatie nu veilig gemaakt voor SQL injection. Zoals je ziet is het bijna moeilijker om de applicatie
   onveilig te maken dan de applicatie veilig te houden. Maak altijd gebruik van de aanbevolen methodes van het
   framework dat je gebruikt. Als je om wat voor reden dan ook tóch gebruik wil maken van de methode die niet aanbevolen
   is door de maker van het framework, houd dan de waarschuwingen van de ontwikkelaar in de gaten (zoals ook bij de
   documentatie van `FromSqlRaw()`,
   zoals [hier](https://docs.microsoft.com/en-us/ef/core/querying/raw-sql#passing-parameters) te zien in het oranje
   blok).

## Cross side scripting

1. Open `Views/Question/Index.cshtml`
2. Vervang

```html
    <p>@Html.Raw(Model.Description)</p>
```

Door

```html
    <p>@Model.Description</p>
```

3. Je applicatie is nu veilig voor Cross Side Scripting. Hier wederom de aanbeveling houd de aanbevolen methodes aan die
   de ontwikkelaar voorschrijft. In de zeldzame gevallen dat het gewenst is om de onveilige `@HtmlRaw` toch te
   gebruiken, let dan op dat je je applicatie zo veel mogelijk beveiligt.