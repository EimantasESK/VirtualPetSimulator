using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetSimulator
{
    class World
    {
        public void Run()
        {
            Console.Title = "=== Virtual Pet Simulator ===";
            Console.WriteLine(@" __      ___      _               _   _____     _   
 \ \    / (_)    | |             | | |  __ \   | |  
  \ \  / / _ _ __| |_ _   _  __ _| | | |__) |__| |_ 
   \ \/ / | | '__| __| | | |/ _` | | |  ___/ _ \ __|
    \  /  | | |  | |_| |_| | (_| | | | |  |  __/ |_ 
     \/   |_|_|   \__|\__,_|\__,_|_| |_|   \___|\__|");
            Console.WriteLine("Welcome to pet simulator!");
            Console.WriteLine("");

            VirtualPet leo = new VirtualPet("Leo", 12, "Cat", true);
            //leo.ExpierencePoints = 10;
            Console.WriteLine("> Pet1");
            leo.Greet();
            leo.Eat("some dry food");
            Console.WriteLine("");

            VirtualPet junior = new VirtualPet("Junior", 50, "Parrot", false);
            Console.WriteLine("> Pet2");
            junior.Greet();
            junior.Eat("a worm");
            junior.Sleep();
            Console.WriteLine("");

            VirtualPet callieTheUnicorn = new VirtualPet("Callie", 250, "Unicorn", true);
            Console.WriteLine("> Pet3");
            callieTheUnicorn.Greet();
            callieTheUnicorn.Eat("rainbows");
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
        }
    }
}
