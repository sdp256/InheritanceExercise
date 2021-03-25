using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool HasFeathers { get; set; }
        public bool IsWarmBlooded { get; set; }

        public Bird(string foodType, string reproductionType, int legs, int age, int wings, string type, bool hasFeathers, bool isWarmBlooded)
        {
            FoodType = foodType;
            ReproductionType = reproductionType;
            Legs = legs;
            Age = age;
            Wings = wings;
            Type = type;
            HasFeathers = hasFeathers;
            IsWarmBlooded = isWarmBlooded;
        }


    }
}
