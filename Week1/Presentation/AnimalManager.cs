using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week1.Business.Services;
using Week1.Data.Interfaces;

namespace Week1.Presentation
{
    public partial class AnimalManager : Form
    {
        public List<IAnimal> animals = new List<IAnimal>();
        public AnimalManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AnimalManager_Load(object sender, EventArgs e)
        {
            AnimalService.Instance.UpdateAnimals();
        }

        private void OpenAnimalDetailBtn_Click(object sender, EventArgs e)
        {
            PresentationManager.Instance.OpenAddModel();
        }

        private void BornBtn_Click(object sender, EventArgs e)
        {
            AnimalService.Instance.UpdateAnimals();
            foreach (var animal in animals)
            {
                AnimalService.Instance.GiveBirth(animal.Type);
            }
            AnimalService.Instance.UpdateAnimals();
        }

        private void ProduceMilkBtn_Click(object sender, EventArgs e)
        {
            AnimalService.Instance.UpdateAnimals();
            foreach (var animal in animals)
            {
                AnimalService.Instance.ProduceMilk(animal.Id, animal.ProduceMilk());
            }
            AnimalService.Instance.UpdateAnimals();
        }

        private void SpeakBtn_Click(object sender, EventArgs e)
        {
            AnimalService.Instance.UpdateAnimals();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Type.ToString()+ " speak: " + animal.Speak());
            }
        }
    }
}
