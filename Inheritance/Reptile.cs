using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public string SkinType { get; set; }

		public bool ColdBlooded { get; set; }

		public bool LayEggs { get; set; }

        public bool RegenerateTail { get; set; }


		public void Display()
		{
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is Alive: {IsAlive}");
            Console.WriteLine($"Sound: {Sound}");
            Console.WriteLine($"Skin type: {SkinType}");
            Console.WriteLine($"Cold blooded: {ColdBlooded}");
            Console.WriteLine($"Lay eggs: {LayEggs}");
            Console.WriteLine($"Regenerate tails {RegenerateTail}");


        }
    }
}

