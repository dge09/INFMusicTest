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


                    default:
                        break;
                }


                //Console.Clear();
            }
        }
    }
}