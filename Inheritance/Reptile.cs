using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool SunBathes { get; set; }
        public string Type { get; set; }

        public Reptile(string foodType, string reproductionType, int legs, int age, bool hasScales, bool isColdBlooded, bool sunBathes, string type)
        {
            FoodType = foodType;
            ReproductionType = reproductionType;
            Legs = legs;
            Age = age;
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            SunBathes = sunBathes;
            Type = type;
        }

    }
}
