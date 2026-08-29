using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    public class Bird : IAnimal
    {
        public string Name;
        public string Color;
        public bool CanFly;
        public Bird(string name, string color, bool canFly)
        {
            Name = name;
            Color = color;
            CanFly = canFly;  
        }

        public string DisplayInfo()
        {
            return $"Name:{Name}, Color:{Color}, Can Fly:{CanFly}.";
        }
        public string MakeSound()
        {
            return $"Bird is chirping!";
        }
    }
}
