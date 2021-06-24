using System;
using System.Collections.Generic;
using System.Text;

namespace bmicalculator
{
    class TestMyBmi
    {
        private int Weight;
        private double Height;
        private double bmi;//body mass index 

        public int Weight_Kg // kilogram
        {
            set { this.Weight = value; }
            get { return this.Weight; }
        }

        public double Height_M // meters
        {
            set { this.Height = value; }
            get { return this.Height; }
        }

        public double Bmi_Calc
        {
            set { this.bmi = value; }
            get { return this.bmi; }
        }
        public void CalculateBmi() //body mass index calculation
        {
            Console.Write("Weight in kg: ");
            Weight_Kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height in m: ");
            Height_M = Convert.ToDouble(Console.ReadLine());

            Bmi_Calc =  Weight_Kg / Height_M * 2;

            if ( Bmi_Calc < 18.5)
            { Console.WriteLine("-> Underweight"); }

            if ( Bmi_Calc >= 19 & Bmi_Calc <= 24)
            { Console.WriteLine("-> healthy"); }

            if ( Bmi_Calc >= 25)
            { Console.WriteLine("-> Overweight"); }

        }
    }
}
