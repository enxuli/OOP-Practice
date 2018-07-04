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

        [Inject(Id = "testpwd")]
        String pwd;

        [Inject]
        IHouseDI _house;

        [Inject]
        IHouseDI _houseNew;


        [Inject(Id ="Knob")]
        IKnobDI _knob;

        [Inject(Id = "KnobWithPwd")]
        IKnobDI _knobNew;

        [Inject]
        IKeyholdDI _keyhold;


        [Test]
        public void CheckKey()
        {
            Assert.AreEqual(_key.Index, 1);
        }

        [Test]
        public void CheckHouse()
        {
            Assert.AreNotSame(_house, _houseNew);
        }

        [Test]
        public void CheckDoor()
        {
            Assert.AreNotSame(_house.Door, _houseNew.Door);
        }

        [Test]
        public void CheckKnob()
        {
            _house.Door.InstallKnob(_knob);
            _houseNew.Door.InstallKnob(_knobNew);

            Assert.AreSame(_knob, _house.Door.Knob);
            Assert.AreSame(_knobNew, _houseNew.Door.Knob);//there was a bug here
            Assert.AreNotSame(_knob, _knobNew);
            Assert.AreSame(_keyhold, _house.Door.Knob.Keyhold);//there was a bug here

        }

        [Test]
        public void CheckKnobPwd()
        {
            Boolean _isOpened = _knobNew.PwdOpen(pwd); 
            Assert.True(_isOpened);
        }

        [Test]
        public void CheckKeyhold()
        {
            Boolean _isOpened = _keyhold.TurnandOpen(_key);
            Assert.True(_isOpened);
        }



    }
}