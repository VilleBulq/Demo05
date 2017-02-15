using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_03
{
    class Building
    {
    public string Name { get; set; }
    public string Street { get; set; }

    public Building() {

    }
    public Building(string name, string street) {
            Name = name;
            Street = street;
    }

        public override string ToString()
        {
            return "Name " + Name + " Street " + Street;
        }
    }
}
