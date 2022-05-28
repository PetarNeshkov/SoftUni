namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    
    public class AquariumsTests
    {
        private Fish fish;
        private Aquarium aquarium;
        [SetUp]
        public void Start()
        {
            fish = new Fish("Ivan");
            aquarium = new Aquarium("T", 3);
        }

        [Test]
        public void nameCannotBeEmpty()
        {
            Assert.Throws<ArgumentNullException>(()=>aquarium=new Aquarium(null,3));
            Assert.Throws<ArgumentNullException>(() => aquarium = new Aquarium("", 3));
        }

        [Test]
        public void CapacityLessThan0Exp()
        {
            Assert.Throws<ArgumentException>(() => aquarium = new Aquarium("Ivan", -1));
        }

        [Test]
        public void AddFishShouldThrowExp()
        {
            aquarium = new Aquarium("T", 1);
            aquarium.Add(fish);
            Assert.Throws<InvalidOperationException>( ()=>aquarium.Add(fish));
        }

        [Test]
        public void AddFishWorks()
        {
            aquarium.Add(fish);

            Assert.AreEqual(1, aquarium.Count);

            //?
        }

        [Test]
        public void RemoveFishExp()
        {
            Assert.Throws<InvalidOperationException>(() =>aquarium.RemoveFish("Ivan"));
        }

        [Test]
        public void RemoveFish()
        {
            aquarium.Add(fish);

            aquarium.RemoveFish("Ivan");

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void SellFishExp()
        {
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("Ivan"));
        }

        [Test]
        public void SellFish()
        {
            aquarium.Add(fish);

            var expectedFish = aquarium.SellFish("Ivan");

            Assert.AreEqual(fish, expectedFish);

            Assert.AreEqual(false, expectedFish.Available);
        }

        [Test]
        public void Report()
        {
            aquarium.Add(fish);

            Fish fish2 = new Fish("Gosho");

            aquarium.Add(fish2);

            var expectedResult = $"Fish available at {aquarium.Name}: {fish.Name}";

            var actual = aquarium.Report();

            Assert.AreEqual(expectedResult, actual);
        }
    }
}
