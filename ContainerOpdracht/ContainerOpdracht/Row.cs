using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerOpdracht
{
    public class Row
    {
        internal List<Stack> Stacks;

        public Row(int length)
        {
            Stacks = new List<Stack>();
            
            for(int i = 0; i < length; i++)
            {
                Stack s = new Stack();
                Stacks.Add(s);
            }
        }

        public bool AddContainer(Container container)
        {
            if(container.Type == ContainerType.cooled)
            {
                return Stacks.First().AddContainer(container);
            }
            else
            {
                int Stackindex; 

                foreach (Stack stack in Stacks)
                {
                    Stackindex = Stacks.IndexOf(stack);
                    if (container.Type == ContainerType.important)
                    {
                        if (Stackindex > 0 && Stackindex < Stacks.Count -1)//Midden
                        {
                            if (stack.GetHeight() < Stacks.ElementAt(Stackindex - 1).GetHeight() && 
                                stack.GetHeight() < Stacks.ElementAt(Stackindex + 1).GetHeight())
                            {
                                continue;//continue hierin laten. Geef bool terug.
                            }
                        }

                        if (Stackindex >= 2)// Ervoor kijken
                        {
                            Stack previous = Stacks.ElementAt(Stackindex - 1);
                            if (previous.GetHeight() - stack.GetHeight() == 1 &&
                                previous.GetUpperContainer().Type == ContainerType.important)
                            {
                                if (Stacks.ElementAt(Stackindex - 2).GetHeight() >= previous.GetHeight())
                                {
                                    continue;//continue hierin laten. Geef bool terug.
                                }
                            }
                        }

                        if(Stackindex <= Stacks.Count - 3)// Erna kijken
                        {
                            Stack next = Stacks.ElementAt(Stackindex + 1);
                            if (next.GetHeight() - stack.GetHeight() == 1 &&
                                next.GetUpperContainer().Type == ContainerType.important)
                            {
                                if (Stacks.ElementAt(Stackindex + 2).GetHeight() >= next.GetHeight())
                                {
                                    continue;//continue hierin laten. Geef bool terug.
                                }
                            }
                        }
                    }

                    if (stack.AddContainer(container))
                    {
                            return true;      
                    }
                }
            }
            return false;
        }

        public int GetWeight()
        {
            return Stacks.Sum(stacks => stacks.GetWeight());
        }

        public void PrintStacks(ListView lvShip, int rowindex)
        {
            foreach (Stack stack in Stacks)
            {
                stack.PrintContainers(lvShip, rowindex, Stacks.IndexOf(stack));
            }
        }
    }
}
