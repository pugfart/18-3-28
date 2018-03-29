using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class sword
    {
        public int damage;
        public int aviod;
        private Random b = new Random();
        public sword()
        {            
            damage =b.Next(1,4);
            aviod = b.Next(20);
        }       
    }
}
