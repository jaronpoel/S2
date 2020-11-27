using CircusTrein.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein.Logic
{
    public class AnimalFactory
    {

        public static Animal Create(ConsumptionType consumptionType, Sizes size)
        {
            return new Animal(consumptionType, size);
        }

        public static Animal CreateRandomAnimal()
        {
            return new Animal (GetRandomConsumptionType(), GetRandomSize());
        }

        private static Sizes GetRandomSize()
        {
            switch (new Random(Guid.NewGuid().GetHashCode()).Next(1, 4))
            {
                case 1:
                    return Sizes.BIG;
                case 2:
                    return Sizes.MEDIUM;
                case 3:
                    return Sizes.SMALL;
                default:
                    return Sizes.MEDIUM;
            }
        }

        private static ConsumptionType GetRandomConsumptionType()
        {
            switch (new Random(Guid.NewGuid().GetHashCode()).Next(1, 3))
            {
                case 1:
                    return ConsumptionType.CARNIVORE;
                case 2:
                    return ConsumptionType.HERBIVORE;
                default:
                    return ConsumptionType.HERBIVORE;
            }
        }
    }
}
