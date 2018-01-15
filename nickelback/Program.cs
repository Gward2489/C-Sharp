using System;
using System.Collections.Generic;
using System.Linq;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>(){
                ("Nickelback", "Photograph"),
                ("Nickelback", "Rockstar"),
                ("Jimi Hendrix", "Voodoo Child"),
                ("Steely Dan", "Peg"),
                ("James Brown", "The Big Payback"),
                ("Beethoven", "5th Symphony"),
                ("Led Zeppelin", "Kashmir")

            };

            foreach ((string, string) songAndBand in allSongs)
            {
                if (songAndBand.Item1 != "Nickelback")
                {
                    goodSongs.Add(songAndBand);
                }
            }       

            foreach ((string, string) songAndBand in goodSongs)
            {
                Console.WriteLine($"{songAndBand.Item2} by {songAndBand.Item1} is a Spicy Jam.");
            }                                                    
        }
    }
}
