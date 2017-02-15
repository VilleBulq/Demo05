using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Program
    {
        static void Main(string[] args)
        {
            City jyvaskyla = new City();
            jyvaskyla.Name = "Jyväskylä";

            Neighborhood kuokkala = new Neighborhood();
            Neighborhood hillmatthew = new Neighborhood();

            hillmatthew.Name = "Mäki-matti";
            kuokkala.Name = "Kuokkala";

            Building vesitorni = new Building("Vesitorni", "Vesitornintie");
            kuokkala.Addbuilding(vesitorni);

            jyvaskyla.AddNeigh(kuokkala);
            jyvaskyla.AddNeigh(hillmatthew);

            Console.WriteLine(jyvaskyla.ToString());

            jyvaskyla.ShowNeigh();

            hillmatthew.ShowB();
            kuokkala.ShowB();
           
        }
    }
}
