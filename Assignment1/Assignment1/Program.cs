using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your weight? \n");
            double weight = Convert.ToInt32(Console.ReadLine());
            if (weight <= -1)
            {
                Console.Write("Are you kidding me?\n");
                Console.Write("What is your weight? \n");
                weight = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("What is your height? Feet:\n");
            int height_feet = Convert.ToInt32(Console.ReadLine());
            if (weight <= -1)
            {
                Console.Write("Are you kidding me?\n");
                Console.Write("Feet:\n");
                height_feet = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Inches:\n");
            int height_inches = Convert.ToInt32(Console.ReadLine());
            if (weight <= -1)
            {
                Console.Write("Are you kidding me?\n");
                Console.Write("Inches:\n");
                height_feet = Convert.ToInt32(Console.ReadLine());
            }
            int height = height_feet * 12 + height_inches;
            int BMIVALUE = 703;
            double bmi = (weight * BMIVALUE) / (height * height);
            string str = "";
            str = Convert.ToDouble(bmi).ToString("0.00");
            Console.Write("Your current BMI is:");
            Console.WriteLine(str);
        }
    }
}
