using System;
namespace HW2.DI
{
    public interface IOpener
    {
        IKeyDI Key { get ; } 

        string Pwd { get ; }
    }
}
