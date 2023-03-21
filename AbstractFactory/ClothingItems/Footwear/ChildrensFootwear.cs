using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Footwear
{
    public class ChildrensFootwear : IFootwear
    {
        public int MinimumSize => 20;

        public int MaximumSize => 37;

        public List<ClothColor> clothColors => new List<ClothColor>()
                {
                    ClothColor.Black,
                    ClothColor.Royal,
                    ClothColor.Purple,
                    ClothColor.Olive,
                    ClothColor.Khaki,
                    ClothColor.Teal,
                    ClothColor.Lilac,
                    ClothColor.Teal,
                    ClothColor.Peach
                };
    }
}
