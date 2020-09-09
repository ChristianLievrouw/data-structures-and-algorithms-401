using System;
using Challenges.QueueWithStacks;
using DataStructures.Stack;
using Xunit;
using static Challenges.AnimalShelter<object>;

namespace Challenges.tests
{
    public class ShelterTests
    {
        [Fact]
        public void Shelter_is_empty()
        {
            // Arrange 
            AnimalShelter<object> shelter = new AnimalShelter<object>();

            // Act
            bool result = shelter.QIsEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Shelter_Not_empty()
        {
            // Arrange 
            AnimalShelter<object> shelter = new AnimalShelter<object>();
         
            shelter.Enqueue(Animal.Type.Dog);
            shelter.Enqueue(Animal.Type.Dog);
            shelter.Enqueue(Animal.Type.Cat);

            Assert.Equal(Animal.Type.Dog, shelter.Peek());
        }

        [Fact]
        public void Shelter_return_null_if_not_DogOrCat_empty()
        {
            // Arrange 
            AnimalShelter<object> shelter = new AnimalShelter<object>();

            shelter.Enqueue(Animal.Type.Dog);

            var result = shelter.Dequeue(Animal.Type.Bird);

            Assert.Equal(Animal.Type.Dog, result);
        }

    }
}