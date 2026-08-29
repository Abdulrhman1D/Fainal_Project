using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.quiz
{
    public class Dog : Animal
    {
        public string Breed;

        public Dog(string name, int age, string color, string breed)
            : base(name, age, color)
        {
            Breed = breed;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Breed: {Breed}";
        }

        public override string MakeSound()
        {
            return "Dog is barking!";
        }
    }
}