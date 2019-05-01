using System;
using ClassLibraryCharactersAndWeapons;
using ClassLibraryCharactersAndWeapons.UnityContainers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Unity.Injection;

namespace UnitTestProjectDITests
{
    [TestClass]
    public class WarriorTestUnity
    {

        IUnityContainer unityContainer;

        public WarriorTestUnity()
        {
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void SamuraiUnityInject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = unityContainer.Resolve<Samurai>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Samurai));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(Katana));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");

        }

        [TestMethod]
        public void NinjaUnityInject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = unityContainer.Resolve<Ninja>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Ninja));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(Sword));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");

        }

        [TestMethod]
        public void SpaceMarineUnityInject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = unityContainer.Resolve<SpaceMarine>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(SpaceMarine));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(BFG));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");

        }
        [TestMethod]
        public void KratosUnityInject()
        {
            //Arrange

            Warrior warrior;

            string attackTarget = "target";

            //Act

            warrior = unityContainer.Resolve<Kratos>();

            //Assert

            Assert.IsInstanceOfType(warrior, typeof(Warrior));
            Assert.IsInstanceOfType(warrior, typeof(Kratos));

            Assert.IsInstanceOfType(warrior.Weapon, typeof(BladesOfChaos));

            Assert.AreEqual(warrior.Attack(attackTarget), $"{warrior.Weapon.Name} hits {attackTarget}");

        }
    }
}
