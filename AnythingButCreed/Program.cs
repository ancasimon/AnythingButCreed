using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();

            var song1 = new Song { Name = "Foggy Mountain Breakdown", Artist = "Foggy Mountain Boys" };
            var song2 = new Song { Name = "Rocky Top", Artist = "Osborne Brothers" };
            var song3 = new Song { Name = "Blue Moon of Kentucky", Artist = "Bill Monroe" };
            var song4 = new Song { Name = "Uncle Pen", Artist = "Bill Monroe and His Bluegrass Boys" };
            var song5 = new Song { Name = "Down to the River to Pray", Artist = "Alison Krauss & Union Station" };
            var song6 = new Song { Name = "Choctaw Hayride", Artist = "Alison Krauss" };
            var song7 = new Song { Name = "Kentucky Waltz", Artist = "Bill Monroe and His Bluegrass Boys" };

            allSongs.Add(song1);
            allSongs.Add(song2);
            allSongs.Add(song3);
            allSongs.Add(song4);
            allSongs.Add(song5);
            allSongs.Add(song6);
            allSongs.Add(song7);

            var songsByCreed = new List<Song>
            {
                new Song { Name="One Last Breath", Artist="Creed" },
                new Song {Name="My Sacrifice", Artist="Creed" },
                new Song { Name = "With Arms Wide Open", Artist = "Creed" },
                new Song{Name="My Own Prison", Artist="Creed" },
                new Song{Name="Don't Stop Dancing", Artist= "Creed" }
            };

            allSongs.AddRange(songsByCreed);

            Console.WriteLine("Here are all the songs currently in our list: ");
            foreach (var individualSong in allSongs)
            {
                Console.WriteLine(individualSong.Name);
            }
            Console.WriteLine();

            var goodSongsTwo = allSongs.Where(song => song.Artist != "Creed");

            Console.WriteLine("But here are the GOOD songs in our list:");
            foreach(var individualSong in goodSongsTwo)
            {
                Console.WriteLine($"{individualSong.Artist}: {individualSong.Name}");
            }



        }
    }
}
