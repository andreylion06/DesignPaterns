using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Footwear
{
    public class WomensFootwear : IFootwear
    {
        public int MinimumSize => 35;

        public int MaximumSize => 44;

        public List<ClothColor> clothColors => new List<ClothColor>()
                {
                    ClothColor.Black,
                    ClothColor.Teal,
                    ClothColor.Lilac,
                    ClothColor.Teal,
                    ClothColor.Peach
                };
    }
}
