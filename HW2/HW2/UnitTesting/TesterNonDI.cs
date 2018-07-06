using NUnit.Framework;
using System;
using HW2.NonDI;
namespace HW2.UnitTesting
{
    [TestFixture]
    public class TesterNonDI
    {
        Key _key;

        Opener _opener;

        House _house;

        House _houseNew;

        Door _door;

        Door _doorNew;

        KnobKey _knobKey;

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

        public void CheckOpener()
        {
            _opener = new Opener
            {
                Key = _key,
                Pwd = "12345"
            };
            Assert.AreSame(_opener.Pwd, "12345");
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
            CheckOpener();
            _knobKey = new KnobKey();
            _knobPwd = new KnobPwd();
            _door.IntsallKnob(_knobKey);
            _doorNew.IntsallKnob(_knobPwd);

            Assert.AreSame(_knobKey, _house.Door.Knob);
            Assert.AreSame(_knobPwd, _houseNew.Door.Knob);

            _keyholdOnKnod = _knobKey.InstallKeyhold();
            Assert.AreSame(_keyholdOnKnod, _house.Door.Knob.Keyhold);
            _keyholdOnKnod.Index = 1;



            Boolean _isKeyOpened = _knobKey.Open(_opener);
            Assert.True(_isKeyOpened);


            Boolean _isOpened = _keyholdOnKnod.TurnandOpen(_key);
            Assert.True(_isOpened);
        }

        [Test]
        public void CheckKnobPwd()
        {
            _knobPwd.Pwd = "12345";
            Boolean _isPwdOpened = _knobPwd.Open(_opener);
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