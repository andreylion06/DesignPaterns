using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderMethod
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character? _character;
        public EnemyBuilder()
        {
            _character = new();
        }
        public ICharacterBuilder SetName(string name)
        {
            _character!.Name = $"Enemy {name}";
            return this;
        }
        public ICharacterBuilder SetStrength(int strength)
        {
            _character!.Strength = strength;
            return this;
        }
        public ICharacterBuilder SetSpeed(int speed)
        {
            _character!.Speed = speed;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligence)
        {
            _character!.Intelligence = intelligence;
            return this;
        }
        public ICharacterBuilder SetIngenuity(int ingenuity)
        {
            _character!.Ingenuity = ingenuity;
            return this;
        }
        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character!.Weapon = weapon;
            return this;
        }
        public Character Get()
        {
            Character character = _character!;

            _character = new();

            return character;
        }
    }
}
