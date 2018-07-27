using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Manager : Employee
    {
        List<Employee> employees = new List<Employee>();
        public string Department { get; set; }

        public Manager(string name, string department, int phone) : base(name, phone)
        {
            Department = department;
        }


        public override int Count()
        {
            int i = 1;
            foreach (Employee employee in employees)
            {
                i += employee.Count();
            }

            return i;
        }

        public override void print(string whitespace)
        {
            Console.WriteLine(whitespace + "Manager " + Name + " Department: " + Department + " Phone: " + Phone);
            foreach (Employee employee in employees)
            {
                employee.print(whitespace + "          ");
            }
        }

        public void add(Employee employee)
        {
            employees.Add(employee);
        }

        public void remove(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee GetEmployee(int index)
        {
            return employees[index];
        }
    }
}
