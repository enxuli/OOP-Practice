using System;
namespace HW2.DI
{
    public interface IHouseKeyDI
    {
        IDoorKeyDI Door { get; }
    }
}
