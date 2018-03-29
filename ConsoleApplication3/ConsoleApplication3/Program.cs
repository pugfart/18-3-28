using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            People grace = new People("grace", 100);
            People andrew = new People("andrew", 100);

            grace.setting(20, 5);
            andrew.setting(10, 6);

            Random a = new Random();
            int hurt,dead=1,hp;
            bool pouch;

            while (grace.hp >= 1 && andrew.hp >= 1)
            {
                hurt=a.Next(1,grace.hit);
                pouch = andrew.avoid < a.Next(100);
                if (pouch)
                {
                    hp = grace.attack(andrew, hurt);
                    Console.WriteLine(andrew.name + "被攻擊了, 血量少了" + hurt + "滴, hp = " + hp);
                }
                else
                    Console.WriteLine(andrew.name + "躲開了!!!");
                System.Threading.Thread.Sleep(100);

                if (andrew.hp < 1)
                {
                    dead = 0;
                    break;
                }

                hurt = a.Next(1,andrew.hit);
                pouch = grace.avoid < a.Next(100);
                if (pouch)
                {
                    hp = andrew.attack(grace, hurt);
                    Console.WriteLine(grace.name + "被攻擊了, 血量少了" + hurt + "滴, hp = " + hp);
                }
                else
                    Console.WriteLine(grace.name + "躲開了!!!");
                System.Threading.Thread.Sleep(100);              
            }
            if (dead == 1)
                Console.WriteLine("\n"+grace.name + "葛屁");
            else
                Console.WriteLine("\n"+       andrew.name + "葛屁");
            Console.Read();
        }
    }
}
