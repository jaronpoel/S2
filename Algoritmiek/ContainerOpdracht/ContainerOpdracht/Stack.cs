using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerOpdracht
{
    public class Stack
    {
        internal List<Container> Containers;

        public Stack()
        {
            Containers = new List<Container>();
        }

        internal bool WeightWithinLimit(Container container)
        {
            return Containers.Skip(1).Sum(container_ => container_.Weight) + container.Weight <= 120000;
        }

        internal bool ContainsImportant()
        {
            return Containers.Any(container => container.Type == ContainerType.important);
        }

        public bool AddContainer(Container container)
        {
            if (ContainsImportant() || !WeightWithinLimit(container))
            {
                return false;
            }
            Containers.Add(container);
            return true;
        }

        public int GetHeight()
        {
            return Containers.Count;
        }

        public int GetWeight()
        {
            return Containers.Sum(container => container.Weight);
        }

        public Container GetUpperContainer()
        {
            return Containers.ElementAt(Containers.Count - 1);
        }

        public void PrintContainers(ListView lvShip, int rowindex, int stackindex)
        {
            foreach (Container container in Containers)
            {
                ListViewItem Containertoevoegen = new ListViewItem();
                Containertoevoegen.Text = "(" + rowindex + "," + stackindex + "," + Containers.IndexOf(container) + ")" + " Weight: " + container.Weight + " Type: " + container.Type;
                lvShip.Items.Add(Containertoevoegen);
            }
        }
    }
}
