using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Bird properties
            Bird bird1 = new Bird()
            {
                Species = "Parrot",
                Age = 3,
                IsAlive = true,
                Sound = "Squawk",
                BirdColor = "blue",
                CanFly = true,
                BeakType = "Hooked",
                WingType = "Hovering Wings"
            };

            Console.WriteLine("Bird Information:");
            Console.WriteLine();
            bird1.Display();
           
            Console.WriteLine();

            //Creating a Reptile properties
            Reptile reptile1 = new Reptile()
            {
                Species = "Snake",
                Age = 4,
                IsAlive = true,
                Sound = "Hiss",
                SkinType = "Rough",
                ColdBlooded = true,
                LayEggs = true,
                RegenerateTail = true,
            };

            Console.WriteLine("Reptile Information");
            Console.WriteLine();
            reptile1.Display();
            Console.WriteLine();








        }

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

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Reptile class
         *  
         * Creatively display the class member values 
         */
        
    }
}
