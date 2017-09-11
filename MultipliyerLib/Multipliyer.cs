using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipliyerLib
{
    public class Multipliyer
    {
        public long Simple(long left, long right)
        {
            return left * right;
        }
        
        public long While(long left, long right)
        {
            long total = 0;
            long loopVar = 0;
            while (loopVar < left)
            {
                total += right;
                loopVar++;
            }

            return total;
        }
    }
}
