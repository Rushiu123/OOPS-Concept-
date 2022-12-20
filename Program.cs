using System.Net.NetworkInformation;
using System;
using OPPS_Concept_Program;

namespace OPPS_Concept_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from bellow option");
            Console.WriteLine("1:Inheritance");
            Console.WriteLine("1:Inheritance\n2:Abstraction\n3:Polmorphisum");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Car car = new Car();
                    car.brand = "Audi";
                    car.price = 100000000;
                    car.VehicleDetails();
                    car.Start();
                    Bike bike = new Bike();
                    bike.brand = "Unicorn";
                    bike.price = 1000000;
                    bike.VehicleDetails();
                    bike.Start();
                    break;
                case 2:
                    Pig pig = new Pig(); // Create a Pig object
                    pig.animalSound();  // Call the abstract method
                    pig.sleep();  // Call the regular method
                    break;
                case 3:
                    Apple obj = new Apple();
                    obj.PrintName();
                    break;
                default:
                    Console.WriteLine("Please choose given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
    


 
            