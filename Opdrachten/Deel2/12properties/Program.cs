// Opdracht: Zet in de klasse die je hebt gemaakt een eigenschap genaamd 'geld' en maak een property de de waarde kan ophalen genaamd 'HoeveelheidGeld'. 
// Extra: Zorg ervoor dat de property 'geld' niet minder dan 0 kan zijn.
// Om je op weg te helpen:

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

    public ...(...., ....)
    {
        ... = ....;
        ... = ....;
    }
}