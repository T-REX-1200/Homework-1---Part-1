using Part_1.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1.Classes
{
    public class Dog : Animal, iDog
    {
        public Dog(string name, int age, string gender, string colour) : base(name, age, gender, colour)
        {
        }

        public override string PrintAnimal()
        {
            return $"{Name},{Age},{Gender},{AnimalColour}";
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} - - -woof woof");
            Console.WriteLine($"{Name} = = =bark bark bark");
        }
    }
}
