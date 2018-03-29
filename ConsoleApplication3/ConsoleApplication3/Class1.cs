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
        public sword()
        {
            Random b = new Random();
            damage = b.Next(1, 4);
        }
    }
}
