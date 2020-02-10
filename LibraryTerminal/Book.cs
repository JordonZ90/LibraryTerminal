using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTerminal
{
    class Book
    {

        public static List<Book> Books = new List<Book>()
        {
            new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"), // //
            new Book("The Fellowship of The Ring", "J.R.R. Tolkien", "Fantasy"), // //
            new Book("The Stand", "Stephen King", "Horror"), // //
            new Book("The Handmaid's Tale", "Margaret Atwood", "Suspense"), // //
            new Book("The Testaments", "Margaret Atwood", "Suspense"), // //
            new Book("The Road", "Cormac McCarthy", "Dystopian"),//
            new Book("Cujo", "Stephen King", "Horror"), // //
            new Book("The Sum of All Fears", "Tom Clancy", "Suspense"), // //
            new Book("The Hunger Games", "Suzanne Collins", "Dystopian"), //
            new Book("Harry Potter and the Goblet of Fire", "J.K Rowling", "Fantasy"), // 
            new Book("War of the Worlds", "H. G. Wells", "Fantasy"), // 
            new Book("Brave New World", "Aldous Huxley", "Dystopian")
  
        
    };

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Status { get; set; }
        public DateTime DueDate { get; set; }

        // constructors
        public Book()
        {
            Status = true;
            DueDate = DateTime.Now;
        }
        public Book(string title, string author, string genre, bool status = true)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Status = status;
            DueDate = DateTime.Now;
        }

        public void CheckOut()
        {
            Status = false;
            DueDate = DateTime.Now.AddDays(14);
        }
        public void CheckIn()
        {
            //Status = true;
            DueDate = DateTime.Now;
        }

        // List<Book> Books = new List<Book>();
        // Book Class: Properties Author, Title, Genre, Status (bool), Due Date (in Datetime)
        // 12 items, list of books | Lets create a public static list<Books> Books, Keep this within the Book Class
        // Foreach (Book book in Book(access the class) Books))

    }
}



                
