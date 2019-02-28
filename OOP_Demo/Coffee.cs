using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    class Coffee : IBeverage, IInventoryItem
    {
        private int servingTempWithoutMilk { get; set; }
        private int servingTempWithMilk { get; set; }
        public int IBeverage.GetServingTemperature(bool includesMilk)
        {
            if(includesMilk)
            {
                return servingTempWithMilk;
            }
            else
            {
                return servingTempWithoutMilk;
            }
        }
        public bool IBeverage.IsFairTrade { get; set; }
    }
}
