using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10402005_B10202213
{
    class B
    {
        public Boolean IsPrime(int n ){
            int i;
            for( i = 2 ; i <= n-1 ; i++ ){
                if( n % i == 0 ) {
                    return false;
                }
　	        }
            return true;
　	    }  
    }
}
