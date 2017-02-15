using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class City
    {
        public List<Neighborhood> neighborhood = new List<Neighborhood>();
        public string Name { get; set; }
        public void ListNeigh() {
            foreach (Neighborhood neigh in neighborhood) {
                Console.WriteLine(neigh.ToString());
            }
        }
        public void AddNeigh(Neighborhood neigh) {
            neighborhood.Add(neigh);
        }
        public void ShowNeigh() {
        foreach(Neighborhood neigh in neighborhood) {
                Console.WriteLine(neigh.ToString());
        }
        }
        public override string ToString()
        {
            return "City name " + Name;
        }

    }
}
