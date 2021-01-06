using CircusTrein.Framework;
using CircusTrein.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein.UnitTests
{
    [TestClass]
    public class UnitTests
    {
        Train train = new Train();


        [TestMethod]
        public void AddRandomAnimal()
        {
            train.AnimalsToAdd.Add(AnimalFactory.CreateRandomAnimal());
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GenerateMockData()
        {
            for (int i = 0; i < 10; i++)
            {
                train.AnimalsToAdd.Add(AnimalFactory.CreateRandomAnimal());
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void AddCarnivoreAnimal()
        {
            train.AnimalsToAdd.Add(new Animal(ConsumptionType.CARNIVORE, Sizes.MEDIUM));
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void AddHerbivoreAnimal()
        {
            train.AnimalsToAdd.Add(new Animal(ConsumptionType.HERBIVORE, Sizes.MEDIUM));
            Assert.IsTrue(true);
        }
    }
}
