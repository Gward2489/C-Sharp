using System;
using Xunit;

namespace Animals.Tests
{
    
    
    public class AnimalsShould
    {
        private Animal _animal;
        private Dog _dog;

        public AnimalsShould(){
            _animal = new Animal();
            _dog = new Dog();
        }

        [Fact]
        public void nameAnimal()
        {
            _animal.nameIt("Sloth");

            Assert.Equal(_animal.Name, "Sloth");

        }

        [Fact]
        public void assignSpecies()
        {
            _animal.setSpecies("Slothus Prime");

            Assert.Equal(_animal.Species, "Slothus Prime");

        }

        [Fact]
        public void walkingSpeed()
        {
            _animal.Walk("2 mph");
            _dog.Walk("5 mph");

            Assert.Equal(_animal.walkingSpeed, "2 mph");
            Assert.Equal(_dog.walkingSpeed, "5 mph");
        }

        [Fact]
        public void instanceCheck()
        {
            Assert.Equal(_animal.GetType(), typeof(Animals.Animal));
            Assert.Equal(_dog.GetType(), typeof(Animals.Dog));
        }
    }
}
