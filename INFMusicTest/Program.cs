using INFMusicTest.Data.Entitys;
using INFMusicTest.Data.Services;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What you wanna do?");
                Console.WriteLine("1) Add Author");
                Console.WriteLine("2) Get all Authors");
                Console.WriteLine("3) Add Song");
                Console.WriteLine("4) Get all Songs");

                Console.WriteLine();
                string option = Console.ReadLine();

                switch (int.Parse(option))
                {
                    case 1:
                        Console.WriteLine("Enter Authorname:");

                        AuthorService.AddAuthor(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();

                        List<Author> authors = AuthorService.GetAllAuthors();

                        foreach (var item in authors)
                        {
                            Console.WriteLine(item.AuthorID + ") " + item.Name);
                        }
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.WriteLine("Enter Song Title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Song AuthorID:");
                        int authorID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter GenreID:");
                        int genreID = int.Parse(Console.ReadLine());


                        SongService.AddSong(title, genreID, authorID);
                        break;
                    case 4:
                        Console.Clear();

                        List<Song> songs = SongService.GetAllSongs();

                        foreach (var item in songs)
                        {
                            Console.WriteLine(item.SongID + ") " + item.Title + ", Authorid: " + item.AuthorID + ", Genreid: " + item.GenreID);
                        }
                        Console.WriteLine();

                        break;

                    default:
                        break;
                }


                //Console.Clear();
            }
        }
    }
}