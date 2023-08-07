using System;
using System.Linq;
using System.Xml.Linq;

namespace Day4Exe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>Book Title 1</Title>
                                        <Author>Author 1</Author>
                                        <Genre>Genre 1</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 2</Title>
                                        <Author>Author 2</Author>
                                        <Genre>Genre 2</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Book Title 3</Title>
                                        <Author>Author 3</Author>
                                        <Genre>Genre 3</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML string
            XDocument bookCollection = XDocument.Parse(xmlString);

            // Write the title of all books to the console
            Console.WriteLine("All Books:");
            var allBooks = bookCollection.Descendants("Book");
            foreach (var book in allBooks)
            {
                Console.WriteLine("Title: " + book.Element("Title").Value);
            }
            Console.WriteLine();

            // Write the title of all books with genre "Genre 1" to the console
            string desiredGenre = "Genre 1";
            var booksWithGenre = bookCollection.Descendants("Book")
                .Where(b => (string)b.Element("Genre") == desiredGenre);

            Console.WriteLine("Books with Genre '{0}':", desiredGenre);
            foreach (var book in booksWithGenre)
            {
                Console.WriteLine("Title: " + book.Element("Title").Value);
            }
            Console.ReadLine();

            // Modify the document by updating existing book information
            string bookToUpdate = "Book Title 3";
            var bookElement = bookCollection.Descendants("Book")
                .FirstOrDefault(b => (string)b.Element("Title") == bookToUpdate);

            if (bookElement != null)
            {
                bookElement.Element("Author").Value = "Author 3 (Updated)";
            }
            // Print the updated book information
            Console.WriteLine();
            Console.WriteLine("Updated book information:");
            foreach (var book in bookCollection.Descendants("Book"))
            {
                Console.WriteLine("Title: {0}, Author: {1}",
                    book.Element("Title").Value, book.Element("Author").Value);
            }
            Console.ReadLine();
        }
    }
}
