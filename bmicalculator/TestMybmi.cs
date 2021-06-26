using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculator
{
     public class TestMyBmi
    {
        private int weight;
        private double height;
        private double bmi;//body mass index 

        public int Weight_Kg // kilogram
        {
            set { this.weight = value; }
            get { return this.weight; }
        }

        public double Height_M // meters
        {
            set { this.height = value; }
            get { return this.height; }
        }

        public double Bmi_Calc
        {
            set { this.bmi = value; }
            get { return this.bmi; }
        }
        public void CalculateBmi() //body mass index calculation
        {

            Bmi_Calc = Weight_Kg / Height_M * 2;
        }
        public void ValidateBmi()
        {
            if (Bmi_Calc < 18.5) 
            { this.ReadFromConsole("Underweight"); }

            if ( Bmi_Calc >= 19 & Bmi_Calc <= 24)
            { this.ReadFromConsole("Healthy"); }

            if ( Bmi_Calc >= 25)
            { this.ReadFromConsole("Overweight"); }

        }
        private string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
