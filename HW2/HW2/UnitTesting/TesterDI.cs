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
        IOpener _opener;

        [Inject]
        IHouseDI _house;

        [Inject]
        IHouseDI _houseNew;


        [Inject(Id ="KnobWithKey")]
        IKnobDI _knob;

        [Inject(Id = "KnobWithPwd")]
        IKnobDI _knobNew;

        [Inject]
        IKeyholdDI _keyhold;

        [Inject]
        IKeyDI _key;


        [Test]
        public void CheckOpenMethod()
        {
            Assert.AreEqual(_opener.Key.Index, 1);
            Assert.AreSame(_opener.Pwd, "12345");
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
            Boolean _isPwdOpened = _knobNew.Open(_opener); 
            Assert.True(_isPwdOpened);
        }

        [Test]
        public void CheckKnobKey()
        {
            Boolean _isKeyOpened = _knob.Open(_opener);
            Assert.True(_isKeyOpened);
        }
        [Test]
        public void CheckKeyhold()
        {
            Boolean _isOpened = _keyhold.TurnandOpen(_key);
            Assert.True(_isOpened);
        }



    }
}