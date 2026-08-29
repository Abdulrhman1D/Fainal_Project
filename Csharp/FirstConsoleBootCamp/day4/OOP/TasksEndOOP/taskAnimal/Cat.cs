using FirstConsoleBootCamp.day4.OOP.quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleBootCamp.day4.OOP.TasksEndOOP.taskAnimal
{
    public class Cat : Animal, IAnimal
    {
        public bool IsIndoor;

        public Cat(string name, int age, string color, bool isIndoor)
            :base(name,age,color)
        {
            IsIndoor = isIndoor;
        }

        public override string DisplayInfo()
        {

            return $"{base.DisplayInfo()}, Is Indoor:{IsIndoor}";
        }

        public override string MakeSound()
        {
            return "Cat is meowing!";
        }
    }
}
