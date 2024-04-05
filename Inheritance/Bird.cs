using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; }

        public string BirdColor { get; set; }

        public string WingType { get; set; }

        public string BeakType { get; set; }


        public void Display()
        {
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Age: {Age}" );
            Console.WriteLine($"Is Alive: {IsAlive}");
            Console.WriteLine($"Sound: {Sound}");
            Console.WriteLine($"Bird Color: {BirdColor}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Beak Type: {BeakType}");
            Console.WriteLine($"Wing type: {WingType}");
        }
    }
}
