using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BmiCalculationLibApp
{
    public enum Options
    {
        ConsoleInput = 1, FileInput
            
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int count = 3;
            do
            {
                //Options _choice = default(Options);
                string displayMsg = $"Enter Your Choice {(int)Options.ConsoleInput}->ConsoleInput,{(int)Options.FileInput}-->FileInput";
                ConsoleDisplayLib.ConsoleDisplayType.DisplayMessage(displayMsg);
                
            try
            {
                    Options _choice = (Options)Convert.ToInt32(ConsoleDisplayLib.ConsoleDisplayType.ReadFromConsole());

                    if (_choice < (Options)1 || _choice > (Options)2)
                {
                    Console.WriteLine("invalid options");
                }
                else
                {
                        switch (_choice)
                        {
                            case Options.ConsoleInput:
                                UserInputLib.UserInputType.UserInput();
                                Console.ReadKey();
                                break;

                            case Options.FileInput:
                                try
                                {
                                    UserInputLib.UserInputType.CsvInputToBmiCalculator();
                                }

                                catch (FileNotFoundException e)
                                {
                                    Console.WriteLine("Could Not Find File" + e);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Please provide valid type" + ex);
                                }
                                Console.ReadKey();
                                break;

                        }
                        break;
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("choosed options must be number");
            }
            --count;
        } while (count > 0);
            
        }
    }
}
