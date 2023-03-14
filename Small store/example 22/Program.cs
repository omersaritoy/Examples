using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();

            Console.ReadLine();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to store! Here are the items that you can buy:");
            Console.WriteLine("Book");
            Console.WriteLine("Shirt");
            Console.WriteLine("Computer");
            Console.WriteLine("What would you like to buy");
        }

        static void PurchaseItem()
        {
            var item = Console.ReadLine();

            switch (item)
            {
                case "Book":
                    var book = new Book();
                    book.Author = "JK Author";
                    book.Title = "The wizard of coding";
                    book.Price = 9.99;
                    Console.WriteLine($"You purchase a {book.Title} by {book.Author} for {book.Price}");
                    break;
                case "Shirt":
                    var shirt = new Shirt();
                    shirt.Size = "M";
                    shirt.Title = "Sports Shirt";
                    shirt.Price = 14.99;
                    Console.WriteLine($"You purchase a {shirt.Title} sized {shirt.Size} for {shirt.Price}");
                    break;
                case "Computer":
                    var computer = new Computer();
                    computer.Type = "PC";
                    computer.Title = "Surface Book Pro";
                    computer.Price = 1499.99;
                    Console.WriteLine($"You purchase a {computer.Title}{computer.Type} for {computer.Price}");
                    break;
                default:

                    break;
            }
        }
    }

    class BaseItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    class Book : BaseItem
    {
        public string Author { get; set; }
    }

    class Shirt : BaseItem
    {
        public string Size { get; set; }
    }

    class Computer : BaseItem
    {
        public string Type { get; set; }
    }
}
    