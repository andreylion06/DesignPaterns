using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public class EducationalSubscription : IMembership
    {
        public string Name { get; }
        public decimal Price { get; }
        public int MinimumDayPeriod { get; }
        public List<string> Channels { get; }
        public int CountOfDevices { get; }
        public EducationalSubscription(decimal price, int minimumDayPeriod, 
            List<string> channels, int countOfDevices)
        {
            Name = "Educational Subscription";
            Price = price;
            MinimumDayPeriod = minimumDayPeriod;
            Channels = channels;
            CountOfDevices = countOfDevices;
        }
    }
}
