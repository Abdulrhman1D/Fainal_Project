using FirstConsoleBootCamp.day4.OOP.quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    internal class AnimalTest
    {
        static void Mainn()
        {
            IAnimal[] animal = {
                new Fish("Salmon", "Orang", false),
                new Bird("Lovebird", "Yellow", true),
                new Cat("Scottish",2, "Blue", true),
                new Dog("German Shepherd")
            };
            foreach (var anim in animal)
            {
                if (anim is Fish fish)
                {
                    Console.WriteLine(fish.DisplayInfo());
                    Console.WriteLine(fish.MakeSound());
                }
                else if (anim is Bird bird)
                {
                    Console.WriteLine(bird.DisplayInfo());
                    Console.WriteLine(bird.MakeSound());
                }
                else if (anim is Cat cat)
                {
                    Console.WriteLine(cat.DisplayInfo());
                    Console.WriteLine(cat.MakeSound());
                }
                else if (anim is Dog dog) 
                {
                    Console.WriteLine(dog.DisplayInfo());
                    Console.WriteLine(dog.MakeSound());
                }
                Console.WriteLine("======================");
            }
        }
    }
}
