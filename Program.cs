using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scat scat = new Scat("Scat", "Joe");
            Whale whale = new Whale("Whale", 1500);
            SeaLion lion = new SeaLion("Sea Lion", "Fish");

            List<AquaAnimal> list = new List<AquaAnimal>(3);
            list.Add(whale);
            list.Add(lion);
            list.Add(scat);

            Aquarium aqua = new Aquarium(list);

            foreach (var el in aqua) {
                
                Console.WriteLine($"--------\n{el}");
            }

            Console.ReadLine();
        }
    }
}
