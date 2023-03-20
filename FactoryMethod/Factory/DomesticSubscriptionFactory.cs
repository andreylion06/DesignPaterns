using FactoryMethod.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class DomesticSubscriptionFactory : MembershipFactory
    {
        public decimal Price { get; }
        public int MinimumDayPeriod { get; }
        public List<string> Channels { get; }
        public int CountOfDevices { get; }
        public DomesticSubscriptionFactory(decimal price, int minimumDayPeriod,
            List<string> channels, int countOfDevices)
        {
            Price = price;
            MinimumDayPeriod = minimumDayPeriod;
            Channels = channels;
            CountOfDevices = countOfDevices;
        }
        public override IMembership GetMembership()
        {
            return new DomesticSubscription(Price, MinimumDayPeriod, Channels, CountOfDevices);
        }
    }
}
