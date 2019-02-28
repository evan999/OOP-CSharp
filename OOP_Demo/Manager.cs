using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    // Base class Manager
    // Employee inherits from base class Manager
    class Manager : Employee
    {
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }

        private string department;
        private char payRateIndicator;
        private Employee[] emps;

        public string Department
        {
            get { return department;  }
            set { department = value; }
        }



    }
}
