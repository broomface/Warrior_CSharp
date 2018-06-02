using System;

namespace Characters.Warriors
{


    public class Warrior // Warrior class...
    {
        // good practice to cluster variables together by type
        private int height; // Camel case for fields   ... another one is using _height depending on your employer
        private int weight; // Fields are designed to be used for internal use only 
        private string name;

        public int Height { get; set; } // Pascal case for properties  // Not yet linked to height...
        public int Weight { get; set; } // Properties are mainly for external use 
        public string Name { get; set; }


        public Warrior(int height, int weight, string name)
            // basic constructor  provides initial arguments to the objects at the time it is created
        {
            Height = height;
            Weight = weight;
            Name = name;

        }





        public void Greetings(Warrior warrior)
            // public AM, no return value, Greetings method that takes in a "Warrior" object value
        {
            Console.WriteLine($@"Greetings, {warrior.Name}!");
        }
    }
}