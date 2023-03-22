using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod
{
    public class Director
    {
        private readonly ICharacterBuilder _builder;

        public Director(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void Build(string name, int strength, int speed, 
            int intelligence, int ingenuity, string weapon)
        {
            _builder
                .SetName(name)
                .SetStrength(strength)
                .SetSpeed(speed)
                .SetIntelligence(intelligence)
                .SetIngenuity(ingenuity)
                .SetWeapon(weapon);
        }
    }
}
