using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714220066
{
    public class Kertas : Uang
    {
        // Field
        private string variety;

        // Property
        public string Variety
        {
            get { return variety; }
            set { variety = value; }
        }

        // Constructor
        public Kertas(string name, string variety) : base(name)
        {
            this.variety = variety;
        }

        // Method
        public override void Cashier()
        {
            Console.WriteLine($"ini adalah {Name} terdapat pecahan {variety}");
        }
    }
}
