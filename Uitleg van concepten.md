# C\# Programmeren: Van Basis tot Verdieping

## Inleiding tot C\#

C\# (uitgesproken als "C-Sharp") is een moderne, objectgeoriënteerde programmeertaal ontwikkeld door Microsoft als onderdeel van het .NET-framework. Het is een taal die veel wordt gebruikt om desktop-, web- en mobiele applicaties en games te ontwikkelen. 
C\# is krachtig én eenvoudig, waardoor het ideaal is voor beginners en gevorderden.

---

## Je ontwikkelomgeving Instellen

### Visual Studio Code 

TODO in de webbrowser

---

## Deel 1: Basisbeginselen van C\#

We beginnen eerst met de basis concepten van deze programmeertaal.

### Variabelen en Datatypes

Stel je voor dat je een grote doos hebt waar je iets in kunt stoppen, zoals knikkers, snoepjes of een briefje. In C# noemen we zo’n doos een variabele. Je kunt de doos een naam geven, zodat je later precies weet wat erin zit, bijvoorbeeld “leeftijd” of “naam”.

Maar niet elke doos is hetzelfde! Sommige dozen zijn speciaal voor getallen, andere voor woorden of zinnen, en weer andere voor ja/nee-antwoorden. Dit noemen we het datatype van de doos. Zo weet de computer precies wat voor soort informatie er in de doos mag:
- Een doos voor getallen heet bijvoorbeeld int (zoals 7 of 42).
- Een doos voor tekst heet string (zoals "Hallo!").
- Een doos voor ja/nee heet bool (zoals true of false).

Dus:
 - Een variabele is een doos waar je iets in stopt, zodat je het later weer kunt gebruiken.
 - Het datatype is het soort doos, zodat je weet wat voor soort informatie er in mag.

Hieronder staan de belangrijkste en meest gebruikte datatypen met en aantal voorbeelden.   

| Datatype | Beschrijving | Voorbeeld |
| :-- | :-- | :-- |
| int | Gehele getallen | `int leeftijd = 25;` |
| double | Decimale getallen | `double lengte = 1.85;` |
| string | Tekst | `string naam = "Jan";` |
| bool | Waar/onwaar | `bool isStudent = true;` |
| char | Eén karakter | `char grade = 'A';` |

```csharp
string naam = "Anna";
int leeftijd = 28;
double lengte = 1.72;
bool isStudent = false;

Console.WriteLine("Naam: " + naam);
Console.WriteLine("Leeftijd: " + leeftijd);
Console.WriteLine("Lengte: " + lengte + " meter");
Console.WriteLine("Student: " + isStudent);
```

---

### Operatoren

Je gebruikt **operators** in C# om de computer iets te laten doen met getallen, woorden of andere stukjes informatie. Je kunt operators zien als de rekentekens of vergelijk-tekens die je kent van school.

**Stel je voor:**

Je hebt twee getallen, bijvoorbeeld 5 en 3.
- Met de **+ operator** kun je ze optellen: `5 + 3` wordt 8.
- Met de **- operator** kun je ze aftrekken: `5 - 3` wordt 2.
- Met de **== operator** kun je kijken of twee dingen gelijk zijn: `5 == 3` is niet waar, maar `5 == 5` is wel waar.
- Met de **> operator** kun je kijken of iets groter is: `5 > 3` is waar.

Er zijn verschillende soorten operators:
- **Reken-operators**: voor optellen (+), aftrekken (-), vermenigvuldigen (*), delen (/) en de rest na delen (%).
- **Vergelijkingsoperators**: om te kijken of iets gelijk, groter of kleiner is (`==`, `!=`, `>`, `<`).
- **Logische operators**: om ja/nee-vragen te combineren, bijvoorbeeld met `&&` (en) en `||` (of).

**Kortom:**  
Met operators kun je de computer laten rekenen, vergelijken of slimme keuzes laten maken. Het zijn “tools waarmee je een opdracht geeft aan de computer.

Hieronder staan de belangrijkste en meest gebruikte operatoren met en aantal voorbeelden. 
- **Rekenkundig:** `+`, `-`, `*`, `/`, `%`
- **Vergelijking:** `==`, `!=`, `>`, `<`, `>=`, `<=`
- **Logisch:** `&&`, `||`, `!`

```csharp
int a = 10;
int b = 3;
Console.WriteLine("a + b = " + (a + b));
Console.WriteLine("a % b = " + (a % b));
```

---

#### If-Else

Een if else statement in C# gebruik je om de computer te laten kiezen wat hij moet doen, afhankelijk van een vraag of situatie. Je kunt het vergelijken met een keuze maken in het dagelijks leven.

Stel je voor:
Je moeder vraagt: "Als het regent, neem dan een paraplu mee, anders niet."
Als het regent (dat is de voorwaarde), dan pak je een paraplu.
Anders (het regent niet), doe je dat niet.

In C# werkt het net zo! Je vertelt de computer:
Als iets waar is, doe dan dit.
Anders (als het niet waar is), doe dan iets anders.

```csharp
int leeftijd = 12;

if (leeftijd < 18)
{
    Console.WriteLine("Je bent minderjarig.");
}
else
{
    Console.WriteLine("Je bent volwassen.");
}
```
In dit voorbeeld kijkt de computer of de leeftijd kleiner is dan 18.
Als dat zo is, laat hij zien: "Je bent nog geen 18, dus je bent een kind."
Anders laat hij zien: "Je bent 18 of ouder, dus je bent volwassen."

**Waarom is dit handig?**
Met if else statements kan je programma slimme keuzes maken, net als jij zelf doet! Zo kun je je code laten reageren op wat er gebeurt, bijvoorbeeld op wat iemand invult of op het weer.

**Kortom:**
Je gebruikt een if else statement om de computer te laten kiezen tussen twee dingen: als iets klopt, doe het eerste, anders doe het tweede.

#### Switch

Je gebruikt een switch statement in C# om de computer te laten kiezen tussen meerdere mogelijkheden, afhankelijk van de waarde van iets. Het is alsof je een vraag hebt waarbij er voor elk mogelijk antwoord heb je een eigen plan.

**Stel je voor:**
Je hebt een cijfer van de dag van de week (bijvoorbeeld 1 voor maandag, 2 voor dinsdag, enzovoorts) en je wilt weten welke dag het is.
Met een switch statement kun je voor elk cijfer een andere boodschap laten zien:

```csharp
int dag = 3;

switch (dag)
{
    case 1:
        Console.WriteLine("Het is maandag");
        break;
    case 2:
        Console.WriteLine("Het is dinsdag");
        break;
    case 3:
        Console.WriteLine("Het is woensdag");
        break;
    case 4:
        Console.WriteLine("Het is donderdag");
        break;
    // ... enzovoorts
    default:
        Console.WriteLine("Dit is geen geldige dag!");
        break;
}
```
De computer kijkt naar de waarde van dag.
Bij elk case-blok staat wat er moet gebeuren als het getal overeenkomt.
Met default kun je iets doen als geen van de antwoorden klopt (bijvoorbeeld als iemand 8 invult).

**Waarom is dit handig?**
Met een switch statement kun je makkelijk veel keuzes maken zonder heel veel if else te hoeven schrijven. Het is overzichtelijk als je veel verschillende mogelijkheden hebt.

**Kortom:**
Je gebruikt een switch statement om de computer te laten kiezen uit meerdere opties, afhankelijk van de waarde van een variabele. Zo kun je voor elk mogelijk antwoord iets anders laten gebeuren, net als bij een keuzemenu!

---

### Loops

#### For-Loop

Je gebruikt een for loop in C# als je wilt dat de computer een stukje code meerdere keren achter elkaar uitvoert, bijvoorbeeld als je iets wilt herhalen of wilt tellen.

**Stel je voor:**
Je wilt de getallen 1 tot en met 10 op het scherm laten zien. In plaats van tien keer dezelfde regel te schrijven, kun je een for loop gebruiken. De computer doet dan automatisch het herhalen voor jou!

**Zo werkt het:**
Je zegt waar de computer moet beginnen met tellen (bijvoorbeeld bij 1).

Je zegt tot welk getal hij moet doorgaan (bijvoorbeeld tot 10).

Je zegt hoe hij moet tellen (bijvoorbeeld steeds 1 erbij).

Voorbeeld:

```csharp
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
```
Hier begint de computer bij 1, en elke keer dat hij het stukje code uitvoert, telt hij er 1 bij op, tot en met 10. Zo print hij netjes de getallen 1 tot en met 10 onder elkaar.

**Waarvoor kun je een for loop gebruiken?**
- Als je iets een vast aantal keer doen (bijvoorbeeld 10 keer een sterretje printen).
- Door een lijstje of rijtje heen lopen (bijvoorbeeld alle namen in een lijst laten zien).
- Snel en makkelijk veel herhalingen uitvoeren zonder alles zelf te hoeven schrijven.

**Kortom:**
Een for loop is handig als je wilt dat de computer iets vaak of meerdere keren doet, zonder dat je alles zelf hoeft te herhalen.

#### While-Loop

Je gebruikt een while loop in C# als je wilt dat de computer iets blijft herhalen, zolang iets klopt. Het is alsof je zegt: “Blijf dit doen, zolang het mag.”

**Stel je voor:**
Je wilt net zo lang door snoepen uit een zakje, terwijl er nog snoepjes in zitten.
Zolang het zakje niet leeg is, pak je er steeds eentje uit.
Als het zakje leeg is, stop je.
In C# werkt dat net zo! Je geeft de computer een opdracht, en hij blijft die uitvoeren zolang een bepaalde voorwaarde waar is.

Voorbeeld:
```csharp
int i = 0;

while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```
Hier zegt je tegen de computer:
Begin bij 0.
Zolang i kleiner is dan 5, laat het getal zien en tel er 1 bij op.
Als i de waarde 5 heeft, stopt de loop.

**Waarvoor kun je een while loop gebruiken?**
- Iets herhalen als je nog niet weet hoe vaak (bijvoorbeeld: vragen blijven stellen tot iemand het juiste antwoord geeft).
- Door blijven tellen of werken tot een bepaalde situatie verandert.
- Spelletjes: bijvoorbeeld doorgaan tot het spel afgelopen is.

**Kortom:**
Een while loop gebruik je als je wilt dat de computer iets blijft doen, zolang een bepaalde regel klopt. Het is handig als je niet van tevoren weet hoe vaak iets moet gebeuren, maar wel weet wanneer je wilt stoppen.

---

### Arrays en Lijsten

#### Array

Je gebruikt een array in C# als je veel dingen van hetzelfde soort wilt bewaren onder één naam, zodat je ze makkelijk samen kunt gebruiken en terugvinden.

**Stel je voor:**
Je hebt een doos met vakjes, en in elk vakje kun je iets stoppen, bijvoorbeeld een getal of een naam. Elk vakje heeft een nummer (de index), zodat je precies weet waar iets ligt. In plaats van voor elk getal een aparte doos (variabele) te maken, kun je met een array alles netjes op een rijtje zetten.

Hier heb je één array met vijf scores. Je kunt nu makkelijk bij elk getal komen door het vakje-nummer (de index) te gebruiken:
```csharp
int[] scores = { 8, 7, 10, 6, 9 };

Console.WriteLine(scores[0]); // Dit geeft 8, want het eerste vakje is nummer 0
Console.WriteLine(scores[3]); // Dit geeft 6, want het vierde vakje is nummer 3
```

Een array kan bijvoorbeeld ook worden gebruikt om namen in op te slaan:
```csharp
string[] namen = { "Jan", "Piet", "Klaas" };
for (int i = 0; i < namen.Length; i++)
{
    Console.WriteLine(namen[i]);
}
```

**Waarvoor is een array handig?**
- Als je veel dezelfde dingen wilt bewaren, zoals de namen van alle kinderen in de klas of de punten van een spelletje.
- Als je snel alle dingen wilt bekijken of iets wilt uitrekenen met alles tegelijk, bijvoorbeeld de som of het gemiddelde.
- Als je niet voor elk ding een aparte variabele wilt maken, maar alles netjes bij elkaar wilt houden.

**Kortom:**
Met een array kun je een hele rij (of zelfs een tabel) van dezelfde soort dingen makkelijk bewaren, terugvinden en gebruiken in je programma

#### List
Je gebruikt een list (lijst) in C# als je een rijtje dingen wilt bewaren, maar je weet nog niet precies hoeveel het er gaan worden, of als je makkelijk dingen wilt toevoegen of weghalen. Een list lijkt een beetje op een array (een rij vakjes), maar een list is veel flexibeler.

**Stel je voor:**
Je hebt een doos waar je steeds meer knikkers in kunt stoppen, zonder dat je van tevoren hoeft te zeggen hoeveel knikkers erin passen. Als je een nieuwe knikker vindt, kun je die gewoon erbij stoppen. Wil je er eentje uithalen? Dat kan ook makkelijk!

**Zo werkt het in C#:**

Je maakt een list aan, bijvoorbeeld voor namen:
```csharp
List<string> namen = new List<string>();
```
Je kunt namen toevoegen:

```csharp
namen.Add("Emma");
namen.Add("Noah");
```
Je kunt namen weghalen:

```csharp
namen.Remove("Emma");
```
**Waarom is een list handig?**
- Je hoeft niet vooraf te weten hoeveel dingen je wilt bewaren (zoals bij een array wel moet).
- Je kunt makkelijk iets toevoegen of weghalen wanneer je wilt.
- Je kunt door alle dingen in de lijst heenlopen, net als bij een array.
- Je hebt veel handige extra functies om te sorteren, zoeken of tellen.

**Kortom:**
Een list gebruik je als je een flexibel lijstje wilt maken waar je makkelijk dingen aan toe kunt voegen of uit kunt halen, zonder dat je van tevoren weet hoeveel het er precies worden.

---

### Methoden (Functies)

Stel je voor dat je een robot hebt die steeds dezelfde taak voor je kan doen, zoals een liedje zingen, een som uitrekenen of iemand begroeten. In C# gebruik je een methode om zo’n taak op te schrijven, zodat je die taak makkelijk steeds opnieuw kunt laten uitvoeren wanneer je wilt.

**Wat is een methode?**
Een methode is een soort “recept” of “instructie” voor de computer. Je schrijft één keer op wat er moet gebeuren, en daarna kun je de methode elke keer aanroepen als je die taak wilt laten doen.

**Waarom is dat handig?**
- Je hoeft niet steeds dezelfde code opnieuw te schrijven.
- Je kunt je programma netjes en overzichtelijk houden.
- Je kunt je eigen taken een naam geven, zoals ZingLiedje() of TelOp().

Voorbeeld:
```csharp
void Begroet()
{
    Console.WriteLine("Hallo! Leuk dat je er bent.");
}

// Je kunt nu steeds Begroet() aanroepen als je iemand wilt begroeten:
Begroet();
Begroet();
```
**Waarvoor gebruik je een methode?**
- Om een taak die je vaak doet, makkelijk opnieuw te gebruiken.
- Om je code op te delen in kleine stukjes die makkelijk te begrijpen zijn.
- Om je programma overzichtelijk en netjes te houden.

**Kortom:**
Een methode gebruik je om een taak op te schrijven die je vaker wilt doen. Zo kun je de computer steeds opnieuw dezelfde opdracht laten uitvoeren, zonder alles steeds opnieuw te hoeven typen.

---

## Deel 2: Geavanceerde Concepten

### Klassen en Objecten

```csharp
class Persoon
{
    public string naam;
    public int leeftijd;

    public void StelJeVoor()
    {
        Console.WriteLine("Hallo, ik ben " + naam + " en ik ben " + leeftijd + " jaar oud.");
    }
}
```

---

### Constructors

```csharp
class Student
{
    public string naam;
    public int leeftijd;

    public Student(string n, int l)
    {
        naam = n;
        leeftijd = l;
    }
}
```

---

### Properties

```csharp
private string _naam;
public string Naam
{
    get { return _naam; }
    set { _naam = value; }
}
```

---

### Overerving (Inheritance)

```csharp
class Voertuig
{
    public string merk;
    public void ToonInfo() { /* ... */ }
}

class Auto : Voertuig
{
    public int aantalDeuren;
}
```

---

### Polymorfisme

```csharp
class Dier
{
    public virtual void MaakGeluid() { Console.WriteLine("Dier geluid"); }
}

class Hond : Dier
{
    public override void MaakGeluid() { Console.WriteLine("Waf waf!"); }
}
```

---

### Interfaces

```csharp
interface IBeweegbaar
{
    void Beweeg();
}

class Auto : IBeweegbaar
{
    public void Beweeg() { Console.WriteLine("De auto rijdt"); }
}
```
---

### Abstracte Klassen

```csharp
abstract class Vorm
{
    public abstract double BerekenOppervlakte();
}
class Cirkel : Vorm
{
    public double Straal;
    public override double BerekenOppervlakte() => Math.PI * Straal * Straal;
}
```
---

### Exceptie Handling

```csharp
try
{
    int getal = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Geen geldig getal!");
}
```

---

### Delegates en Events

```csharp
delegate void BoodschapHandler(string boodschap);
BoodschapHandler handler = ToonBoodschap;
handler("Hallo via delegate!");
```

---

### Lambda-Expressies

```csharp
Func<int, int, int> tel_op = (x, y) => x + y;
Console.WriteLine(tel_op(5, 3));
```

---

### LINQ

```csharp
var ouderen = personen.Where(p => p.Leeftijd > 30).OrderBy(p => p.Naam);
```

---

## Conclusie en Verder Leren

Gefeliciteerd! Je bent op het einde! Je hebt nu een solide basis in C\#. Blijf oefenen, maak eigen projecten en ontdek andere onderwerpen als web development en game development met Unity.