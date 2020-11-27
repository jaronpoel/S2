using CircusTrein.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic
{
    public class Animal
    {
        public ConsumptionType ConsumptionType { get; }
        public Sizes Size { get; }

        public Animal(ConsumptionType consumptionType, Sizes size)
        {
            ConsumptionType = consumptionType;
            Size = size;
        }

        public String getString()
        {
            return "ConsumptionType: " + ConsumptionType.ToString().ToLower() + ", Size: " + Size.ToString().ToLower();
        }

        public bool EatsOtherAnimal()
        {
            return ConsumptionType != ConsumptionType.HERBIVORE;
        }
    }
}
