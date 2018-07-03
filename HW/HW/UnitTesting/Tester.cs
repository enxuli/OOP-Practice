using NUnit.Framework;
using System;
using Zenject;
namespace HW.UnitTesting
{
    [TestFixture]
    public class Tester : UnitTestBase 
    {
        protected override void SetInstallers()
        {
            installers.Add(new TesterInstaller());
        }

        [Inject]
        IIphoneCountable _iphone;

        [Inject]
        IFloorCountable _building;

        [Inject]
        IDPTable _table;

        [Inject]
        IDPTableFactory _prototable;

        [Inject]
        IAlgoSettable _dp;

        [Test]
        public void CheckIphoneNum(){
            Assert.AreEqual(_iphone.Num(), 3);

        }

        [Test]
        public void CheckFloorNum()
        {
            Assert.AreEqual(_building.FloorNum(), 100);

        }


        [Test]
        public void CheckAlgo()
        {
            CheckTable();
            _table = _dp.DPTableGenerator(_table);
            Assert.AreEqual(_table[_building.FloorNum(), _iphone.Num()], 9);
        }
        public void CheckTable()
        {
            _table = _prototable.CreateMargin();
            int dim1 = _table.LengthOf(0);
            Assert.AreEqual(dim1, 101);
            int dim2 = _table.LengthOf(1);
            Assert.AreEqual(dim2, 4);
            _table[1, 0] = 1;
            Assert.AreEqual(_table[1, 0], 1);
        }

    }
}