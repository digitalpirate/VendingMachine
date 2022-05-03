using System;
using System.Collections.Generic;
using System.Text;
namespace VendingMachine
{
    abstract internal class Product
    {
        public Product(string name, int productID, int price)
        {
            this.Name = name;
            this.ProductID = productID;
            this.Price = price;
        }
        public string Name { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        abstract public void Examine();
        abstract public void Use();
    }
}