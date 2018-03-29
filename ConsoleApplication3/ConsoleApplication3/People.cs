using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class People
    {
        public People()
        {

        }

        public People(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public string name;

        public int hp;

        public int avoid;

        public int hit;

        public void setting(int a,int h)
        {
            this.avoid = a;
            this.hit = h;
        }

        public int attack(People p,int a)
        {
                p.hp = p.hp - a;
                if (p.hp < 0) p.hp = 0;
                return p.hp;
            
        }
    }
}
