using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCharactersAndWeapons
{
    public abstract class Warrior
    {
         protected IWeapon weapon;

        public IWeapon Weapon
        {
            get { return weapon; }
            protected set { this.weapon = value; }
        }

        public Warrior(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public string Attack(string target)
        {
            return this.weapon.Hit(target);
        }
    }
}
