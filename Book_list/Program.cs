using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_list
{ 
    public class Book
    {
        public string Title {get; set;}
        public string Author {get; set;}
        public int Year {get; set;}
    }

    public class BookList
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public bool ContainsBook(Book book)
        {
            return _books.Contains(book);
        }

        public int Count
        {
            get {return _books.Count;}
        }

        public Book this[int index]
        {
            get {return _books[index];}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookList myBookList = new BookList();

            Book book1 = new Book {Title = "One Flew Over the Cuckoo's Nest", Author = "Ken Kesey", Year = 1962};
            Book book2 = new Book {Title = "Harry Potter and the Prisoner of Azkaban", Author = "Joanne Rowling", Year = 1999};

            myBookList.AddBook(book1);
            myBookList.AddBook(book2);

            Console.WriteLine("Number of books in the list: " + myBookList.Count);

            if (myBookList.ContainsBook(book1))
            {
                Console.WriteLine("The list contains the book: " + book1.Title);
            }

            for (int i = 0; i < myBookList.Count; i++)
            {
                Console.WriteLine("Book " + (i + 1) + ": " + myBookList[i].Title);
            }

            Console.ReadLine();
        }
    }

}
