using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.quiz
{
    internal class AnimalTest
    {
        static void Mainn()
        {
            List<Animal> animals = new List<Animal>
            {
                //new Animal("Animal1", 5, "Brown"),
                new Dog("Max", 3, "Black", "German Shepherd  "),
                new Cat("Luna", 2, "White", true)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.DisplayInfo());

                if (animal is Dog dog)
                {
                    dog.MakeSound();
                }
                else if (animal is Cat cat)
                {
                    cat.MakeSound();
                }
                else
                {
                    animal.MakeSound();
                }

                Console.WriteLine("==============================");
            }

            Console.ReadKey();
        }
    }
}