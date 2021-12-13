using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISIS.OOAD.COMMON
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new Machine();
            Console.WriteLine(machine.Foods.Count());

            Console.Read();
        }
    }
}
