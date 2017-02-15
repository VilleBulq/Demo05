﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company();
            bool alive = true;
            while (alive)
            {
                Console.WriteLine("1: Palkkaa");
                Console.WriteLine("2: Erota");
                Console.WriteLine("3: Listaa");
                Console.WriteLine("0: Lopeta");
                int valinta = Int32.Parse(Console.ReadLine());
                switch (valinta)
                {
                    case 1:
                        string name = Console.ReadLine();
                        comp.Hire(name);
                        break;
                    case 2:
                        comp.Fire();
                        break;
                    case 3:
                        comp.ShowEmps();
                        break;
                    case 0:
                        alive = false;
                        break;
                }


            }


        }
    }
}
