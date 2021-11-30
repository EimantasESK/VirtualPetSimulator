using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Speciecs { get; set; }
        public bool IsAwake { get; set; }
        private int ExpierencePoints { get; set; }

        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Speciecs = petSpecies;
            IsAwake = petIsAwake;
        }

        public void Greet()
        {
            Console.WriteLine($"May name is {FullName}, the {Speciecs}");
            Console.WriteLine($"I am {Age} years old");
            Console.WriteLine($"Is awake? {IsAwake}");
        }

        public void Sleep()
        {
            IsAwake = false;
            Console.WriteLine($"{FullName} is now happily snoring... Zzzz");
        }

        public void Eat(string foodName)
        {
            Console.WriteLine($"{FullName} is eating now {foodName}");
        }
    }
}
