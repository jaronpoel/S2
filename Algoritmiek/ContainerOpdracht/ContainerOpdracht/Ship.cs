using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContainerOpdracht
{
    public class Ship
    {
        internal List<Row> Rows { get; }

        public int ShipWeight { get; set; }

        public Ship(int width, int length)
        {
            Rows = new List<Row>();

            for (int i = 0; i < width; i++)
            {
                Row r = new Row(length);
                Rows.Add(r);
            }
        }

        public int GetWeight()
        {
            return Rows.Sum(row => row.GetWeight());
        }

        public List<Row> GetLeftRows()
        {
            return Rows.GetRange(0, Rows.Count / 2);
        }

        public int GetWeightLeftRows()
        {
            List<Row> Leftrows = GetLeftRows();
            return Leftrows.Sum(row => row.GetWeight());
        }

        public List<Row> GetRightRows()
        {
            return Rows.GetRange(Rows.Count % 2 == 0 ? Rows.Count / 2 : Rows.Count / 2 + 1, Rows.Count / 2);
        }

        public int GetWeightRightRows()
        {
            List<Row> Rightrows = GetRightRows();
            return Rightrows.Sum(row => row.GetWeight());
        }

        public bool AddContainer(Container container)
        {
            foreach (Row row in Rows)
            {
                //Zit ik links of zit ik rechts?
                int Rowindex = Rows.IndexOf(row);
                bool Left = false;

                if (Rows.Count % 2 == 1)
                {
                    int MiddleIndex = Rows.Count / 2;
                    if(Rowindex > MiddleIndex)
                    {
                        //Zit je aan de linkerkant van het ship.
                        Left = true;

                    }else if (Rowindex < MiddleIndex)
                    {
                        //Zit je aan de rechterkant.
                        Left = false;
                    }
                }
                else
                {
                    int MiddleIndex = Rows.Count / 2;
                    if (Rowindex >= MiddleIndex)
                    {
                        //Zit je aan de linkerkant van het ship.
                        Left = true;

                    }
                    else if (Rowindex < MiddleIndex)
                    {
                        //Zit je aan de rechterkant.
                        Left = false;
                    }
                }
                if(Left)
                {
                    int WeightLeftside = GetWeightLeftRows();
                    int WeightRightside = GetWeightRightRows();
                    WeightLeftside += container.Weight;
                    if(WeightLeftside - WeightRightside > 0)
                    {
                        if (WeightLeftside - WeightRightside > 0.2 * GetWeight())
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    int WeightLeftside = GetWeightLeftRows();
                    int WeightRightside = GetWeightRightRows();
                    WeightRightside += container.Weight;
                    if (WeightRightside - WeightLeftside > 0)
                    {
                        if (WeightRightside - WeightLeftside > 0.2 * GetWeight())
                        {
                            continue;
                        }
                    }
                }
                if (row.AddContainer(container))
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintRows(ListView lvShip)
        {
            foreach(Row row in Rows)
            {
                row.PrintStacks(lvShip, Rows.IndexOf(row));
            }
        }
    }
}
