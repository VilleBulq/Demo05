using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD levy = new CD("Anna Babreu", 100);
            Song biisi = new Song("Hyvä kappale", 3.45);
            Song biisi2 = new Song("Huonompi kappale", 3.35);
            levy.AddSong(biisi);
            levy.AddSong(biisi2);
            Console.WriteLine(levy.ToString());
            levy.SongList();

        }
    }
}
