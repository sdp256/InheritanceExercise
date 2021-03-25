using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird("worms", "eggs", 2, 600, 2, "Ancient Hawk", true, true);

            Console.WriteLine($"Apparently bird1 is an {bird1.Type}. It likes to eat {bird1.FoodType}.");
            Console.WriteLine($"To reproduce, it lays {bird1.ReproductionType}, and it has {bird1.Wings} wings.");
            Console.WriteLine($"It is {bird1.HasFeathers} that this {bird1.Type} has feathers, and it is {bird1.IsWarmBlooded} that it is warm blooded.");
            Console.WriteLine($"bird1 is also {bird1.Age} years old somehow.");
            Console.WriteLine("");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("");
            var reptile1 = new Reptile("bugs", "eggs", 4, 1, true, true, true, "Gecko");
            Console.WriteLine($"The {reptile1.FoodType} destroyer reptile1 lays {reptile1.ReproductionType}.");
            Console.WriteLine($"The rumors about it having scales are {reptile1.HasScales}. It is also {reptile1.IsColdBlooded} that it is cold-blooded.");
            Console.WriteLine($"There is another rumor that reptile1 likes to bathe in the sun. This is also {reptile1.SunBathes}.");
            Console.WriteLine($"reptile1 is a {reptile1.Type} with {reptile1.Legs} legs, and it is {reptile1.Age} year old.");
        }
    }
}
