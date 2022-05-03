using System;
using System.Collections.Generic;
using System.Text;
namespace VendingMachine
{
    internal interface IVending
    {
            void Purchase();
            void ShowAll();
            void InsertMoney();
            void EndTransaction();
    }
}
