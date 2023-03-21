using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMethod.VirusLibrary
{
    public class VirusChild : Virus
    {
        public DateTime birthDate { get; set; }
        public Virus Parent { get; set; }

        public VirusChild(string name, int weight, string type,
            List<VirusChild> children, DateTime birthDate, Virus parent) : base(name, weight, type, children)
        {
            this.birthDate = birthDate;
            Parent = parent;
        }

        public override string ToString()
        {
            return $"{Name}, {Weight} bytes, {Type}, {birthDate}";
        }

        public override Prototype Clone()
        {
            return new VirusChild(Name, Weight, Type, new List<VirusChild>(Children), birthDate, Parent);
        }
    }
}
