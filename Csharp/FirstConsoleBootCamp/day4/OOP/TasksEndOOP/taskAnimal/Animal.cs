using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    public abstract class Animal : IAnimal
    {
        public string Name;
        public int Age;
        public string Color;

        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public virtual string DisplayInfo()
        {
            return $"Name:{Name}, Age: {Age}, Color: {Color}";
        }

        public abstract string MakeSound();

    }
}
