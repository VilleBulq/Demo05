using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Neighborhood
    {
        public List<Building> building = new List<Building>();
        public string Name { get; set; }
        
        public void ShowB()
        {
            foreach (Building build in building)
            {
                Console.WriteLine(build.ToString());
            }
        }
        public void Addbuilding(Building build) {
            building.Add(build);
        }
        public override string ToString()
        {
            return "Neighborhood name " + Name;
        }
    }
    }

