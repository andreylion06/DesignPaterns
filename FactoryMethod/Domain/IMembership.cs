using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Domain
{
    public interface IMembership
    {
        string Name { get; }
        decimal Price { get; }
        int MinimumDayPeriod { get; }
        List<string> Channels { get; }
        int CountOfDevices { get; }
    }
}
