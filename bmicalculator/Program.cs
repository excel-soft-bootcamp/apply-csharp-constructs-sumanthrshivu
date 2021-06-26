using System;

namespace BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMyBmi bmi = new TestMyBmi();

            Console.Write("Weight in kg: ");
            bmi.Weight_Kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in meters: ");
            bmi.Height_M = Convert.ToDouble(Console.ReadLine());


            bmi.CalculateBmi();
            bmi.ValidateBmi();
        }
    }
}
