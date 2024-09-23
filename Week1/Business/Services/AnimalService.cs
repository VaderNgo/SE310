using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Data.Interfaces;
using Week1.Data.Objects;
using Week1.Data.Repositories;
using Week1.Presentation;

namespace Week1.Business.Services
{
    public class AnimalService
    {
        private static AnimalService _instance = null;

        public static AnimalService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimalService();
                }
                return _instance;
            }
        }

        public void GiveBirth(AnimalType type)
        {
            int times = 0;
            Random random = new Random();  

            switch (type)
            {
                case AnimalType.Cow:
                    times = random.Next(1, 3);
                    break;
                case AnimalType.Goat:
                    times = random.Next(1, 5);
                    break;
                case AnimalType.Sheep:
                    times = random.Next(1, 3); 
                    break;
            }
            AnimalRepository.Instance.AddAnimals(times, type);
        }

        public void ProduceMilk(string id, double milkProduced)
        {
            AnimalRepository.Instance.UpdateMilk(id, milkProduced);
        }

        public void AddAnimals(int quantity, AnimalType type)
        {
            AnimalRepository.Instance.AddAnimals(quantity, type);
        }

        public void UpdateAnimals()
        {
            AnimalRepository.Instance.GetAllAnimals();
            PresentationManager.Instance._animalManager.animals.Clear();
            foreach (DataRow row in AnimalRepository.Instance._dataTable.Rows)
            {
                IAnimal animal = MapDataRowToAnimal(row);
                PresentationManager.Instance._animalManager.animals.Add(animal);
            }
            var newDataSource = AnimalRepository.Instance._dataTable;
            PresentationManager.Instance._animalManager.AnimalDataGridView.DataSource = newDataSource;
        }

        private IAnimal MapDataRowToAnimal(DataRow row)
        {
            var typeString = (string)row["type"];
            switch ((AnimalType)Enum.Parse(typeof(AnimalType), typeString))
            {
                case AnimalType.Cow:
                    return new Cow() { Id = (string)row["id"] };
                case AnimalType.Goat:
                    return new Goat() { Id = (string)row["id"] };
                default:
                    return new Sheep() { Id = (string)row["id"] };
            }
        }

        ~AnimalService() { }
    }
}
