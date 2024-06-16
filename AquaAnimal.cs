using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class AquaAnimal
    {
        public string Type { get; set; }

        public AquaAnimal(string type ) { Type = type; }

        public override string ToString()
        {
            return $"Type: {Type}";
        }
    }
}
