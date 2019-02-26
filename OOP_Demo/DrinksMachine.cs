using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    public class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        // private member variables
        // private int age;
        // private string make;

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _make;

        public string Make
        {
            get { return _make;  }
            set { _make = value; }
        }
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        
        

        public int Age { get; set; }
        // Default constructor
        // Takes no parameters
        /*
        public DrinksMachine()
        {
            Age = 0;
        }
        */

        // public properties
        /*
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        */

        /*
        public string Make
        {
            // get property accessor
            // Returns the property value
            get
            {
                return make;
            }
            // set property accessor
            // Assigns a new value to property
            set
            {
                // value being assigned by set
                make = value; 
            }          
        }
        */

        // auto-implemented property
        // Makes property declaration more concise
        /*
        public string Model { get; set; }
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }
        */
        // Constructors
        /*
        public DrinksMachine(int age)
        {
            this.Age = age;
        }
        
        
        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
        */
    

        // Public methods
        public void MakeCappuccino()
        {
            // Method logic 
            Console.WriteLine("Your cappuccino is ready.");

        }

        public void MakeEspresso()
        {
            // Method logic goes here.
        }

        // The following statement defines an event. The delegate definition is not shown.
        // public event OutOfBeansHandler OutOfBeans;
    }
}
