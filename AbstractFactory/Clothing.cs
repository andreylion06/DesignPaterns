using AbstractFactory.ClothingFactory;
using AbstractFactory.ClothingItems.Footwear;
using AbstractFactory.ClothingItems.Jacket;

namespace AbstractFactory
{
    public class Clothing
    {
        public IJacket? Jacket { get; set; }
        public IFootwear? Footwear { get; set; }

        public Clothing(IClothingFactory factory)
        {
            Jacket = factory.CreateJacket();
            Footwear = factory.CreateFootwear();
        }

        public override string ToString()
        {
            return
                $"Jacket: Number of pockets - {Jacket!.NumberOfPockets}\n" +
                $"\tColors: {ColorPrinter.ConsoleString(Jacket.clothColors)}\n" +
                $"Footware: Sizes {Footwear!.MinimumSize} - {Footwear.MaximumSize}\n" +
                $"\tColors: {ColorPrinter.ConsoleString(Footwear.clothColors)}\n";
        }
    }
}