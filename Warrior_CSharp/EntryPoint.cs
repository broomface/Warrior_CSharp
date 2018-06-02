using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Characters.Warriors;

namespace Warrior_CSharp
{
    

    public class EntryPoint  // actual start of the program 
    {
        static void Main(string[] args)
        {
            Warrior theGoodGuy = new Warrior(180, 90, "Good Guy");  // instance with no parameters (empty guy)
            //theGoodGuy.Height = 180;   // no longer needed when passing in parameters in the constructor
            //theGoodGuy.Weight = 90;
            //theGoodGuy.Name = "The Good Guy";

            Warrior theBadGuy = new Warrior(300, 600, "Bad Guy");
            //theBadGuy.Height = 300;  // no longer needed whe n passing in parameters in the constructor
            //theBadGuy.Weight = 600;
            //theBadGuy.Name = "The Bad Guy";
            Console.WriteLine(theBadGuy.Height);
            Console.WriteLine(theGoodGuy.Weight);


            theGoodGuy.Greetings(theBadGuy);  // behaviors
            theBadGuy.Greetings(theGoodGuy);  // behaviors

        }
    }
}
