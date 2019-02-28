using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    interface IBeverage
    {
        int GetServingTemperature(bool includesMilk);
        bool IsFairTrade { get; set; }
        event EventHandler OnSoldOut;
        string this[int index] { get; set; }
    }
}
