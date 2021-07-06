using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculationLibApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadFromConsoleLib.ReadFromConsoleLibType _consoleReaderType = new ReadFromConsoleLib.ReadFromConsoleLibType();
            double height_Meters = _consoleReaderType.ConsoleReader("enter your height");
            double weight_Kilograms = _consoleReaderType.ConsoleReader("enter your weight");

            CalculateBmiLib.CalculateBmiType _calculateBmiType = new CalculateBmiLib.CalculateBmiType();
            double BMI_Cal = _calculateBmiType.Bmicalculator(height_Meters, weight_Kilograms);

            ValidateBmiLib.ValidateBmiType _validateBmi = new ValidateBmiLib.ValidateBmiType();
           string message = _validateBmi.Check_BmiValue(BMI_Cal);

            ConsoleDisplayLib.ConsoleDisplayType _consoleDisplayMessage = new ConsoleDisplayLib.ConsoleDisplayType();
            _consoleDisplayMessage.DisplayMessage(message);
        }
    }
}
