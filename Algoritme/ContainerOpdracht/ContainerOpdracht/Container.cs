using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerOpdracht
{
    public class Container
    {
        public int Weight { get; private set; }

        public ContainerType Type { get; }

        public Container(int weight, ContainerType type)
        {
            UpdateWeight(weight);
            Type = type;
        }

        private void UpdateWeight(int weight)
        {
            if (weight < 4000 || weight > 30000)
            {
                throw new ArgumentException("Weight must be between 4000 and 30000.");
            }
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Container: Type: {Type}, Weight: {Weight}";
        }
    }
}
