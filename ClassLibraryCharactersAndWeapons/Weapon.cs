using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCharactersAndWeapons
{
    public abstract class Weapon : IWeapon
    {

        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Weapon()
        {
            this.name = "Name";
        }
        public string Hit(string target)
        {
            return $"{this.name} hits {target}";
        }
    }
}
