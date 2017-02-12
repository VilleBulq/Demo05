using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class Song
    {
    private string Name { get; set; }
    private double Lenght { get; set; }

    public Song(string name, double lenght) {
            Name = name;
            Lenght = lenght;
    }
        public override string ToString()
        {
            return "Name " + Name + " Lenght " + Lenght;
        }
    }
}
