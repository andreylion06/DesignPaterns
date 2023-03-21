using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMethod.VirusLibrary
{
    public class Virus : Prototype
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Type { get; set; }
        public List<VirusChild> Children { get; set; }
        public Virus(string name, int weight, string type, List<VirusChild> children)
        {
            Name = name;
            Weight = weight;
            Type = type;
            Children = children;
        }

        public override string ToString()
        {
            string output = $"{Name}, {Weight} bytes, {Type}, Children:\n";
            if (Children != null)
            {
                foreach (var child in Children)
                    output += $"\t{child}\n";
            }
            return output;
        }

        public override Prototype Clone()
        {
            return new Virus(Name, Weight, Type, new List<VirusChild>(Children));
        }
    }
}
