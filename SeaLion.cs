using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceanarium
{
    internal class SeaLion:AquaAnimal
    {
        public string FavoriteDish {  get; set; }
        public SeaLion (string type,string favDish) : base(type)
        {
            FavoriteDish = favDish;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nFavorite dish: {FavoriteDish}";
        }
    }
}
