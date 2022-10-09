using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class VendingMachineData : IVending
    {
        //money denominations defind as an array of ints readonly
        private static readonly int[] moneyDenomination = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        //the money pool that the user will put in amount of money 
        private int moneyPool;
        private int amount;
        // public Product[] Products = new Product[] { new Toy(), new Food(), new Drink() };
        List<Product> products = new List<Product>();

        //The propeties to money pool
        public int MoneyPool
        {
            get { return moneyPool; }
        }

        public int ProductId { get; private set; }
        public int NextId()
        {
            ProductId++;
            return ProductId;
        }

        public List<Product> ListsOfProduct()
        {
            products.Add(new Drink(NextId(), "Beer", 75, DrinksUnit.Beer));
            products.Add(new Drink(NextId(), "Soda", 25, DrinksUnit.Cola));
            products.Add(new Drink(NextId(), "Loka", 25, DrinksUnit.Water));
            products.Add(new Drink(NextId(), "Black Tower", 75, DrinksUnit.Wine));
            products.Add(new Drink(NextId(), "Spiruts", 75, DrinksUnit.Whiskey));
            products.Add(new Food(NextId(), "Food", 47, "Tacos", "Dinner"));
            products.Add(new Food(NextId(), "Food", 49, "Pizza", "Dinner"));
            products.Add(new Food(NextId(), "Snacks", 52, "Chips", "Snacks"));
            products.Add(new Toy(NextId(), "Lego", 119, "Create"));
            products.Add(new Toy(NextId(), "Ball", 39, "Children"));
            products.Add(new Toy(NextId(), "puzzle", 62, "For adult"));
            ShowAll();
            return products;
        }

        private void ShowAll()
        {
            foreach (Product product in products)
            {
                Console.WriteLine("\n" + product.Examine());
            }
            Console.WriteLine("Press any key to go to the menu");
        }
        //Purchase to buy products get list of info of product
        public Product? Purchase(int productId)
        {
            Product product = products[ProductId];
            if (moneyPool >= product.ProductPrice)
            {
                Console.Clear();
                Console.WriteLine("You have {0} kr\nPress enter to continue", moneyPool);
                Console.ReadLine();
                EndTransaction();
                return product;
            }
            else
            {
                Console.WriteLine("Sorry empty!");
                moneyPool = 0;
            }
            return null;
        }

        //details for selected product get string info from examine and use
        //the user will be picked a number of product (id) if they have money

        public void Details()
        {
            Console.WriteLine("Select nr of the product you want to add: ");
            int productNr = Int32.Parse(Console.ReadLine()) - 1;
            while (productNr < 0 || productNr > products.Count)
            {
                Console.WriteLine("Invalid number.");
                productNr = Int32.Parse(Console.ReadLine()) - 1;
            }
            Product product = products[productNr];
            ProductId = productNr;
            Console.WriteLine($"{product.Examine()} \n{product.Use()}");
            Console.WriteLine("\n1: Will you make a purchase \n2: Do you want to add more products \n3: Will you go back to the menu");
            string input = Console.ReadLine();
            if (input == "1")
            {
                InsertMoney();
            }
            if (input == "2")
            {
                Details();
            }
            if (input == "3")
            {
                RunVendingMachine();
            }
        }

        //Insertmoney = add money to pool
        public void InsertMoney()
        {
            Console.WriteLine($"What is your amount? ");
            amount = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (moneyDenomination.Contains(amount))
                {
                    moneyPool += amount;
                }
                else
                {
                    Console.WriteLine("Your balance {0}\n Choose option:\n1 -Add money\n2 -Get product", moneyPool);
                    Console.WriteLine("Wrong plizz try again");
                    InsertMoney();
                    return;
                }
                Console.WriteLine("Your balance {0}\n Choose option:\n1 -Add money\n2 -Get product", moneyPool);
                string? input = Console.ReadLine();
                if (input == "1")
                {
                    InsertMoney();
                }
                else if(input == "2")
                {
                    Purchase(ProductId);
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Your money are not");
            }          
        }

        //return money left in appropriate amount of change
        public Dictionary<int, int> EndTransaction()
        {
            //first the key and then the value, genric collections
            Dictionary<int, int> result = new Dictionary<int, int>();
            int moneyback;
            moneyback = moneyPool - products[ProductId].ProductPrice;
            Console.WriteLine($"You will have " + moneyback.ToString() + " kr back. \nPress any key to go back to the menu.");
            moneyPool = 0;
            foreach (int money in moneyDenomination)
            {
                if (moneyPool < money)
                {
                    continue;
                }
                try
                {
                    result.Add(money, moneyback / money);
                    moneyback %= money;

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

            }
            return result;
        }

        public void RunVendingMachine()
        {
            ListsOfProduct();
            bool run = true;
            while (run)
            {
                try
                {
                    Console.Clear();
                    WelcomesMenu();
                    string? user = Console.ReadLine();

                    switch (user)
                    {
                        case "1":
                            Console.Clear();
                            ShowAll();
                            break;
                        case "2":
                            Console.Clear();
                            Details();
                            break;
                        case "9":
                            Console.WriteLine("Now you quit, Thanks and welcome back!");
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choise Plizz re-enter your selection");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Not working");
                }
            }
        }
        public static void WelcomesMenu()
        {
            Console.WriteLine("\n----Vending machine----\n");
            Console.Write("\nChoose what options you like to do: \n");
            Console.WriteLine("\n1 - Show what product it´s inside.");
            Console.WriteLine("\n2 - Add a product you want..");
            Console.WriteLine("\n9 - Quit.");
        }
    }
}
