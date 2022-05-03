using System;
using System.Collections.Generic;
namespace VendingMachine
{
    public class VendingManager : IVending
    {
        private int[] _cashMoney = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public int wallet;
        List<Product> productList = new List<Product>()
        {
                new Soda("Coke", 1, 10),
                new Soda("Water", 2, 8),
                new Soda("Fanta", 3, 10),
                new Candy("Mars", 4, 15),
                new Candy("Snicker", 5, 15),
                new Candy("Kexchoklad", 6, 12),
                new Fruit("Banana",7,5),
                new Fruit("Apple", 8, 5),
                new Fruit("Orange", 9, 5)
        };
        public void Purchase()
        {
            string input;
            int pick;
            
            
            while (wallet > 0) 
            {
                Console.WriteLine($"Wallet:{wallet.ToString()} Enter pick: ");
                input = Console.ReadLine();
                pick = Convert.ToInt32(input);
                if (pick == 10)
                {
                    return;
                }
                else 
                {

                    var purchase = productList[pick - 1];
                    if (wallet >= purchase.Price && wallet > 0)
                    {
                        wallet = wallet - purchase.Price;
                        purchase.Examine();
                        purchase.Use();
                    }
                   else
                    Console.WriteLine("Not enough money in wallet!");
                }
            }
        }
        public void ShowAll()
        {
            int order = 0;
            foreach (var thing in productList)
            {
                order++;
                Console.Write($"{order.ToString()}:");
                thing.Examine();
            }
            Console.WriteLine($"10. Exit");
        }
        public void InsertMoney()
        {
            string choice;
            bool loop = true;
            Console.WriteLine("Add funds\n1.1 credit.\n2.5 credit.\n3.10 credit.\n4.20 credit.\n5.50 credit.\n6.100 credit.\n7.500 credit.\n8.1000 credit.\n");
            choice = Console.ReadLine();
            do
            {
                switch (choice)
                {
                    case "1":
                        wallet = wallet + _cashMoney[0];
                        Console.WriteLine($"{_cashMoney[0]} added to wallet!");
                        loop = false;
                        break;
                    case "2":
                        wallet = wallet + _cashMoney[1];
                        Console.WriteLine($"{_cashMoney[1]} added to wallet!");
                        loop = false;
                        break;
                    case "3":
                        wallet = wallet + _cashMoney[2];
                        Console.WriteLine($"{_cashMoney[2]} added to wallet!");
                        loop = false;
                        break;
                    case "4":
                        wallet = wallet + _cashMoney[3];
                        Console.WriteLine($"{_cashMoney[3]} added to wallet!");
                        loop = false;
                        break;
                    case "5":
                        wallet = wallet + _cashMoney[4];
                        Console.WriteLine($"{_cashMoney[4]} added to wallet!");
                        loop = false;
                        break;
                    case "6":
                        wallet = wallet + _cashMoney[5];
                        Console.WriteLine($"{_cashMoney[5]} added to wallet!");
                        loop = false;
                        break;
                    case "7":
                        wallet = wallet + _cashMoney[6];
                        Console.WriteLine($"{_cashMoney[6]} added to wallet!");
                        loop = false;
                        break;
                    case "8":
                        wallet = wallet + _cashMoney[7];
                        Console.WriteLine($"{_cashMoney[7]} added to wallet!");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        loop = false;
                        break;
                }
            } while (loop == true);
        }
        public void EndTransaction()
        {
            int tusen, femhundra, hundra, femtio, tjugo, tio, fem, en;
            
            tusen = wallet / _cashMoney[7];
            wallet = wallet - (tusen * _cashMoney[7]);
            femhundra = wallet / _cashMoney[6];
            wallet = wallet - (femhundra * _cashMoney[6]);
            hundra = wallet / _cashMoney[5];
            wallet = wallet - (hundra * _cashMoney[5]);
            femtio = wallet / _cashMoney[4];
            wallet = wallet - (femtio * _cashMoney[4]);
            tjugo = wallet / _cashMoney[3];
            wallet = wallet - (tjugo * _cashMoney[3]);
            tio = wallet / _cashMoney[2];
            wallet = wallet - (tio * _cashMoney[2]);
            fem = wallet / _cashMoney[1];
            wallet = wallet - (fem * _cashMoney[1]);
            en = wallet / _cashMoney[0];
            wallet = wallet - (en * _cashMoney[0]);

            var coinValuePairs = new Dictionary<string, int>(){
                {"Tusensedlar", tusen},
                {"Femhundrasedlar", femhundra},
                {"Hundrasedlar", hundra},
                {"Femtiosedlar", femtio },
                {"Tjugosedlar", tjugo },
                {"Tiokronor", tio },
                {"Femkronor", fem },
                {"Enkronor",en }
            };
            foreach(var cvp in coinValuePairs)
            {
                if(cvp.Value != 0)
                    Console.WriteLine("{0} {1}", cvp.Key, cvp.Value);
            }
        }
    }
}