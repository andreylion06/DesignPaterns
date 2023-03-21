using AbstractFactory.ClothingItems.Footwear;
using AbstractFactory.ClothingItems.Jacket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingFactory
{
    public class ChildrensClothingFactory : IClothingFactory
    {
        public IFootwear CreateFootwear()
        {
            return new ChildrensFootwear();
        }

        public IJacket CreateJacket()
        {
            return new ChildrensJacket();
        }
    }
}
