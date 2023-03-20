using FactoryMethod.Domain;
using FactoryMethod.Factory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>> Welcome to Video Provider <<<\n");

        Console.WriteLine("> Enter the membership type you would like to create: ");

        Console.WriteLine("> D - Domestic");
        Console.WriteLine("> E - Educational");
        Console.WriteLine("> P - Premium");

        Console.Write("\n>>");

        string membershipType = Console.ReadLine()!;

        MembershipFactory factory = GetFactory(membershipType);

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n Membership you've just created: \n");

        Console.WriteLine(
            $"\tName:\t\t{membership.Name}\n" +
            $"\tPrice:\t{membership.Price}\n" +
            $"\tMinimum Day Period:\t{membership.MinimumDayPeriod}\n" +
            $"\tCount Of Devices:\t{membership.CountOfDevices}\n" +
            $"\tChanells:"
        );

        foreach (var chanel in membership.Channels)
            Console.WriteLine($"\t\t{chanel}");
    }

    private static MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "d" => new DomesticSubscriptionFactory(100, 30, new List<string>
            {
                "First Chanel", "Super Sport", "Kinder", "Nature Earth"
            }, 3)!,
            "e" => new EducationalSubscriptionFactory(60, 15, new List<string>
            {
                "First Chanel", "Super Sport", "Kinder", "Nature Earth", "Education TV"
            }, 3)!,
            "p" => new PremiumSubscriptionFactory(200, 30, new List<string>
            {
                "First Chanel", "Super Sport", "Kinder", "Nature Earth", "Education TV",
                "Premium Chan", "Premium Sport", "Premium Cinema", "Premium Content"
            }, 6)!,
            _ => null!
        };
}