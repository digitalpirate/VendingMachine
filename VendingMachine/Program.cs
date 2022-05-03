using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            VendingManager vm = new VendingManager();
            vm.InsertMoney();
            vm.ShowAll();
            vm.Purchase();
            vm.EndTransaction();
        }
    }
}
