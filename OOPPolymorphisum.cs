using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS_Concept_Program
{
    internal class OOPPolymorphisum
    {
        public class Fruit
        {
            public void PrintName()
            {
                Console.WriteLine("Fruit");
            }
        }
        public class Apple : Fruit
        {
            public void PrintName()
            {
                Console.WriteLine("Apple fruit");
            }
        }
    }
}
