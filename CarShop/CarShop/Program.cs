using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store s = new Store();

            Console.WriteLine("Welcome to the car store .First you must create some car inventory.\nThen you may add some cars to the shopping cart.\nFinally you may checkout which will give you a total value of the shopping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("Your chose " + action);

                switch (action)
                {   //add item to inventory
                    case 1:
                        Console.WriteLine("you choose to add a new car to the inventory");
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;

                        Console.WriteLine("What is the car make? ford,gm,nissan etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? corvette,focus,ranger etc.");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What is the car price?");
                        carPrice = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carMake, carModel, carPrice);

                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;
                    //add to cart
                    case 2:
                        Console.WriteLine("You choose to add a car to you shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy?(number)");
                        int carChosen = int.Parse(Console.ReadLine());

                        s.ShopingList.Add(s.CarList[carChosen]);

                        printShoppingCart(s);

                        break;

                    //checkout
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your itmes is: " + s.Checkout());



                        break;


                    default:
                        break;

                }

                action = chooseAction();


            }

            Console.ReadLine();
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have chosen yo buy");
            for (int i = 0; i < s.ShopingList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " + s.ShopingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " + s.CarList[i]);
            }
        }

        public static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add new inventory (2)  add car to cart (3)");
            choice = int.Parse(Console.ReadLine());

            return choice;
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing yet";
            Model = "nothing yet";
            Price = 0.00M;
        }

        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Make:" + Make + "-Model:" + Model + "-Prices: $" + Price;
        }




    }

    class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShopingList { get; set; }



        public Store()
        {
            CarList = new List<Car>();
            ShopingList = new List<Car>();
        }

        public decimal Checkout()
        {   //initialize the total cost
            decimal totalCost = 0M;

            foreach (var c in ShopingList)
            {
                totalCost += c.Price;
            }
            ShopingList.Clear();
            return totalCost;
        }


    }
}
