using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Data.Interfaces
{
    public enum AnimalType
    {
        Cow,
        Sheep,
        Goat
    }
    public interface IAnimal
    {
        string Id { get; set; }
        AnimalType Type { get; set; }

        string Speak();
        double ProduceMilk();

    }
}
