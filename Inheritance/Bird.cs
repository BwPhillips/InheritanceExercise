using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            Age = 0;
            Legs = 4;
            LandSeaAir = "Air";


        }

        public bool CanFly { get; set; }
        public string Color { get; set; }
        public bool Migrates  { get; set; }
        public double BeakLength { get; set; }
    }
}
