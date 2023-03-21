using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Footwear
{
    public class MensFootwear : IFootwear
    {
        public int MinimumSize => 38;

        public int MaximumSize => 48;

        public List<ClothColor> clothColors => new List<ClothColor>()
                {
                    ClothColor.Black,
                    ClothColor.Royal,
                    ClothColor.Purple,
                    ClothColor.Olive,
                    ClothColor.Khaki
                };
    }
}
