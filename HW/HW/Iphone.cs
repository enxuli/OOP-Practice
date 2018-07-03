using System;
using Zenject;
namespace HW
{
    public class Iphone : IIphoneCountable
    {
        [Inject]
        protected int _num;

        public int Num()
        {
                return _num;
        }
    }

}
