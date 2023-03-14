using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the Console PhoneBook app");
            Console.WriteLine("Select operation");
            Console.WriteLine("1-Add contact");
            Console.WriteLine("2-Display contact by number ");
            Console.WriteLine("3-View all contacts");
            Console.WriteLine("4-Search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact number to search:");
                        var SearchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(SearchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContanct();
                        break;
                    case "4":
                        Console.WriteLine("Name search pharse");
                        var searchPharse = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPharse);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;

                }
                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();

            }

            Console.ReadLine();
        }
    }
}
