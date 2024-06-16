using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class Aquarium:IEnumerable
    {
        

        public List <AquaAnimal> animals;
        public Aquarium (List<AquaAnimal> list)
        {
            animals = list;
        }

        public IEnumerator GetEnumerator ()
        {
            foreach(var animal in animals)
            {
                yield return animal;
            }
        }
        

        
        


        
    }
}
