using System.Net.Cache;

namespace _00._1_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog puppy = new Dog()
            //{
            //    Name = "Yoko",
            //    Breed = "Border Collie",
            //    Age = 8
            //};

            //puppy.Bark();

            //Dog friend = new Dog();
            //friend.Name = "Archy";
            //friend.Breed = "Koker";
            //friend.Age = 7;

            //friend.Bark();

            Dog dog = new Dog();
            Console.WriteLine(dog.Name);
            Dog dog2 = new Dog();
            {
                dog2.Age = 2;
            }
            Console.WriteLine($"{dog2.Name}, {dog2.Age}");

            Dog newest = new Dog("Yoko", "BK", 2);
            Console.WriteLine($"{newest.Name}, {newest.Breed}, {newest.Age}");
            
        }
    }


}