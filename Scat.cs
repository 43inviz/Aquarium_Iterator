using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class Scat: AquaAnimal
    {
        public string Name { get; set; }
        public Scat(string type,string name) : base(type)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nName: {Name}";
        }
    }
}
