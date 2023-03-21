using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Jacket
{
    public interface IJacket : IClothItem
    {
        public int NumberOfPockets { get; }
    }
}
