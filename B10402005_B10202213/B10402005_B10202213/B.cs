using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10402005_B10202213
{
    class B
    {
        public void Prime()
        {
            int n = 0;

            IsPrime(n);
        }

        public Boolean IsPrime(int prime)
        {
            for (int j = 2; j <= prime - 1; j++)
            {
                if (prime % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
