// See https://aka.ms/new-console-template for more information
using Constructors;

//Console.WriteLine("Hello, World!");

namespace Practice {
    class Constructors { 
        static void Main(string[] args)
        {
            Books book1 = new Books("Harry Potter and the Philosopher's Stone", "J. K. Rowling", 1997, 223);
            Books book2 = new Books("The Lord of the Rings", "J. R. R. Tolkien", 1954, 423);
            Books book3 = new Books("The Forty Rules of Love", "Elif Shafak", 2009, 354);

            Console.WriteLine(book3.title);
            Console.ReadLine();
        }
    }
}