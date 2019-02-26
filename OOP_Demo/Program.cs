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
            
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            // myMachine.Location = "Kitchen";
            // myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();

            Console.WriteLine(Math.Pow(2, 8));


            // Keep window open until user presses any key to close
            Console.WriteLine("Press any key to close");
            Console.ReadLine();
        }
    }
}
