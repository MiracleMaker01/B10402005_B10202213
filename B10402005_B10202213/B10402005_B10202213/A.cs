using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B10402005_B10202213
{
    class A
    {
        public int randNumber() {
            Random r = new Random();
            int number = r.Next(0,100);
            
            return number;
        }
    }
}
