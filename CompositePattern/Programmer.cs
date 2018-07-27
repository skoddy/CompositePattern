using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Programmer : Employee
    {
        public Programmer(string name, int phone) : base(name, phone)
        {
        }

        public override int Count()
        {
            return 1;
        }

        public override void print(string whitespace)
        {
            Console.WriteLine(whitespace + Name + " Phone: " + Phone);
        }
    }
}
