using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_02
{
    class CD
    {
        private string Artist { get; set; }
        private float Price { get; set; }
        private List<Song> Songs = new List<Song>();

        public CD(string artist, float price) {
            Artist = artist;
            Price = price;
        }

        public void AddSong(Song song) {
            Songs.Add(song);
        }
        public void SongList() {
        foreach(Song s in Songs) {
                Console.WriteLine(s);
        }
        }
        public override string ToString()
        {
            return "Artist " + Artist + " Price " + Price;
        }
    }
}
