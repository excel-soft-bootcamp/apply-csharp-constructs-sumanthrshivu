using System;

namespace BmiCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMyBmi bmi = new TestMyBmi();

            ConsoleDisplay.WriteFromConsole("Enter the Weight in kilogram: ");
            bmi.Weight_Kg = Convert.ToInt32(ConsoleDisplay.ReadFromConsole());

            ConsoleDisplay.WriteFromConsole("Enter the Height in meters: ");
            bmi.Height_M = Convert.ToDouble(ConsoleDisplay.ReadFromConsole());

          
            BmiCalculator _calculator = new BmiCalculator();
            double Bmi_Calc = _calculator.CalculateBmi(bmi.Weight_Kg, bmi.Height_M);

            BmiValidator _bmiValidator = new BmiValidator();
            string message= _bmiValidator.ValidateBmi(Bmi_Calc);

            ConsoleDisplay.WriteFromConsole(message);

        }
    }
}