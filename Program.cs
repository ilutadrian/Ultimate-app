using System;

namespace Ultimate_app
{

    // App struct  
    public struct App
    {
        public string Title;
        public string Author;
        public decimal Price;
        public short Year;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New App");
            // Create a Book object  
            App myApp = new App();
            myBook.Title = "Simple App";
            myBook.Author = "Adrian Ilut";
            myBook.Price = 45.95M;
            myBook.Year = 2021;

            Console.WriteLine($"App {myApp.Title} was written by {myApp.Author}" +
               $" in {myApp.Year}. Price is {myApp.Price}");

            Console.ReadKey();
        }
    }
}
