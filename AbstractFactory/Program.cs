using AbstractFactory;
using AbstractFactory.ClothingFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Welcome to Clothing Factory <<<\n");

        Console.WriteLine("> Choose what to work on today: ");

        Console.WriteLine("> M - Men's clothing");
        Console.WriteLine("> W - Women's clothing");
        Console.WriteLine("> C - Children's clothing");

        Console.Write("\n>>");

        string clothingName = Console.ReadLine()!;

        IClothingFactory factory = GetClothingFactory(clothingName);

        if (factory != null)
        {
            Clothing cl = new Clothing(factory);

            Console.WriteLine($"\n{cl}");
        }
        else
        {
            Console.WriteLine("\nInvalid input =(");
        }
    }

    private static IClothingFactory GetClothingFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "m" => new MensClothingFactory(),
            "w" => new WomensClothingFactory(),
            "c" => new ChildrensClothingFactory(),
            _ => null!
        };
}