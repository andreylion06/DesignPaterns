using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Jacket
{
    public class MensJacket : IJacket
    {
        public int NumberOfPockets => 6;

        public List<ClothColor> clothColors => new List<ClothColor>()
        {
            ClothColor.Black,
            ClothColor.Grey,
            ClothColor.Orange
        };
    }
}
