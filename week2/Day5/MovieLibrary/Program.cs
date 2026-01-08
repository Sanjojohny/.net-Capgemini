using System;
using MovieLibrary;

class Program
{
    static void Main()
    {
        FilmLibrary objFb = new FilmLibrary();

        Film a = new Film
        {
            Title = "TOXIC",
            Director = "GOPI SUNDAR",
            Year = 2004
        };

        Film b = new Film
        {
            Title = "KGF",
            Director = "neel",
            Year = 2000
        };

        objFb.AddFilm(a);
        objFb.AddFilm(b);

        Console.WriteLine("\n---------display films--------");
        foreach (IFilm item in objFb.GetFilms())
        {
            Console.WriteLine($"{item.Director}, {item.Title}, {item.Year}");
        }

        Console.WriteLine("\nEnter the film title to remove:");
        string rm = Console.ReadLine();

        objFb.RemoveFilm(rm);

        Console.WriteLine("\n---------display films after removal--------");
        foreach (IFilm item in objFb.GetFilms())
        {
            Console.WriteLine($"{item.Director}, {item.Title}, {item.Year}");
        }
    }
}
