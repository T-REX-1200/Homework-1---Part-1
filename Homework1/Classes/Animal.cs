using Part_1.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1.Classes
{
    public abstract class Animal : iAnimal
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } =string.Empty;
        public string AnimalColour { get; set; } = string.Empty;

        public abstract string PrintAnimal();

        public Animal (string name,int age,string gender,string colour)
        {
            Name = name;
            Age = age;
            Gender = gender;
            AnimalColour = colour;
        }
       
    }
}
