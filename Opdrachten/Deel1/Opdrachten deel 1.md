# Opdrachten per Concept

Hieronder vind je voor elk basisconcept een eenvoudige opdracht waarmee je zelf kunt oefenen. 
Bij elke opdracht staat de uitwerking in "Opdrachten deel 1 uitwerkingen". (Je mag spieken 😉).

Tip:
Gebruik dit stuk code om de computer tekst uit te laten printen.
 ```csharp
Console.WriteLine("TEKST");
```
Als je een variabele en een stuk tekst wilt uitprinten kan dat op de volgende manier met de '+' operator:
 ```csharp
string tekst = "hallo";
Console.WriteLine(test + "hallo");
```
---

## 1. Variabelen en Datatypes

**Opdracht:**
Maak een programma waarin je je eigen naam, leeftijd en favoriete dier opslaat en deze netjes op het scherm laat zien.

*Uitleg: Je gebruikt drie variabelen van verschillende soorten en je laat ze zien met `Console.WriteLine`*.

**Om je op weg te helpen:**

```csharp
string naam = "";
int leeftijd = ;
string dier = "";

Console.WriteLine(""+...+""+...+""+...+"");
```
---

## 2. Operatoren

**Opdracht:**
Laat de computer twee getallen optellen, aftrekken, vermenigvuldigen en delen. Laat alle uitkomsten zien.

*Uitleg: Gebruik `Console.WriteLine` om te zien wat er gebeurd als je met operatoren rekent in C\#*.

**Om je op weg te helpen:**
```csharp
int getal1 = ;
int getal2 = ;

Console.WriteLine(...);
```

---

## 3. If-Else Statement

**Opdracht:**
Zet in een variabele een leeftijd. Als de leeftijd kleiner is dan 12, zeg dan "Je bent een kind". Anders zeg je "Je bent een tiener of volwassene".

*Uitleg: De computer kiest wat hij moet doen op basis van de leeftijd*.

**Om je op weg te helpen:**
```csharp
int leeftijd = ;

if ()
{
    Console.WriteLine();
}
else
{
    Console.WriteLine();
}
```
---

## 4. Switch Statement

**Opdracht:**
Zet in een variabele een cijfer van 1 tot 3. Print bij 1 "Rood", bij 2 "Blauw" en bij 3 "Groen". Bij iets anders: "Onbekende kleur".

*Uitleg: Je ziet hoe de switch verschillende keuzes makkelijk maakt*.

**Om je op weg te helpen:**
```csharp
int cijfer = ;

switch()
{
    case 1:
        Console.WriteLine();
        break;    
    case 2:
        Console.WriteLine();
        break;
    case 3:
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("");
        break;
}
```
---

## 5. For Loop

**Opdracht:**
Laat de computer de getallen 1 t/m 5 onder elkaar printen.

*Uitleg: De for-loop herhaalt de opdracht vijf keer*.

**Om je op weg te helpen:**
```csharp
int cijfer = ;

for (int i = ...; i <= ...; i++)
{
    Console.WriteLine();
}
```

---

## 6. While Loop

**Opdracht:**
Laat de computer tellen vanaf 1, zolang het getal kleiner is dan 4.

*Uitleg: De while-loop blijft doorgaan zolang de voorwaarde klopt*.

**Om je op weg te helpen:**
```csharp
int teller = ;

while (...<...)
{
    Console.WriteLine();
    teller = teller +1;
}
```
---

## 7. Array

**Opdracht:**
Maak een array met drie favoriete fruitsoorten en print ze allemaal op het scherm.

**Om je op weg te helpen:**

```csharp
string[] fruit = { "", "", "" };

for (int i = 0; i < fruit.Length; i++)
{
}
```

*Uitleg: Je bewaart meerdere dingen in één array en laat ze allemaal zien*.

---

## 8. List

**Opdracht:**
Maak een lege lijst van namen. Voeg drie namen toe en print ze allemaal.

*Uitleg: Je voegt namen toe aan een lijst en laat ze daarna allemaal zien*.

**Om je op weg te helpen:**

```csharp
List<string> namen = new List<string>();
namen.Add("");

foreach (string naam in ...)
{
    Console.WriteLine(naam);
}
```
---

## 9. Methode

**Opdracht:**
Schrijf een methode die "Ik zit in groep 8!" print. Roep de methode drie keer aan.

**Om je op weg te helpen:**

```csharp
void ...()
{
    Console.WriteLine();
}

...();
...();
...();
```

*Uitleg: Je maakt een eigen taakje dat je steeds opnieuw kunt gebruiken*.

---