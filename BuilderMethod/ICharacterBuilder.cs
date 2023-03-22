using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethod
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetStrength(int strength);
        ICharacterBuilder SetSpeed(int speed);
        ICharacterBuilder SetIntelligence(int intelligence);
        ICharacterBuilder SetIngenuity(int ingenuity);
        ICharacterBuilder SetWeapon(string weapon);
        Character Get();
    }
}
