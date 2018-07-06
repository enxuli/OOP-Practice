using System;
namespace HW2.DI
{
    public interface IHousePwdDI
    {
        IDoorPwdDI Door { get; }
    }
}
