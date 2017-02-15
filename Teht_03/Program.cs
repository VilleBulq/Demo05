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
            // First create city
            City jyvaskyla = new City("Jyväskylä");
            // create neighborhood
            Neighborhood kuokkala = new Neighborhood("Kuokkala");
            Neighborhood hillmatthew = new Neighborhood("Mäki-matti");
            // Add neighborhoods to city
            jyvaskyla.AddNeigh(kuokkala);
            jyvaskyla.AddNeigh(hillmatthew);
            // Create buildings to neighborhood
            Building vesitorni = new Building("Vesitorni", "Vesitornintie");
            Building filmtown = new Building("Filmtown", "Voionmaankatu");
            Building munluukku = new Building("Opiskeljaboxi", "Keskikatu");
            Building synergia = new Building("Synergia", "Joku osoite");
            // Add buildings to neighborhood
            kuokkala.AddB(vesitorni);
            hillmatthew.AddB(filmtown);
            hillmatthew.AddB(munluukku);
            hillmatthew.AddB(synergia);
            // show the city
            jyvaskyla.ShowNeigh();

            

            
           
        }
    }
}
