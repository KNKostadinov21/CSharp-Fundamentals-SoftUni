using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Songs
{
    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().
                    Split('_').
                    ToArray();

                string typeList = input[0];
                string songName = input[1];
                string duration = input[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = songName;
                song.Time = duration;
                songs.Add(song);
            }

            string searchForTypeList = Console.ReadLine();

            if (searchForTypeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == searchForTypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}