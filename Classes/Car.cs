using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        public Car() 
        {
            
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void Type()
        {
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(Year);
        }
    }
}
