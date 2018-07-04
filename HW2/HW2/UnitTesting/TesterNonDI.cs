using NUnit.Framework;
using System;
using HW2.NonDI;
namespace HW2.UnitTesting
{
    [TestFixture]
    public class TesterNonDI
    {
        Key _key;

        House _house;

        Door _doorOnHouse;

        Knob _knobOnDoor;

        Keyhold _keyholdOnKnod;

        [Test]
        public void CheckKey()
        {
            _key = new Key
            {
                Index = 1
            };

            Assert.AreEqual(_key.Index, 1);
        }

        [Test]
        public void CheckDoor()
        {
            _house = new House();
            _doorOnHouse = _house.InstallDoor();
            Door _doorNew = new Door();

            Assert.AreSame(_doorOnHouse, _house.Door);
            Assert.AreNotSame(_doorOnHouse, _doorNew);
        }

        [Test]
        public void CheckKnob()
        {
            //_knobOnDoor = _doorOnHouse.IntsallKnob();
            //Knob _knobNew = new Knob();

            //Assert.AreSame(_knobOnDoor, _doorOnHouse.Knob);
            //Assert.AreNotSame(_knobOnDoor, _knobNew);



        }

        [Test]
        public void CheckKeyhold()
        {
            _knobOnDoor = _doorOnHouse.IntsallKnob();
            Knob _knobNew = new Knob();

            Assert.AreSame(_knobOnDoor, _doorOnHouse.Knob);
            Assert.AreNotSame(_knobOnDoor, _knobNew);

            _keyholdOnKnod = _knobOnDoor.InstallKeyhold();
            Keyhold _keyholdNew = new Keyhold();

            Assert.AreSame(_keyholdOnKnod, _house.Door.Knob.Keyhold);
            Assert.AreNotSame(_keyholdOnKnod, _keyholdNew);

            _keyholdOnKnod.Index = 1;
            
            Boolean _isOpened = _keyholdOnKnod.TurnandOpen(_key);
            Assert.True(_isOpened);
        }

    }
}