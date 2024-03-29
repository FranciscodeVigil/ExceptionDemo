﻿using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter num1:");
                    string num1str = Console.ReadLine();
                    int num1 = int.Parse(num1str);

                    Console.Write("Please enter num2:");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
                }
                catch(System.FormatException exc)
                {
                    Console.WriteLine("Not a number!:");
                }
                catch(System.OverflowException exc)
                {
                    Console.WriteLine("Number is too large or small!");
                }
                catch (System.DivideByZeroException exc)
                {
                    Console.WriteLine("You are dividing by 0 STOP THAT!");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
                }
                finally
                {
                    Console.WriteLine("This section always executes!");
                }
                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");
        }
    }
}
