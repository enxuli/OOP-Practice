using NUnit.Framework;
using System;
using Zenject;
using HW2.DI;
namespace HW2.UnitTesting
{
    [TestFixture]
    public class TesterDI : UnitTestBase 
    {
        protected override void SetInstallers()
        {
            installers.Add(new TesterDIInstaller());
        }

        [Inject]
        IKeyDI _key;

        [Inject]
        IHouseDI _house;

        [Inject]
        IDoorDI _doorOnHouse;

        [Inject(Id ="newDoor")]
        IDoorDI _doorNew;

        [Inject]
        IKnobDI _knobOnDoor;

        [Inject(Id = "newKnob")]
        IKnobDI _knobNew;

        [Inject]
        IKeyholdDI _keyholdOnKnod;

        [Inject(Id = "newKeyhold")]
        IKeyholdDI _keyholdNew;

        [Test]
        public void CheckKey()
        {
            Assert.AreEqual(_key.Index, 1);
        }

        [Test]
        public void CheckDoor()
        {
            Assert.AreSame(_doorOnHouse, _house.Door);
            Assert.AreNotSame(_doorOnHouse, _doorNew);
        }

        [Test]
        public void CheckKnob()
        {
            Assert.AreSame(_knobOnDoor, _doorOnHouse.Knob);
            Assert.AreNotSame(_knobOnDoor, _knobNew);
        }

        [Test]
        public void CheckKeyhold()
        {
            Assert.AreSame(_keyholdOnKnod, _house.Door.Knob.Keyhold);
            Assert.AreNotSame(_keyholdOnKnod, _keyholdNew);
            
            Boolean _isOpened = _keyholdOnKnod.TurnandOpen(_key);
            Assert.True(_isOpened);
        }



    }
}