using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATripToTheLibrary
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }

        public Book(int id, string title, string author, string genre, int pages)
        {
            ID = id;
            Title = title;
            Author = author;
            Genre = genre;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"    ID: {ID}\n" +
                   $"    {Title}\n" +
                   $"    by {Author}\n" +
                   $"    Genre: {Genre}\n" +
                   $"    Pages: {Pages}";
        }
    }
}
