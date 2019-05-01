using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using ClassLibraryCharactersAndWeapons;

namespace ClassLibraryCharactersAndWeapons.NinjectModules
{
    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            //If any class needs an IWeapon, it will get a sword 
            this.Bind<IWeapon>().To<Sword>();
            this.Bind<IWeapon>().To<Katana>().WhenInjectedExactlyInto<Samurai>();
            this.Bind<IWeapon>().To<BFG>().WhenInjectedExactlyInto<SpaceMarine>();
            this.Bind<IWeapon>().To<BladesOfChaos>().WhenInjectedExactlyInto<Kratos>();
        }
    }
}
