using CircusTrein.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic
{
    public class Wagon
    {
        private List<Animal> FilledAnimals = new List<Animal>();
        public readonly String ID;
        public readonly int Capacity;

        public Wagon(int capacity = 10)
        {
            ID = Guid.NewGuid().ToString();
            Capacity = capacity;
        }

        public override string ToString()
        {
            return ID;
        }

        public IEnumerable<Animal> GetFilledAnimals()
        {
            return FilledAnimals;
        }

        public void AddAnimalToWagon(Animal animal)
        {
            FilledAnimals.Add(animal);
        }

        /// <summary>
        /// Checks if the suposed new animal is bigger than any of the current ones in the wagon.
        /// </summary>
        public bool IsBigger(Animal newAnimal)
        {
            foreach (Animal animal in FilledAnimals)
            {
                if (animal.Size >= newAnimal.Size)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Here the size of the animal is checked if it would exceed the wagons max capacity if added.
        /// </summary>
        public bool CheckCapacity(Animal animal)
        {
            return GetFilledCapacity() + (int)animal.Size <= 10;
        }

        /// <summary>
        /// Gets the current filled capacity
        /// </summary>
        public int GetFilledCapacity()
        {
            return FilledAnimals.Sum(animal => (int)animal.Size);
        }

        public bool ContainsCarnivore()
        {
            if (FilledAnimals.Any(animal => animal.ConsumptionType is ConsumptionType.CARNIVORE))
            {
                return true;
            }
            return false;
        }
    }
}
