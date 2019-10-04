using System;
namespace AnimalQueue
{
    public enum AnimalType { Cat, Dog, Rabbit, NoPreference }

    public class Animal
    {
        public Animal()
        {
        }

        public AnimalType AnimalType { get; set; }

        public string Name { get; set; }

        public double Weight { get; set; }

        public override string ToString()
        {
            
        }

    }
}
