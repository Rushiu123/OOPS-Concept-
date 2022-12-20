using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept_Program
{
    internal class OOPAbstaraction
    {
        public abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        public class Pig : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
    }
}
