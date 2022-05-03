using System;
using System.Collections.Generic;
using System.Text;
namespace VendingMachine
{
    internal class Fruit : Product
    {
        public Fruit(string name, int productID, int price) : base(name, productID, price)
        {
        }
        public override void Use()
        {
            Console.WriteLine($"You eat the {Name}.");
        }
        public override void Examine()
        {
            Console.WriteLine($"{Name} costs {Price.ToString()} credits.");
        }
    }
}