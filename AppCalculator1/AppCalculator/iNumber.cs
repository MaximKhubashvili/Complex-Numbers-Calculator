using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator
{
    public interface iNumber
    {
        bool isZero();
        iNumber Copy();
        iNumber Add(iNumber Value);
        iNumber Deduct(iNumber Value);
        iNumber Mul(iNumber Value);
        iNumber Divide(iNumber Value);
        iNumber Sqr();
        iNumber Rev();
        string GetNumberString();
    }
}
