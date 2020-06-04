using System;
using System.Collections.Generic;

namespace AufgabeSupermarkt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Dictionary<string, int> Cart = new Dictionary<string, int>();
            do
            {
                Console.WriteLine("\n1) Produkte zum Warenkorb hinzufügen");
                Console.WriteLine("2) Produkte vom Warenkorb entfernen");
                Console.WriteLine("3) Warenkorb anzeigen");
                Console.WriteLine("4) exit \n");
                string UserTask = Console.ReadLine();

                switch (UserTask)
                {
                    case "1":
                        Console.WriteLine("Produkt eingeben");
                        string Product = Console.ReadLine();
                        Console.WriteLine("Anzahl eingeben");
                        int Amount = Int32.Parse(Console.ReadLine());
                        int StoredValueAdd;
                        if (Cart.TryGetValue(Product, out StoredValueAdd))
                        {
                            Cart[Product] = StoredValueAdd + Amount;
                        }
                        else
                        {
                            Cart.Add(Product, Amount);
                        }              
                        break;

                    case "2":
                        Console.WriteLine("zu entfernendes Produkt eingeben");
                        string ProductRemove = Console.ReadLine();
                        Console.WriteLine("zu entfernende Anzahl eingeben");
                        int AmountRemove = Int32.Parse(Console.ReadLine());
                        int StoredValue;
                        if (Cart.TryGetValue(ProductRemove, out StoredValue))
                        {
                            Cart[ProductRemove] = StoredValue - AmountRemove;
                        }
                        else
                        {
                            Console.WriteLine("Produkt nicht gefunden");
                        }            
                        break;
                    case "3":
                        Console.WriteLine("Warenkorb");
                        foreach (var pair in Cart)
                        {
                            Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
                        }
                        break;

                    case "4":
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
