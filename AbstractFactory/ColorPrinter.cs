
namespace AbstractFactory
{
    public static class ColorPrinter
    {
        public static string ConsoleString(List<ClothColor> colors)
        {
            string output = "";
            foreach (ClothColor c in colors)
            {
                output += $"{c}";
                if (!c.Equals(colors[colors.Count - 1]))
                    output += ", ";
            }
            return output;
        }
    }
}
