using NUnit.Framework;
using System;
using HW2.NonDI;
namespace HW2.UnitTesting
{
    [TestFixture]
    public class TesterNonDI
    {
        string _pwd = "12345";

        Key _key;

        House _house;

        House _houseNew;

        Door _door;

        Door _doorNew;

        Knob _knob;

        KnobPwd _knobPwd;

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
            _houseNew = new House();

            _door = _house.InstallDoor();
            _doorNew = _houseNew.InstallDoor();

            Assert.AreNotSame(_door, _doorNew);
        }

        [Test]
        public void CheckKnob()
        {
            _knob = new Knob();
            _knobPwd = new KnobPwd();
            _door.IntsallKnob(_knob);
            _door.IntsallKnob(_knobPwd);
            Assert.AreSame(_knob, _house.Door.Knob);
            Assert.AreSame(_knobPwd, _house.Door.KnobPwd);
            _keyholdOnKnod = _knob.InstallKeyhold();
            Assert.AreSame(_keyholdOnKnod, _house.Door.Knob.Keyhold);

            _keyholdOnKnod.Index = 1;

            Boolean _isOpened = _keyholdOnKnod.TurnandOpen(_key);
            Assert.True(_isOpened);
        }

        [Test]
        public void CheckKnobPwd()
        {
            _knobPwd.Pwd = "12345";
            Boolean _isPwdOpened = _knobPwd.PwdOpen(_pwd);
            Assert.True(_isPwdOpened);

        }

        [Test]
        public void CheckKeyhold()
        {

            //_keyholdOnKnod = _knob.InstallKeyhold();
            //Assert.AreSame(_keyholdOnKnod, _house.Door.Knob.Keyhold);// there was bugs here

            //_keyholdOnKnod.Index = 1;
            
            //Boolean _isOpened = _keyholdOnKnod.TurnandOpen(_key);
            //Assert.True(_isOpened);
        }

    }
}