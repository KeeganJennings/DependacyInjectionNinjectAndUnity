using System;
using ClassLibraryCharactersAndWeapons;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject.Modules;
using ClassLibraryCharactersAndWeapons.NinjectModules;
using Ninject;

namespace UnitTestProjectDITests
{
    [TestClass]
    public class WarriorTest
    {
        IKernel kernel;

        public WarriorTest()
        {
            kernel = new StandardKernel(new WarriorModule());
        }
        [TestMethod]
        public void SamuraiNoInject()
        {
            //Arrange

            Weapon weapon;
            Warrior warrior;

            string attackTarget = "target";

            //Act

            weapon = new Katana();
            warrior = new Samurai(weapon);

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SamuraiNinject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = kernel.Get<Samurai>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaNinject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = kernel.Get<Ninja>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SpaceMarineNinject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = kernel.Get<SpaceMarine>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(SpaceMarine));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(BFG));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void KratosNinject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = kernel.Get<Kratos>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Kratos));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(BladesOfChaos));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");
        }
    }
}
