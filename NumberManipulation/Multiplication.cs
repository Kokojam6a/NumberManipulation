using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation
{
    class Multiplication:Plus
    {
        public override double pluses(double x, double y)
        {
            return x * y;
        }
    }
}
