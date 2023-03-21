using AbstractFactory.ClothingItems.Footwear;
using AbstractFactory.ClothingItems.Jacket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ClothingFactory
{
    public class MensClothingFactory : IClothingFactory
    {
        public IFootwear CreateFootwear()
        {
            return new MensFootwear();
        }

        public IJacket CreateJacket()
        {
            return new MensJacket();
        }
    }
}
