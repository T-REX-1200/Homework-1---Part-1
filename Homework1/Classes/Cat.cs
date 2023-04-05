using Part_1.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1.Classes
{
    public class Cat : Animal, iCat
    {
        public Cat(string name, int age, string gender, string colour) : base(name, age, gender, colour)
        {
        }

        public override string PrintAnimal()
        {
            return $"{Name},{Age},{Gender},{AnimalColour}";
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The cat is eating {food}");
        }
    }
}
