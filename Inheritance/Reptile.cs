using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            Age = 0;
            Legs = 2;
            LandSeaAir = "Air";
        }

        public bool CanSwim { get; set; }
        public bool IsScaley  { get; set; }
        public bool ChangesColor { get; set; }
        public string ColorScales { get; set; }
    }
}
