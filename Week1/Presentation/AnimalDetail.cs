using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week1.Business.Services;
using Week1.Data.Interfaces;
using Week1.Data.Repositories;

namespace Week1.Presentation
{
    public partial class AnimalDetail : Form
    {
        public AnimalDetail()
        {
            InitializeComponent();
        }

        private string imgPath = "..\\..\\..\\Assets\\Images\\";
        private AnimalType[] items = [AnimalType.Cow, AnimalType.Goat, AnimalType.Sheep];

        private void AnimalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnimalPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AnimalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelAnimalDetail_Click(object sender, EventArgs e)
        {
            PresentationManager.Instance.CloseAddModel();
        }

        private void AddAnimalDetail_Click(object sender, EventArgs e)
        {
            if (AnimalsComboBox.SelectedItem != null)
            {
                AnimalType selectedAnimal = (AnimalType)AnimalsComboBox.SelectedItem;
                int quantity = int.Parse(AnimalTextBox.Text);
                AnimalService.Instance.AddAnimals(quantity, selectedAnimal);
            }
            else
            {
                MessageBox.Show("Please Choose Animal Type");
            }

        }

        private void AnimalDetail_Load(object sender, EventArgs e)
        {
            this.AnimalTextBox.Text = "0";
            this.AnimalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.AnimalsComboBox.Items.Clear();
            this.AnimalsComboBox.DataSource = items;
            this.AnimalsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AnimalsComboBox.SelectedIndex = 0;
            UpdateAnimalImage();

        }


        private void AnimalListBox_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void UpdateAnimalImage()
        {
            if (AnimalsComboBox.SelectedItem != null)
            {
                AnimalType selectedAnimal = (AnimalType)AnimalsComboBox.SelectedItem;
                string imageName = selectedAnimal.ToString().ToLower() + ".png";
                AnimalPictureBox.Image = Image.FromFile(imgPath + imageName);
            }
        }

        private void AnimalListBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void AnimalsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnimalImage();
        }

        private void AnimalDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel= true;
            PresentationManager.Instance.CloseAddModel();
        }
    }
}
