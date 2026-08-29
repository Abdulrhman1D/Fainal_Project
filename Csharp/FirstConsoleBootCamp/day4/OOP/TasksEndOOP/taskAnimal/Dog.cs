using FirstConsoleBootCamp.day4.OOP.quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    public class Dog : IAnimal
    {
        public string Breed;

        public Dog(string breed)
        {
            Breed = breed;
        }

        public string DisplayInfo()
        {
            return $"Breed: {Breed}";
        }

        public string MakeSound()
        {
            return "Dog is barking!";
        }
    }
}
