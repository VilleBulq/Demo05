using System;
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
            while (true)
            {
                Company comp = new Company();
                string name = Console.ReadLine();
                comp.Hire(name);
                comp.ShowEmps();
            }
        }
    }
}
