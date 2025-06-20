# Opdrachten per Concept

Hieronder vind je voor elke geavanceerd concept een eenvoudige opdracht waarmee je zelf kunt oefenen. 
Bij elke opdracht staat de uitwerking in "Opdrachten deel 2 uitwerkingen". (Je mag spieken 😉).
---

## 10. Classes

**Opdracht:**
Maak een klasse die een naam en leeftijd eigenschap bevat.

**Om je op weg te helpen:**

```csharp
class ... 
{
    public ... ;
    public ... ;
}
```
---

## 11. Constructors

**Opdracht:**
Geef de klasse die je zonet hebt gemaakt een constructor die de naam en leeftijd eigenschappen vult.

**Om je op weg te helpen:**
```csharp
class ... 
{
    ...;
    ...;

    pulic ...(...., ....)
    {
        ... = ....;
        ... = ....;
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
class ... 
{
    private ... ;
    //Of de extra variant:
    public ... 
    {
        get 
        {
            return ...;
        }
        set
        {
            if (value < 0)
            {

            }
            else 
            {
                ... = value;
            }
        }
    }
    ...;
    ...;

    pulic ...(...., ....)
    {
        ... = ....;
        ... = ....;
    }
}
```
---

## 13. Interfaces

**Opdracht:**
Maak een interface aan en voeg methoden toe die je klasse moet kunnen. Voeg vervolgens de interface toe aan de klasse en vul de methodes.

**Om je op weg te helpen:**
```csharp
Interface ... 
{
    void ...();
    void ...();
}

class ... : I...
{
    ...;
    ...;

    pulic ...(...., ....)
    {
        ... = ....;
        ... = ....;
    }

    public ...()
    {
        .....;
    }

    public ...()
    {
        .....;
    }
}
```
---