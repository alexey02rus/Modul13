using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Добролюбова 8", 50, 25, 15);
            Console.WriteLine(building.GetInform());
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("Добролюбова 10", 60.5, 30.4, 12, 4);
            Console.WriteLine(multiBuilding.GetInform());
            Console.ReadKey();
        }
    }
}
