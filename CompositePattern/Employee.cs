using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Employee
    {
        public abstract void print(string whitespace);

        public abstract int Count();

        public Employee(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }

        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
