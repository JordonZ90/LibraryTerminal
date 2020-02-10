using System;
using System.Collections.Generic;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {          

            Console.WriteLine("This is a Super Duper Library! \n");

            DisplayMenu();

            while (true)
            {
                //DisplayMenu();

                switch (GetUserInput("Please Make a Selection from the Menu Above: \n"))
                {

                    case "1":
                        // Displaying information of all books
                        DisplayBooks();
                        Console.WriteLine("Here is information about our selection of books! ");
                        UserContinue();
                        break;
                    case "2":
                        //displaying all Genres 
                        DisplayGenres();
                        string response = GetUserInput("Select a genre: ");
                        string selection = GetGenre(response);
                        DisplayBooksByGenre(selection);
                        UserContinue();
                        break;
                    case "3":
                        //Displaying books by specific author
                        SearchByAuthor();
                        string authorResponse = GetUserInput("Select an Author: ");
                        Console.WriteLine(GetAuthor(authorResponse));
                        UserContinue();
                        break;
                    case "4":
                        //Displaying only titles in the library
                        DisplayTitle();
                        UserContinue();
                        break;
                    case "5":
                        //displaying all books, also checking out books
                        DisplayBooks();
                        string checkoutResponse = GetUserInput("Select what book you want to checkout? \n ");
                        int index = int.Parse(checkoutResponse) - 1;
                        Book.Books[index].CheckOut();
                        Console.WriteLine("You've checked out a book! ");
                        UserContinue();
                        break;
                    case "6":
                        //displaying all books, also checking in books
                        DisplayBooks();
                        string checkinResponse = GetUserInput("Select what book you want to checkin? \n ");
                        int checkinIndex = int.Parse(checkinResponse) - 1;
                        Book.Books[checkinIndex].CheckIn();
                        Console.WriteLine("You've checked in a book! ");
                        UserContinue();
                        break;
                    case "7":
                        //Exit the menu
                    case "exit":                        
                        Environment.Exit(0);
                        Console.WriteLine("Now leaving the Super Duper Library ");
                        break;
                    default:
                        
                        break;
                }
            }
        }
        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine().ToLower();

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("[1]: Display All information of the books in the Super Duper Library ");
            

            Console.WriteLine("[2]: Display Books by Genre from the Super Duper Library ");
           

            Console.WriteLine("[3]: Display Books by Author from the Super Duper Library ");
            

            Console.WriteLine("[4]: Display Books by Title in the Super Duper Library ");
            

            Console.WriteLine("[5]: Lets checkout some books at the Super Duper Library ");
            

            Console.WriteLine("[6]: Lets check-in books back into the Super Duper Library ");
            

            Console.WriteLine("[7]: Now leaving the Super Duper Library ");
            
        }
        public static void DisplayBooks()
        {
            int count = 1;
            foreach (Book book in Book.Books)
            {
                Console.WriteLine($"[{count}] Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                
                count++;

                if (book.Status == true)
                {
                    Console.WriteLine($"Status: on Shelf \n");
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Status: checked out ");
                    Console.WriteLine($"The book is due: {book.DueDate.ToShortDateString()} \n");
                    Console.ResetColor();
                    
                }
            }
        }
        public static void DisplayTitle()
        {
            List<string> titles = new List<string>();
            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!titles.Contains(Book.Books[i].Title))
                {
                    titles.Add(Book.Books[i].Title);
                }
            }
            int count = 1;
            foreach (string title in titles)
            {
                Console.WriteLine($"[{ count}] {title} ");
                count++;
                
            }
        }
        public static void DisplayGenres()
        {
            List<string> genres = new List<string>(); // creating a genre list!

            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!genres.Contains(Book.Books[i].Genre))
                {
                    genres.Add($"{Book.Books[i].Genre}"); // ++count;
                }
            }
            int count = 1;
            foreach (string genre in genres)
            {
                Console.WriteLine($"[{ count}] {genre}");
                count++;
                
            }
        }
        public static void DisplayBooksByGenre(string selection)
        {
            foreach (Book book in Book.Books)
            {
                if (book.Genre == selection)
                {
                    Console.WriteLine($"The title of the book is: {book.Title}\n The author of the book is: {book.Author}\n The genre of the book is: " +
                        $"{book.Genre}\n The status of the book is: {book.Status}\n");

                }
            }
        }
        public static string GetGenre(string response)
        {
            if (response == "1")
            {
                return "Fantasy";
            }
            else if (response == "2")
            {
                return "Horror";
            }
            else if (response == "3")
            {
                return "Suspense";
            }
            else if (response == "4")
            {
                return "Dystopian";
            }
            else
            {
                Console.WriteLine("Invalid selection! ");
                response = GetUserInput("Selection Genre: ");

                return GetGenre(response); 
            }
        }
        public static void SearchByAuthor()
        {
            List<string> authors = new List<string>(); // creating an author list!


            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!authors.Contains(Book.Books[i].Author))
                {
                    authors.Add($"{Book.Books[i].Author}"); // ++count;
                }
            }
            int count = 1;
            foreach (string author in authors)
            {
                Console.WriteLine($"[{count}] {author}");
                count++;
            }
        }
        public static string GetAuthor(string authorResponse)
        {

            if (authorResponse == "1")
            {
                return "The Hobbit, The Fellowship of The Ring";
            }
            else if (authorResponse == "2")
            {
                return "The Stand, Cujo";
            }
            else if (authorResponse == "3")
            {
                return "The Testaments, The Handmaid's Tale";
            }
            else if (authorResponse == "4")
            {
                return "The Road";
            }
            else if (authorResponse == "5")
            {
                return "The Sum of All Fears";
            }
            else if (authorResponse == "6")
            {
                return "The Hunger Games";
            }
            else if (authorResponse == "7")
            {
                return "Harry Potter and the Goblet of Fire";
            }
            else if (authorResponse == "8")
            {
                return "War of the Worlds";
            }
            else if (authorResponse == "9")
            {
                return ("Brave New World");
            }
            else
            {
                Console.WriteLine("Invalid selection! ");
                authorResponse = GetUserInput("Please select an Author: ");

                return GetAuthor(authorResponse); // retuning the method within itself
            }
        }
        public static void UserContinue()

        {
            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n)");
                string userSelection = Console.ReadLine().ToLower();
                userContinue = false;

                switch (userSelection)
                {
                    case "y":
                        DisplayMenu();
                        break;
                    case "n":
                        Console.WriteLine("Cya later alligator! ");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection (y or n).");
                        userContinue = true;
                        break;
                }
            }
        }
        public static string GetCheckout(string checkoutResponse)
        {

            if (checkoutResponse == "1")
            {
                return "The Hobbit";

            }
            else if (checkoutResponse == "2")
            {
                return "The Fellowship of The Ring";
            }
            else if (checkoutResponse == "3")
            {
                return "The Stand";
            }
            else if (checkoutResponse == "4")
            {
                return "The Handmaid's Tale";
            }
            else if (checkoutResponse == "5")
            {
                return "The Testaments";
            }
            else if (checkoutResponse == "6")
            {
                return "The Road";
            }
            else if (checkoutResponse == "7")
            {
                return "Cujo";
            }
            else if (checkoutResponse == "8")
            {
                return "The Sum of All Fears";
            }
            else if (checkoutResponse == "9")
            {
                return "The Hunger Games";
            }
            else if (checkoutResponse == "10")
            {
                return "Harry Potter and the Goblet of Fire";
            }
            else if (checkoutResponse == "11")
            {
                return "War of the Worlds";
            }
            else if (checkoutResponse == "12")
            {
                return "Brave New World";
            }
            else
            {
                Console.WriteLine("Invalid selection! ");
                checkoutResponse = GetUserInput("Please select a book to checkout!: ");

                return GetAuthor(checkoutResponse); 
            }
        }
    }
}
