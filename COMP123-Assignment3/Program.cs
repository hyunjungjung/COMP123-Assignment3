using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        /*
         * Author: Joanne (Hyunjung) Jung
         * Student # : 300432364
         * Date Modified: July 7th, 2016
         * Description: Main method for driver class Program for Assignment 3
         * Version: 0.0.3 - Implemented GiantPlanet and TerrestrialPlanet to create giantPlanet and terristrialPlanet object
         * and WaitForAnyKey method in Main Method
         */
namespace COMP123_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         Giant Planet");
            Console.WriteLine("==============================");
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 1654879513, 9587411541, "Gas");
            Console.WriteLine(giantPlanet.ToString());
            
            Console.WriteLine("     Terrestrial Planet");
            Console.WriteLine("==============================");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 654654, 981541, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();
        }

        public static void waitForAnyKey()
        {
            Console.WriteLine("Please enter any key to continue.");
            Console.ReadKey();
        }
    }
}
