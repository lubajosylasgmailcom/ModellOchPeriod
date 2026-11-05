# ModellOchPeriod

En liten konsolapp där kunden väljer utrustningsmodell och hyresperiod.
Programmet kontrollerar datumet och visar en sammanfattning.
Ingen bokning skapas.

## Köra programmet

Kräver .NET 10 SDK.

1. Klona eller ladda ner projektet.
2. Öppna lösningen i Visual Studio med stöd för .NET 10.
3. Kör med Ctrl + F5.
4. Välj modell och ange datum i formatet yyyy-MM-dd.

## Datumregler

- Startdatum får inte vara före dagens datum.
- Slutdatum får inte vara före startdatum.
- Vid fel får kunden ange nya datum.

## Verifiering

Manuellt testat:
- Giltig period visar en sammanfattning.
- Slutdatum före startdatum ger ett felmeddelande.
- Startdatum i det förflutna ger ett felmeddelande.
- Efter rättning visas sammanfattningen med samma modell.
