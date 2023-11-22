using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._1_Demo
{
    public class Dog
    {
        public Dog()
        {
            Name = "Default";
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark!");
        }
    }
}
