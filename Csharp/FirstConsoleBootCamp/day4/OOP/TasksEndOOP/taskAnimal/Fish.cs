using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    public class Fish : IAnimal
    {
        public string Name;
        public string Color;
        public bool IsFreshWater;

        public Fish(string name, string color, bool isFreshWater)
        {
            Name = name;  
            Color = color;
            IsFreshWater = isFreshWater;
        }
        public string DisplayInfo()
        {
            return $"Name:{Name}, Color:{Color}, Is Fresh Water:{IsFreshWater}.";
        }
        public string MakeSound()
        {
            return $"Fish is bubbling!";
        }
        
    }
}
