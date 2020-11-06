using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContainerOpdracht
{
    public partial class Form1 : Form
    {

        List<Container> containers = new List<Container>();
        Ship ship;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddContainer_Click(object sender, EventArgs e)
        {
            ContainerType type = ContainerType.standard;
            for (int i = 0; i < Int32.Parse(tbQuantity.Text); i++)
            {
                if (rbNormal.Checked)
                {
                    type = ContainerType.standard;
                }
                else if (rbCooled.Checked)
                {
                    type = ContainerType.cooled;
                }
                else if (rbImportant.Checked)
                {
                    type = ContainerType.important;
                }
                Container addContainer = new Container(Convert.ToInt32(tbWeightContainer.Text), type);
                containers.Add(addContainer);

                lvContainer.View = View.List;
                ListViewItem Containertoevoegen = new ListViewItem();
                Containertoevoegen.Text = " Weight: " + addContainer.Weight + " Type: " + addContainer.Type;
                lvContainer.Items.Add(Containertoevoegen);
            }
        }

        private void btnMakeShip_Click(object sender, EventArgs e)
        {
            ship = new Ship(Convert.ToInt32(tbWidthShip.Text), Convert.ToInt32(tbLengthShip.Text));
            ship.ShipWeight = Convert.ToInt32(tbShipWeight.Text);
            MessageBox.Show("Ship is made");
        }

        private void btnFillShip_Click(object sender, EventArgs e)
        {
            if(containers.Sum(x => x.Weight) < ship.ShipWeight / 2){
                MessageBox.Show("Weight of the containers is smaller than the 50% of the ship weight.");
            }
            else {
                List<Container> ordenedcontainers = containers.OrderBy(c => c.Type).ToList(); 
                foreach (Container container in ordenedcontainers)
                {
                    if (!ship.AddContainer(container))
                    {
                        string message = " Weight: " + container.Weight + " Type: " + container.Type;
                        MessageBox.Show("Can't fill container:" + message);
                    }
                }

                //Hier afdrukken.
                lvShip.View = View.List;
                ship.PrintRows(lvShip);
            }
        }
    }
}
