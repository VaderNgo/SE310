using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Data.Interfaces;

namespace Week1.Data.Objects
{
    public class Sheep: IAnimal
    {
        public string Id { get; set; }
        public AnimalType Type { get; set; }

        public string Speak()
        {
            return "Baa";
        }
        public double ProduceMilk()
        {
            Random rd = new Random();
            return rd.NextDouble() * 5;
        }

        public Sheep()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Type = AnimalType.Sheep;
        }
    }
}
