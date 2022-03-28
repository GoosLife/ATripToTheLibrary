using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATripToTheLibrary
{
    public class BookGenerator
    {
        public List<Book> GenerateBooks() // Generate 10 books with random genre and page count
        {
            List<Book> books = new List<Book>();

            string[] titles =
            { 
                "Soldier of the Mountain",
                "Duke of Next Year",
                "Warriors of Silver",
                "Owls of Destruction",
                "Trees and Thieves",
                "Foes and Butchers",
                "Crossbow Without Hate",
                "Cause With Pride",
                "Searching for the Country",
                "Hurt by Time",
            };

            string[] authors =
            {
                "Melanie Draper",
                "Cameron Mcmanus",
                "Ho Hardy",
                "Marius Hastings",
                "Halimah Ross",
                "Francisco Patel",
                "Sapphire Robbins",
                "Jayce Finney",
                "Monika Christian",
                "Dua Velazquez",
            };

            string[] genres =
            {
                "Science Fiction",
                "Romance",
                "Fantasy",
                "Thriller",
                "Young Adult",
                "Mystery",
                "Childrens",
                "Drama",
            };

            Random random = new Random();

            for (int i = 0; i < titles.Length; i++)
            {
                int genreId = random.Next(genres.Length);
                int pages = random.Next(178, 536);

                Book b = new Book(i, titles[i], authors[i], genres[genreId], pages);

                books.Add(b);
            }

            return books;
        }
    }
}
