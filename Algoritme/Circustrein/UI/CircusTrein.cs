using CircusTrein.Framework;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircusTrein.Logic;

namespace CircusTrein
{
    public partial class CircusTrein : Form
    {
        Train train = new Train();

        public CircusTrein()
        {
            InitializeComponent();
        }

        private void CircusTrein_Load(object sender, EventArgs e)
        {
            foreach (string size in Enum.GetNames(typeof(Sizes)))
            {
                SizeBox.Items.Add(size.ToLower());
            }

            foreach (string consumptionType in Enum.GetNames(typeof(ConsumptionType)))
            {
                ConsumptionTypeBox.Items.Add(consumptionType.ToLower());
            }
        }

        private void generateMockDataButton_Click(object sender, EventArgs e)
        {
            createdAnimalsBox.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                train.AnimalsToAdd.Add(AnimalFactory.CreateRandomAnimal());
            }
            foreach (Animal animal in train.AnimalsToAdd)
            {
                createdAnimalsBox.Items.Add(animal.getString());
            }
        }

        private void RunAlgoritmButton_Click(object sender, EventArgs e)
        {
            createdAnimalsBox.Items.Clear();
            filledAnimalsBox.Items.Clear();
            train.StartSorting();
            foreach (Animal animal in train.AnimalsToAdd)
            {
                createdAnimalsBox.Items.Add(animal.getString());
            }
            foreach (Wagon wagon in train.GetWagons())
            {
                filledAnimalsBox.Items.Add(wagon.ToString());
            }
        }

        private void CreateAnimalButton_Click(object sender, EventArgs e)
        {
          if (string.IsNullOrEmpty(ConsumptionTypeBox.Text) || string.IsNullOrEmpty(SizeBox.Text))
            {
                MessageBox.Show("Je hebt nog geen gegevens ingevuld!", "Mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Animal animal = AnimalFactory.Create( 
                (ConsumptionType)Enum.Parse(typeof(ConsumptionType), ConsumptionTypeBox.SelectedItem.ToString().ToUpper()), 
                (Sizes)Enum.Parse(typeof(Sizes), SizeBox.SelectedItem.ToString().ToUpper()));
            train.AnimalsToAdd.Add(animal);
            createdAnimalsBox.Items.Add(animal.getString());
            MessageBox.Show("Dier toegevoegd met de volgende attributen: " + animal.getString(), "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void filledAnimalsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Wagon foundWagon = train.GetWagons().Single(wagon => wagon.ToString() == filledAnimalsBox.Text);
            string message = "";
            foreach (Animal animal in foundWagon.GetFilledAnimals())
                message += animal.getString() + "\n";

            MessageBox.Show("Animals: " + message, "Wagon: " + foundWagon.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AnimalTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnimalTypeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
