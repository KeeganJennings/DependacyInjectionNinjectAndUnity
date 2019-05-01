using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCharactersAndWeapons
{
    public interface IWeapon
    {

        string Name { get; }

        string Hit(string target);
    }
}
