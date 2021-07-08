using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromConsoleLib
{
    public class ReadFromConsoleType
    {
        public double ConsoleReader(string message)
        {
            Console.WriteLine(message);
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }
    }
}
