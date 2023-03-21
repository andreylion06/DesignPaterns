using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingItems.Footwear
{
    public interface IFootwear : IClothItem
    {
        int MinimumSize { get; }
        int MaximumSize { get; }
    }
}
