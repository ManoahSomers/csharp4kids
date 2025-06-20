# Opdrachten per Concept de uitwerkingen

Hieronder vind je voor elke geavanceerd concept de uitwerking van de opdrachten. 
---

## 10. Classes

**Opdracht:**
Maak een klasse die een naam en leeftijd eigenschap bevat.

**Om je op weg te helpen:**

```csharp
class Persoon 
{
    public string naam;
    public int leeftijd;
}
```
---

## 11. Constructors

**Opdracht:**
Geef de klasse die je zonet hebt gemaakt een constructor die de naam en leeftijd eigenschappen vult.

**Om je op weg te helpen:**
```csharp
class Persoon 
{
    public string naam;
    public int leeftijd;

    public Persoon(naam, leeftijd)
    {
        naam = naam;
        leeftijd = Leeftijd
    }
}
```

---

## 12. Properties

**Opdracht:**
Zet in de klasse die je hebt gemaakt een eigenschap genaamd 'geld' en maak een property de de waarde kan ophalen genaamd 'HoeveelheidGeld'. 
Extra: Zorg ervoor dat de property 'geld' niet minder dan 0 kan zijn.

**Om je op weg te helpen:**
```csharp
class Persoon 
{
    private int geld;

    public int HoeveelheidGeld 
    {
        get 
        {
            return geld;
        }
        set
        {
            if (value < 0)
            {
                geld = 0
            }
            else 
            {
                geld = value;
            }
        }
    }
    public string naam;
    public int leeftijd;

    public Persoon(naam, leeftijd)
    {
        naam = naam;
        leeftijd = Leeftijd
    }
}
```
---

## 13. Interfaces

**Opdracht:**
Maak een interface aan en voeg methoden toe die je klasse moet kunnen. Voeg vervolgens de interface toe aan de klasse en vul de methodes.

**Om je op weg te helpen:**
```csharp
Interface IPersoon 
{
    void Loop();
    void Schreeuw();
}

class Persoon : IPersoon
{        
    public void Loop()
    {
        Console.WriteLine("Aan het lopen!");
    }

    public void Schreeuw()
    {
        Console.WriteLine("Shrek schreeuwt!");
    }
}
```
---