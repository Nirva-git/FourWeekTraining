using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    class Program
    {
        static List<Book> books = new List<Book>();
        static List<Author> authors = new List<Author>();
        static List<Borrower> borrowers = new List<Borrower>();
        static List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. Add Author");
                Console.WriteLine("5. Update Author");
                Console.WriteLine("6. Delete Author");
                Console.WriteLine("7. Add Borrower");
                Console.WriteLine("8. Update Borrower");
                Console.WriteLine("9. Delete Borrower");
                Console.WriteLine("10. Register Book to Borrower");
                Console.WriteLine("11. Display All Books");
                Console.WriteLine("12. Display All Authors");
                Console.WriteLine("13. Display All Borrowers");
                Console.WriteLine("14. Search Books");
                Console.WriteLine("15. Filter Books by Status");
                Console.WriteLine("16. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        UpdateBook();
                        break;
                    case "3":
                        DeleteBook();
                        break;
                    case "4":
                        AddAuthor();
                        break;
                    case "5":
                        UpdateAuthor();
                        break;
                    case "6":
                        DeleteAuthor();
                        break;
                    case "7":
                        AddBorrower();
                        break;
                    case "8":
                        UpdateBorrower();
                        break;
                    case "9":
                        DeleteBorrower();
                        break;
                    case "10":
                        RegisterBookToBorrower();
                        break;
                    case "11":
                        DisplayAllBooks();
                        break;
                    case "12":
                        DisplayAllAuthors();
                        break;
                    case "13":
                        DisplayAllBorrowers();
                        break;
                    case "14":
                        SearchBooks();
                        break;
                    case "15":
                        FilterBooksByStatus();
                        break;
                    case "16":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter book details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Publication Year: ");
            int publicationYear = int.Parse(Console.ReadLine());

            Book book = new Book(title, author, publicationYear);
            books.Add(book);

            Console.WriteLine("Book added successfully.");
        }

        static void UpdateBook()
        {
            Console.Write("Enter the title of the book to update: ");
            string title = Console.ReadLine();

            Book book = books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Author: ");
                string author = Console.ReadLine();
                Console.Write("Publication Year: ");
                int publicationYear = int.Parse(Console.ReadLine());

                book.Author = author;
                book.PublicationYear = publicationYear;

                Console.WriteLine("Book updated successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void DeleteBook()
        {
            Console.Write("Enter the title of the book to delete: ");
            string title = Console.ReadLine();

            Book book = books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void AddAuthor()
        {
            Console.WriteLine("Enter author details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Date of Birth: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Author author = new Author(firstName, lastName, dateOfBirth);
            authors.Add(author);

            Console.WriteLine("Author added successfully.");
        }

        static void UpdateAuthor()
        {
            Console.Write("Enter the first name of the author to update: ");
            string firstName = Console.ReadLine();

            Author author = authors.FirstOrDefault(a => a.FirstName == firstName);
            if (author != null)
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Date of Birth: ");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                author.LastName = lastName;
                author.DateOfBirth = dateOfBirth;

                Console.WriteLine("Author updated successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }

        static void DeleteAuthor()
        {
            Console.Write("Enter the first name of the author to delete: ");
            string firstName = Console.ReadLine();

            Author author = authors.FirstOrDefault(a => a.FirstName == firstName);
            if (author != null)
            {
                authors.Remove(author);
                Console.WriteLine("Author deleted successfully.");
            }
            else
            {
                Console.WriteLine("Author not found.");
            }
        }

        static void AddBorrower()
        {
            Console.WriteLine("Enter borrower details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Borrower borrower = new Borrower(firstName, lastName, email, phoneNumber);
            borrowers.Add(borrower);

            Console.WriteLine("Borrower added successfully.");
        }

        static void UpdateBorrower()
        {
            Console.Write("Enter the first name of the borrower to update: ");
            string firstName = Console.ReadLine();

            Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == firstName);
            if (borrower != null)
            {
                Console.WriteLine("Enter new details:");
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                borrower.LastName = lastName;
                borrower.Email = email;
                borrower.PhoneNumber = phoneNumber;

                Console.WriteLine("Borrower updated successfully.");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }

        static void DeleteBorrower()
        {
            Console.Write("Enter the first name of the borrower to delete: ");
            string firstName = Console.ReadLine();

            Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == firstName);
            if (borrower != null)
            {
                borrowers.Remove(borrower);
                Console.WriteLine("Borrower deleted successfully.");
            }
            else
            {
                Console.WriteLine("Borrower not found.");
            }
        }

        
        static void RegisterBookToBorrower()
        {
            Console.WriteLine("Enter book details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Borrower's First Name: ");
            string borrowerFirstName = Console.ReadLine();
            Console.Write("Borrower's Last Name: ");
            string borrowerLastName = Console.ReadLine();
            Console.Write("Due Date (YYYY-MM-DD): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Book book = books.FirstOrDefault(b => b.Title == title);
            Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName == borrowerFirstName && b.LastName == borrowerLastName);

            if (book != null && borrower != null)
            {
                if (book.IsAvailable)
                {
                    BorrowedBook borrowedBook = new BorrowedBook(book, borrower, DateTime.Now, dueDate);
                    borrowedBooks.Add(borrowedBook);
                    book.IsAvailable = false;

                    Console.WriteLine("Book registered to borrower successfully.");
                }
                else
                {
                    Console.WriteLine("Book is already borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Book or borrower not found.");
            }
        }

        static void DisplayAllBooks()
        {
            Console.WriteLine("All Books:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publication Year: {book.PublicationYear}, Status: {(book.IsAvailable ? "Available" : "Borrowed")}");
            }
        }

        static void DisplayAllAuthors()
        {
            Console.WriteLine("All Authors:");
            foreach (var author in authors)
            {
                Console.WriteLine($"Name: {author.FirstName} {author.LastName}, Date of Birth: {author.DateOfBirth}");
            }
        }

        static void DisplayAllBorrowers()
        {
            Console.WriteLine("All Borrowers:");
            foreach (var borrower in borrowers)
            {
                Console.WriteLine($"Name: {borrower.FirstName} {borrower.LastName}, Email: {borrower.Email}, Phone Number: {borrower.PhoneNumber}");
            }
        }

        static void SearchBooks()
        {
            Console.WriteLine("Enter search keyword: ");
            string keyword = Console.ReadLine();

            var results = books.Where(b => b.Title.Contains(keyword) || b.Author.Contains(keyword)).ToList();
            if (results.Count > 0)
            {
                Console.WriteLine("Search Results:");
                foreach (var book in results)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publication Year: {book.PublicationYear}, Status: {(book.IsAvailable ? "Available" : "Borrowed")}");
                }
            }
            else
            {
                Console.WriteLine("No books found matching the search criteria.");
            }
        }

        static void FilterBooksByStatus()
        {
            Console.WriteLine("Filter Books by Status");
            Console.WriteLine("1. Available Books");
            Console.WriteLine("2. Borrowed Books");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            bool isAvailable = choice == "1";

            var filteredBooks = books.Where(b => b.IsAvailable == isAvailable).ToList();
            if (filteredBooks.Count > 0)
            {
                Console.WriteLine($"Filtered Books ({(isAvailable ? "Available" : "Borrowed")})");
                foreach (var book in filteredBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publication Year: {book.PublicationYear}");
                }
            }
            else
            {
                Console.WriteLine("No books found with the selected status.");
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }

    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Author(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
    }

    class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Borrower(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }

    class BorrowedBook
    {
        public Book Book { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }

        public BorrowedBook(Book book, Borrower borrower, DateTime borrowDate, DateTime dueDate)
        {
            Book = book;
            Borrower = borrower;
            BorrowDate = borrowDate;
            DueDate = dueDate;
        }
    }
}
