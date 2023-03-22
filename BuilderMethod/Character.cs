using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod
{
    public class Character
    {
        public string? Name { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Intelligence { get; set; }
        public int Ingenuity { get; set; }
        public string? Weapon { get; set; }

        public override string ToString()
        {
            return $"{Name}:\n" +
                $"\tStrength: {Strength}\n" +
                $"\tSpeed: {Speed}\n" +
                $"\tIntelligence: {Intelligence}\n" +
                $"\tIngenuity: {Ingenuity}\n" +
                $"\tWeapon: " + (Weapon == null ? "Hands" : Weapon) + "\n";
        }

    }
}
