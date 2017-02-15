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

        public Neighborhood(string name) {
            Name = name;
        }

        
        public void AddB(Building build) {
            building.Add(build);
        }

        public override string ToString()
        {
        StringBuilder buildlist = new StringBuilder();
        foreach(Building build in building) {
                buildlist.Append("\n\r - Building " + build.ToString());
        }
            return " Neighborhood " + Name + buildlist.ToString();
        }
    }
    }

