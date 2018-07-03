using System;
namespace HW
{
    public interface IDPTable
    {
        int this[int row, int column] { get; set; }
        int LengthOf(int dim);
    }
}
