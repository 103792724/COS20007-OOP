using System;

namespace LibraryTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Library library = new Library("St Saint Station Library");
            Book book1 = new Book("Refactoring", "Martin Fowler", "0201485672");
            Book book2 = new Book("Harry Potter", "J.K Rowling", "9780747532743");
            Game game1 = new Game("Fifa 22", "Electronic Arts", "E");
            Game game2 = new Game("EldenRing", "FromSofware", "PG16");

            library.AddResource(book1);
            library.AddResource(book2);
            library.AddResource(game1);
            library.AddResource(game2);

            book1.OnLoan = true;
            game1.OnLoan = true;

            Console.WriteLine("Fifa 22 is on loan. Should return false.");
            Console.WriteLine(library.HasResource("Fifa 22"));
            Console.WriteLine("Refactoring is not on loan. Should return true");
            Console.WriteLine(library.HasResource("Refactoring"));
            Console.WriteLine("Doesn't exist: Epic");
            Console.WriteLine(library.HasResource("Epic"));

            Console.WriteLine("The danger of pass by reference: Fifa 22 no longer on loan?");
            game1.OnLoan = false;
            Console.WriteLine(library.HasResource("Fifa 22"));


        }
    }
}
