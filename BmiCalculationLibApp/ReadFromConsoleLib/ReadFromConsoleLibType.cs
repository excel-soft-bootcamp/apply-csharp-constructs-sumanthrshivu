using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromConsoleLib
{
    public class ReadFromConsoleLibType
    {
        public double ConsoleReader(string message)
        {   
            double value = Convert.ToDouble(Console.ReadLine());
            return value;
        }

    }
}
