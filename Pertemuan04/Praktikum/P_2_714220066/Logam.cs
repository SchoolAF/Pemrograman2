using System;
using System.Collections.Generic;
//using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714220066
{
    public class Logam : Uang
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
        public Logam(string name, string variety) : base(name)
        {
            this.variety = variety;
        }

        public override void Cashier()
        {
            Console.WriteLine($"ini adalah {Name} terdapat pecahan {variety}");
        }
    }
}
