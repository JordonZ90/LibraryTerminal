using System;
using System.Collections.Generic;

namespace LibraryTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book.Books[0].CheckOut(); // 
            //Console.WriteLine(Book.Books[0].DueDate);

            //Book.Books[0].CheckIn();
            //Console.WriteLine(Book.Books[0].DueDate);

            Console.WriteLine("This is a Super Duper Library! \n");

            DisplayMenu();


            while (true)
            {
                //DisplayMenu();

                switch (GetUserInput("Please Make a Selection from the Menu Above: \n"))
                {

                    case "1":
                        Console.WriteLine("Here is our selection of books! ");
                        DisplayBooks();
                        //string checkoutResponse = GetUserInput("Select what book you want to checkout \n");
                        //Console.WriteLine(GetCheckout(checkoutResponse));
                        UserContinue();
                        break;
                    case "2":
                        DisplayGenres();
                        string response = GetUserInput("Select a genre: ");
                        string selection = GetGenre(response);
                        DisplayBooksByGenre(selection);
                        UserContinue();
                        // display books by Genre
                        // Display books by Genre Method
                        break;
                    case "3":
                        SearchByAuthor();
                        string authorResponse = GetUserInput("Select an Author: ");
                        //string authorSelection = GetAuthor(authorResponse);
                        Console.WriteLine(GetAuthor(authorResponse));
                        UserContinue();
                        //Display books by Author
                        //Display books by Author Method
                        break;
                    case "4":
                        DisplayTitle();
                        UserContinue();
                        // Display books by Title
                        //Display books by Title Method
                        break;
                    case "5":
                        DisplayBooks();
                        string checkoutResponse2 = GetUserInput("Select what book you want to checkout \n");
                        //string checkoutSelection = Getcheckout(response);
                        Console.WriteLine(GetCheckout(checkoutResponse2));
                        //CheckOutStatus();
                        UserContinue();
                        //string checkingOut = GetUserInput("This will be checked out! ");
                        // display ALL books
                        // Call Display of All Books Method
                        break;
                    case "6":
                    case "exit":
                        //Getting kicked out!
                        Environment.Exit(0);
                        break;
                    default:
                        // Keep looping
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
            Console.WriteLine("[1]: Display All Books in the Super Duper Library");
            //Console.WriteLine("=================================================================");

            Console.WriteLine("[2]: Display Books by Genre from the Super Duper Library ");
           //Console.WriteLine("=================================================================");

            Console.WriteLine("[3]: Display Books by Author from the Super Duper Library ");
            //Console.WriteLine("=================================================================");

            Console.WriteLine("[4]: Display Books by Title in the Super Duper Library ");
            //Console.WriteLine("=================================================================");

            Console.WriteLine("[5]: Lets checkout some books at the Super Duper Library ");
            //Console.WriteLine("=================================================================");

            Console.WriteLine("[6]: Now leaving the Super Duper Library ");
           //Console.WriteLine("=================================================================");

        }
        public static void DisplayBooks()
        {
            int count = 1;
            foreach (Book book in Book.Books)
            {
                Console.WriteLine($"[{count}] Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");
                //Console.WriteLine("=================================================================");
                count++;

                if (book.Status == true)
                {
                    Console.WriteLine($" Status: on Shelf \n");
                    //Console.WriteLine("=================================================================");
                }
                else
                {
                    Console.WriteLine($"Status: checked out \n");
                    //Console.WriteLine("=================================================================");

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
                //Console.WriteLine("=================================================================");
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
                //Console.WriteLine("=================================================================");
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
                    //Console.WriteLine("=================================================================");
                    //Console.WriteLine(book.Genre);
                    //Console.WriteLine(book.Status);
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

                return GetGenre(response); // retuning the method within itself
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
                //Console.WriteLine("=================================================================");
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
                        Console.WriteLine("Cya later alligator!");
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

            if (checkoutResponse == "1")// || checkoutResponse == "The Hobbit")
            {
                return "The Hobbit";

            }
            else if (checkoutResponse == "2")// || checkoutResponse == "The Fellowship of The Ring")
            {
                return "The Fellowship of The Ring";
            }
            else if (checkoutResponse == "3")// || checkoutResponse == "The Stand")
            {
                return "The Stand";
            }
            else if (checkoutResponse == "4")// || checkoutResponse == "The Handmaid's Tale")
            {
                return "The Handmaid's Tale";
            }
            else if (checkoutResponse == "5")// || checkoutResponse == "The Testaments")
            {
                return "The Testaments";
            }
            else if (checkoutResponse == "6")// || checkoutResponse == "The Road")
            {
                return "The Road";
            }
            else if (checkoutResponse == "7")// || checkoutResponse == "Cujo")
            {
                return "Cujo";
            }
            else if (checkoutResponse == "8")// || checkoutResponse == "The Sum of All Fears")
            {
                return "The Sum of All Fears";
            }
            else if (checkoutResponse == "9")// || checkoutResponse == "The Huner Games")
            {
                return "The Hunger Games";
            }
            else if (checkoutResponse == "10")// || checkoutResponse == "Harry Potter and the Goblet of Fire")
            {
                return "Harry Potter and the Goblet of Fire";
            }
            else if (checkoutResponse == "11")// || checkoutResponse == "War of the Worlds")
            {
                return "War of the Worlds";
            }
            else if (checkoutResponse == "12")// || checkoutResponse == "Brave New World")
            {
                return "Brave New World";
            }
            else
            {
                Console.WriteLine("Invalid selection! ");
                checkoutResponse = GetUserInput("Please select a book to checkout!: "); //.ToLower();

                return GetAuthor(checkoutResponse); // retuning the method within itself
            }
        }
        //public static void CheckOutStatus(string checkingOut)
        //{
        //    //int count = 1;
        //    foreach (Book book in Book.Books)
        //        if (checkingOut == "Y")
        //        {
        //            Console.WriteLine(book.Status == true);
        //            Console.WriteLine("=================================================================");
        //        }
        //        else
        //        {
        //            Console.WriteLine(book.Status == false);
        //        }
        //}
        //public static void CheckOutBook()  'List<>
        //{
        //    
            
        //    
        //    Console.WriteLine("Here is our currently");
        //    int count = 1;
        //    foreach (Book book in Book.Books)
        //    {
        //        if (book.Status == true)
        //        {
        
        //            Console.WriteLine($"{count}: {book.Title}");
        //            Console.ResetColor();
        //            count++;
        //        }


        //    }
        //}
    }
}
