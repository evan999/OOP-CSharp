using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Employee newEmp = new Employee();
            // newEmp.Login();
            // Representing an Object as an Interface Type
            Coffee coffee1 = new Coffee();
            IBeverage coffee2 = new Coffee();

            // Implicit cast to an interface type
            IBeverage beverage = coffee1;

            // Explicit cast
            // Casting an Interface Type to a Derived Class Type
            Coffee coffee3 = (Coffee)beverage;
            // OR
            Coffee coffee4 = beverage as Coffee;

            Manager myManager = new Manager();
            myManager.Login();
            // myManager.Hire();
            // myManager.Department

            #region Anon Class

            var anon = new { Name = "Gerry", Age = 29 };

            Console.WriteLine(anon.Name + anon.Age);

            #endregion

            /*   
               DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
               // myMachine.Location = "Kitchen";
               // myMachine.Model = "DM1000";

               Console.WriteLine(myMachine.Location);
               Console.WriteLine(myMachine.Make);
               Console.WriteLine(myMachine.Model);
               myMachine.MakeCappuccino();

               Console.WriteLine(Math.Pow(2, 8));
           */

            // Keep window open until user presses any key to close
            Console.WriteLine("Press any key to close");
            Console.ReadLine();

            // Explicitly invoking the Dispose method
            // var word = new ManagedWord();
            // word.Dispose();

            var word = default(ManagedWord);
            try
            {
                word = new ManagedWord();
            }
            catch
            {
                // Code to handle errors
            }
            finally
            {
                if (word != null)
                {
                    word.Dispose();
                }
            }

            // Implicitly invoke Dispose
            using (var word = default(ManagedWord))
            {

            }
        }
    }
}
