using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("H.Muster", "Vertrieb", 001);
            m1.add(new Programmer("P.Lustig", 123));
            m1.add(new Programmer("P.Aasda", 343));
            m1.add(new Programmer("L.Fisadg", 14223));

            Manager m2 = new Manager("H.Muster", "Tech", 001);
            m2.add(new Programmer("P.Lustig", 123));
            m2.add(new Programmer("P.Aasda", 343));
            m2.add(new Programmer("L.Fisadg", 14223));

            Manager m3 = new Manager("H.Muster", "Dev", 001);
            m3.add(new Programmer("P.Lustig", 123));
            m3.add(new Programmer("P.Aasda", 343));
            m3.add(new Programmer("L.Fisadg", 14223));

            Manager boss = new Manager("B.Boss", "Boss", 00000);
            boss.add(m1);
            boss.add(new Programmer("F.Bossguy", 0001));
            boss.add(m2);

            boss.print("");
            Console.ReadLine();
        }
    }
}
