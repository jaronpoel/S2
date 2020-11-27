using CircusTrein.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic
{
    public class Train
    {
        public List<Animal> AnimalsToAdd = new List<Animal>();
        private List<Wagon> wagons = new List<Wagon>();

        public void StartSorting()
        {
            List<Animal> animals = SortAnimalsList(AnimalsToAdd);
            foreach (Animal animal in animals)
            {
                if (!FindSuitingWagon(animal))
                {
                    AddAnimalToNewWagon(animal);
                }
            }
        }

        public List<Animal> SortAnimalsList(List<Animal> animals)
        {
            return animals.Where(animal => animal.EatsOtherAnimal()).ToList()
                     .Concat(animals.Where(animal => !animal.EatsOtherAnimal()).ToList())
                     .ToList();
        }

        public bool FindSuitingWagon(Animal animal)
        {
            foreach (Wagon wagon in wagons)
            {
                if (wagon.CheckCapacity(animal))
                {
                    if (TryToPlaceAnimal(animal, wagon))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool TryToPlaceAnimal(Animal animal, Wagon wagon)
        {
            if (!wagon.ContainsCarnivore())
            {
                // Because of SortAnimalsList() I assume it can't be a Carnivore that gets added with Herbivores. 
                AddAnimalToWagon(wagon, animal);
                return true;
            }
            else
            {
                if (TryToPlaceAnimalWithCarnivores(animal, wagon))
                {
                    return true;
                }
            }
            return false;
        }

        private bool TryToPlaceAnimalWithCarnivores(Animal animal, Wagon wagon)
        {
            if (wagon.IsBigger(animal))
            {
                AddAnimalToWagon(wagon, animal);
                return true;
            }

            return false;
        }

        public void AddAnimalToWagon(Wagon wagon, Animal animal)
        {
            wagon.AddAnimalToWagon(animal);
            AnimalsToAdd.Remove(animal);
        }

        public void AddAnimalToNewWagon(Animal animal)
        {
            Wagon newWagon = new Wagon();
            newWagon.AddAnimalToWagon(animal);
            wagons.Add(newWagon);
            AnimalsToAdd.Remove(animal);
        }

        public IEnumerable<Wagon> GetWagons()
        {
            return wagons;
        }
    }
}
