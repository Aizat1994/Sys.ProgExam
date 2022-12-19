using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class CarsPlinQ
    {

        public static List<string> cars = new List<string>() {"Honda Acord", "Toyota Camry","Mitsubishi Lancer","Lada govno","Nissan Skyline " ,"Haval p350" };
        public async static Task PrintCars()
        {

            (from c in cars.AsParallel() select c).ForAll(Console.WriteLine);
        }
    }
}
