# En-komplett-webbapplikation - Januari 2022
## Instruktioner
**Starta applikationen**
1. Ladda ner repot från https://github.com/jajo21/En-komplett-webbapplikation
2. Leta upp valfri terminal och utgå från mappen "./Source/Rovers.API"
3. Applikationen kräver att du har .NET5.0 SDK installerat
4. Skriv kommandot ```dotnet run``` i terminalen
5. Applikationen körs nu på port 5000 och 5001
6. Öppna en webbläsare och navigera in på https://localhost:5001/ för att testa klientgränssnittet.
7. Vill du endast kontrollera API-åtkomstpunkterna så navigera in på **https://localhost:5001/api/rovers eller https://localhost:5001/api/rovers/{roverId}**

**För att applikationen ska fungera**
1. Navigera in på https://api.nasa.gov/ och registera dig för att få en api-nyckel
2. I filen "./Source/Rovers.API/wwwroot/script.js" byter du ut variabeln apiKey värdet till api-nyckeln du får från NASA
3. Nu kan du start om applikationen på nytt

## Syfte - YH-utbildning: Webbutvecklare .NET
* Inlämningsuppgift i kursen Dynamiska Webbsystem 2 - Januari 2022
* Beskrivning: Här ska jag bygga ett klientgränssnitt som hämtar data från NASA:s API, men även lägga till funktionalitet från ett eget skapat REST-API för att demonstrera att jag har förståelse för båda delarna.
* Resultat: 100/100 (G)

## Tekniker
* C#
* ASP.NET Core
* Entity Framework Core
* REST-API
* In Memory Database
* JavaScript
* Fetch-API
* HTML
* CSS

## Kravspecifikation
[Inlämning - En komplett webbapplikation.pdf](https://github.com/jajo21/En-komplett-webbapplikation/files/8840142/Inlamning.-.En.komplett.webbapplikation.pdf)

## Förtydliganden/motivering
Jag har skapat två varianter av den här uppgiften. En som är mer likt den interaktiva guiden och en som är mer likt Shawns sätt på pluralsight att bygga ett REST-API. Jag blev lite fundersam vilken jag skulle lämna in men tänkte sen att det inte spelar så stor roll. Båda fungerar, men en reflektion jag har är att Shawns sätt att bygga känns tydligare och mer dry på något sätt. Det kan ha mycket att göra med att det liknar mer sättet att bygga som vi har gjort i tidigare MVC-projekt. Repot jag tänkte lämna in följer ändock fortfarande den interaktiva guiden. Med tiden lär man sig säkert sina egna preferencer hur man vill skapa ett projekt för största möjliga tydlighet. Sen lär man få anpassa sig tänker jag, om man på en arbetsplats får hoppa in i olika projekt. 

Har även testat mig på att applicera API:t på vårat befintliga hackaton-klientgränssnitt. Jag kände dock att det var något jag ville träna mer på så jag byggde helt enkelt ett helt nytt för att fräscha upp minnet än en gång. Jag hade lika gärna kunnat använda det befintliga och utveckla det men känner ändå nu i slutändan att det gav mig mer att skapa ett till nytt.

Har även tänkt på användningen av automapper och "Resources" i den här lilla uppgiften. Det känns lite överflödigt och är inte så dry i det här fallet eftersom man ändå skickar med all information. Det har jag ändå valt att ha med i uppgiften, mer för att träna på hur det fungerar än något annat.

Har även tränat lite på moduler i javascript under den här övningen. Men någonstans tyckte jag att mitt skapade klientgränssnitt blev tydligare utan modulindelningen, så jag valde att ta bort detta. Lite mer träning så kan man nog bygga mer tydlighet via moduler i javascript.
