namespace Animals
{
    public class Animal
    {
        public string Name {get; set;}

        public string Species {get; set;}
        public string walkingSpeed {get; set;}


        public void nameIt(string animalName)
        {
            Name = animalName;
        }

        public void setSpecies(string species)
        {
            Species = species;
        }

        public void Walk(string mph)
        {
            walkingSpeed = mph;
        }
    }
}