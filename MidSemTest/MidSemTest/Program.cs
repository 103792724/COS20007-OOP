using System;

namespace MidSemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Library _library = new Library("The point?");
            Game _fifa = new Game("Fifa 22", "Electronic Arts", "E");
            Game _eldenring = new Game("EldenRing", "FromSofware", "PG16");
            Book _harryPotter = new Book("Harry Potter", "J.K Rowling", "9780747532743");
            Book _refactoring = new Book("Refactoring", "Martin Fowler", "0201485672");


            _fifa.OnLoan = true;
            _harryPotter.OnLoan = true;

            _library.AddResource(_fifa);
            _library.AddResource(_eldenring);
            _library.AddResource(_harryPotter);
            _library.AddResource(_refactoring);

            Console.WriteLine("Fifa 22 is on loan. Should return false.");
            Console.WriteLine(_library.HasResource("Fifa 22"));
            Console.WriteLine("Refactoring is not on loan. Should return true");
            Console.WriteLine(_library.HasResource("Refactoring"));
            Console.WriteLine("Doesn't exist: Epic");
            Console.WriteLine(_library.HasResource("Epic"));

            Console.WriteLine("The danger of pass by reference: Fifa 22 no longer on loan?");
            _fifa.OnLoan = false;
            Console.WriteLine(_library.HasResource("Fifa 22"));

        }
    }
}