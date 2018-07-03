using System;
namespace HW
{
    public interface IAlgoSettable
    {
        IDPTable DPTableGenerator(IDPTable table);
    }
}
