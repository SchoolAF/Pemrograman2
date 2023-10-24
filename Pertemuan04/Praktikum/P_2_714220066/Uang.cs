using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220066
{
    public class Uang
    {
        // Field
        private string name;

        // Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor
        public Uang(string name)
        {
            this.name = name;
        }

        // Method
        public virtual void Cashier()
        {
            Console.WriteLine($"Berbagai jenis {name} di Indonesia.");
        }
    }

}
