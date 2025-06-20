# Opdrachten per Concept de uitwerkingen

Hieronder vind je voor elke opdracht een voorbeeld uitwerking! 

---

## 1. Variabelen en Datatypes

**Opdracht:**
Maak een programma waarin je je eigen naam, leeftijd en favoriete dier opslaat en deze netjes op het scherm laat zien.

**Uitwerking:**

```csharp
string naam = "Sophie";
int leeftijd = 11;
string dier = "olifant";

Console.WriteLine("Hallo, ik ben " + naam + " en ik ben " + leeftijd + " jaar oud.");
Console.WriteLine("Mijn lievelingsdier is de " + dier + "!");
```

*Uitleg: Je gebruikt drie variabelen van verschillende soorten en laat ze zien met `Console.WriteLine`*.

---

## 2. Operatoren

**Opdracht:**
Laat de computer twee getallen optellen, aftrekken, vermenigvuldigen en delen. Laat alle uitkomsten zien.

**Uitwerking:**

```csharp
int a = 8;
int b = 3;

Console.WriteLine("Optellen: " + (a + b));
Console.WriteLine("Aftrekken: " + (a - b));
Console.WriteLine("Vermenigvuldigen: " + (a * b));
Console.WriteLine("Delen: " + (a / b));
```

*Uitleg: Je ziet hoe je met operatoren rekent in C\#*.

---

## 3. If-Else Statement

**Opdracht:**
Zet in een variabele een leeftijd. Als de leeftijd kleiner is dan 12, zeg dan "Je bent een kind". Anders zeg je "Je bent een tiener of volwassene".

**Uitwerking:**

```csharp
int leeftijd = 12;

if (leeftijd < 12)
{
    Console.WriteLine("Je bent een kind.");
}
else
{
    Console.WriteLine("Je bent een tiener of volwassene.");
}
```

*Uitleg: De computer kiest wat hij moet doen op basis van de leeftijd*.

---

## 4. Switch Statement

**Opdracht:**
Laat de gebruiker een cijfer van 1 tot 3 invoeren. Print bij 1 "Rood", bij 2 "Blauw" en bij 3 "Groen". Bij iets anders: "Onbekende kleur".

**Uitwerking:**

```csharp
Console.Write("Kies een getal (1-3): ");
int keuze = Convert.ToInt32(Console.ReadLine());

switch (keuze)
{
    case 1:
        Console.WriteLine("Rood");
        break;
    case 2:
        Console.WriteLine("Blauw");
        break;
    case 3:
        Console.WriteLine("Groen");
        break;
    default:
        Console.WriteLine("Onbekende kleur");
        break;
}
```

*Uitleg: Je ziet hoe de switch verschillende keuzes makkelijk maakt*.

---

## 5. For Loop

**Opdracht:**
Laat de computer de getallen 1 t/m 5 onder elkaar printen.

**Uitwerking:**

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

*Uitleg: De for-loop herhaalt de opdracht vijf keer*.

---

## 6. While Loop

**Opdracht:**
Laat de computer tellen vanaf 1, zolang het getal kleiner is dan 4.

**Uitwerking:**

```csharp
int teller = 1;
while (teller < 4)
{
    Console.WriteLine(teller);
    teller++;
}
```

*Uitleg: De while-loop blijft doorgaan zolang de voorwaarde klopt*.

---

## 7. Array

**Opdracht:**
Maak een array met drie favoriete fruitsoorten en print ze allemaal op het scherm.

**Uitwerking:**

```csharp
string[] fruit = { "appel", "banaan", "aardbei" };

for (int i = 0; i < fruit.Length; i++)
{
    Console.WriteLine(fruit[i]);
}
```

*Uitleg: Je bewaart meerdere dingen in één array en laat ze allemaal zien*.

---

## 8. List

**Opdracht:**
Maak een lege lijst van namen. Voeg drie namen toe en print ze allemaal.

**Uitwerking:**

```csharp
List<string> namen = new List<string>();
namen.Add("Emma");
namen.Add("Noah");
namen.Add("Liam");

foreach (string naam in namen)
{
    Console.WriteLine(naam);
}
```

*Uitleg: Je kunt makkelijk dingen toevoegen aan een lijst en ze daarna allemaal laten zien*.

---

## 9. Methode

**Opdracht:**
Schrijf een methode die "Ik zit in groep 8!" print. Roep de methode drie keer aan.

**Uitwerking:**

```csharp
void Begroet()
{
    Console.WriteLine("Ik zit in groep 8!");
}

Begroet();
Begroet();
Begroet();
```

*Uitleg: Je maakt een eigen taakje dat je steeds opnieuw kunt gebruiken*.

---