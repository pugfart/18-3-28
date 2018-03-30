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
            Random a = new Random();
            sword swordone = new sword(a.Next());
            sword swordtwo = new sword(a.Next());
            grace.setting(15+swordone.aviod, 5+swordone.damage);
            andrew.setting(10+swordtwo.aviod, 6+swordtwo.damage);
            
            Console.WriteLine(grace.name + "的攻擊力是" + grace.hit + " 迴避率是"+grace.avoid+"\n"
                + andrew.name + "的攻擊力是" + andrew.hit + " 迴避率是" + andrew.avoid);
            Console.ReadLine();

            
            int hurt,dead=1,hp;
            bool punch;

            while (grace.hp >= 1 && andrew.hp >= 1)
            {
                hurt=a.Next(1,grace.hit);
                punch = andrew.avoid < a.Next(100);
                if (punch)
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
                punch = grace.avoid < a.Next(100);
                if (punch)
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
