using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Jacket
{
    public class WomensJacket : IJacket
    {
        public int NumberOfPockets => 6;

        public List<ClothColor> clothColors => new List<ClothColor>()
        {
            ClothColor.Black,
            ClothColor.MintGreen,
            ClothColor.Teal
        };
    }
}
