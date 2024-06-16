using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class Whale:AquaAnimal
    {
        public double Weight { get; set; }
        public Whale(string type,double weight):base(type)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nWeight: {Weight} [KG]";
        }
    }
}
