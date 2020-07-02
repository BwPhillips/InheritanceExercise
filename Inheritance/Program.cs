using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Step1---------------------------------

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            //----------------------------Done-------------------------------


            //-------------------------Step2---------------------------------

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            {
                myBird.CanFly = true;
                myBird.Color = "Purple";
                myBird.Migrates = true;
                myBird.BeakLength = 5.8;

            }

            var snake = new Reptile()
            {
                CanSwim = true,
                IsScaley = true,
                ChangesColor = true,
                ColorScales = "rainbow"

            };

            var myAnimals = new Animal[] { myBird, snake };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It has: {animal.Legs}");
                Console.WriteLine($"It lives by: {animal.LandSeaAir}");

            }
            
        }
    }
}
