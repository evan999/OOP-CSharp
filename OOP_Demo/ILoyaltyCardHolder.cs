using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    interface ILoyaltyCardHolder
    {
        // read-only integer property
        int TotalPoints { get; }
        // Methods
        int AddPoints(decimal transactionValue);
        void ResetPoints();

    }
}
