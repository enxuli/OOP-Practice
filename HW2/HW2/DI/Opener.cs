using System;
using Zenject;

namespace HW2.DI
{
    public class Opener : IOpener
    {
        [Inject]
        IKeyDI  _key;
        [Inject]
        string  _pwd;

        public Opener()
        {
        }
        public IKeyDI Key { get { return _key; }}

        public string Pwd { get { return _pwd; } }

    }
}
