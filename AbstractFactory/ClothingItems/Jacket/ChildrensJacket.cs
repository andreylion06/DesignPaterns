using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Jacket
{
    public class ChildrensJacket : IJacket
    {
        public int NumberOfPockets => 5;

        public List<ClothColor> clothColors => new List<ClothColor>()
        {
            ClothColor.Lilac,
            ClothColor.Lime,
            ClothColor.Orange,
            ClothColor.MintGreen,
            ClothColor.Teal
        };
    }
}
