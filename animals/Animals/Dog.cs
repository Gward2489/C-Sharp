namespace Animals
{
    public class Dog
    {
        public string Name {get; set;}
        public string walkingSpeed {get; set;}

        public void Walk(string mph)
        {
            walkingSpeed = mph;
        }
    }   
}