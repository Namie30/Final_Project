using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
}

public class BookManager
{
    private List<Book> books;

    public BookManager()
    {
        books = new List<Book>();
        PrepopulateBooks(); 
    }

    private void PrepopulateBooks()
    {
        //book titles, authors, and publication years
        string[] titles = {
            "To Kill a Mockingbird",
            "1984",
            "The Great Gatsby",
            "Pride and Prejudice",
            "The Catcher in the Rye",
            "The Hobbit",
            "Brave New World",
            "The Lord of the Rings",
            "Animal Farm",
            "The Grapes of Wrath",
            "Moby-Dick",
            "The Adventures of Huckleberry Finn",
            "The Chronicles of Narnia",
            "Frankenstein",
            "The Picture of Dorian Gray",
            "Wuthering Heights",
            "Alice's Adventures in Wonderland",
            "Dracula",
            "Jane Eyre",
            "Treasure Island"
        };

        string[] authors = {
            "Harper Lee",
            "George Orwell",
            "F. Scott Fitzgerald",
            "Jane Austen",
            "J.D. Salinger",
            "J.R.R. Tolkien",
            "Aldous Huxley",
            "J.R.R. Tolkien",
            "George Orwell",
            "John Steinbeck",
            "Herman Melville",
            "Mark Twain",
            "C.S. Lewis",
            "Mary Shelley",
            "Oscar Wilde",
            "Emily Brontë",
            "Lewis Carroll",
            "Bram Stoker",
            "Charlotte Brontë",
            "Robert Louis Stevenson"
        };

        int[] publicationYears = {
            1960, 1949, 1925, 1813, 1951, 1937, 1932, 1954, 1945, 1939,
            1851, 1884, 1950, 1818, 1890, 1847, 1865, 1897, 1847, 1883
        };

        // listshi am yvelafris chamateba
        for (int i = 0; i < titles.Length; i++)
        {
            AddBook(titles[i], authors[i], publicationYears[i]);
        }
    }

    public void AddBook(string title, string author, int publicationYear)
    {
        Book book = new Book
        {
            Title = title,
            Author = author,
            PublicationYear = publicationYear
        };

        books.Add(book);
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("List of All Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}");
        }
    }

    public void SearchByTitle(string title)
    {
        List<Book> foundBooks = new List<Book>();

        foreach (var book in books)
        {
            if (book.Title.ToLower().Contains(title.ToLower()))
            {
                foundBooks.Add(book);
            }
        }

        if (foundBooks.Count == 0)
        {
            Console.WriteLine("No books found with that title.");
        }
        else
        {
            Console.WriteLine($"Found {foundBooks.Count} book(s) with title '{title}':");
            foreach (var book in foundBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookManager manager = new BookManager();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Add a new book");
            Console.WriteLine("2. View all books");
            Console.WriteLine("3. Search for a book by title");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter publication year: ");
                    int year = int.Parse(Console.ReadLine());

                    manager.AddBook(title, author, year);
                    break;
                case "2":
                    manager.ShowAllBooks();
                    break;
                case "3":
                    Console.Write("Enter title to search: ");
                    string searchTitle = Console.ReadLine();
                    manager.SearchByTitle(searchTitle);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
