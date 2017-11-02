using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment5
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Write("Welcome to CS110 BANK\n");
            Console.Write("What is your bank id?");
            string A_id = Console.ReadLine();
            Console.Write("Initial deposit into Checking:");
            double A_checking = Convert.ToDouble(Console.ReadLine());
            Console.Write("Initial deposit into Saving:");
            double A_saving = Convert.ToDouble(Console.ReadLine());
            BankAccount A=new BankAccount(A_id,A_checking,A_saving);
            Console.Write("Command Options\n");
            Console.Write("-----------------\n");
            Console.Write("a: deposit\n");
            Console.Write("b: withdraw\n");
            Console.Write("c: display the balance\n");
            Console.Write("d: Check the account\n");
            Console.Write("q: quit this program\n");
            while (true)
            {
                Console.Write("Please enter a command or type ?\n");
                char ch = char.Parse(System.Console.ReadLine());
                switch (ch)
                {
                    case 'a':
                        Console.Write("Amount to deposit: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        A.deposit(a);
                        Console.WriteLine("You deposited ${0:N2} to Checking.",a);
                        break;
                    case 'b':
                        Console.Write("Amount to withdraw: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        if (!A.withdraw(b))
                        {
                            Console.WriteLine("Invalid choice (not sufficient fund)");
                        }
                        else 
                        { 
                            Console.WriteLine("You withdrew {0:N2}.", b); 
                        }
                        break;
                    case 'c': Console.WriteLine(A.toString()); break;
                    case 'd':
                        Console.Write("What is your bank id?\n ");
                        string i = Console.ReadLine();
                        if (A.equals(i))
                        {
                            Console.WriteLine(A.toString());
                        }
                        else
                        {
                            Console.WriteLine("Wrong ID!");
                        } break;
                    case 'q':
                        A.addInterest();
                        Console.WriteLine(A.toString());
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Please enter a right command"); break;
                }
            }
            
            
            
        }
    }
    
        
}
