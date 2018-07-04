using System;
namespace HW2.DI
{
    public interface IKeyholdDI
    {
        Boolean TurnandOpen(IKeyDI key);
        int Index {get;}
    }
}
