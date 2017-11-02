using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag=0;
            Console.Write("Please input the first name:");
            string first = Console.ReadLine();
            
            if (Char.IsNumber(first[0])) 
            {
                Console.Write("Error: The first name was not accepted.\n");
                flag=1;
            }
            else
            {
                Console.Write(first);
                Console.Write(" is the first name.\n");
            }
            Console.Write("Please input the second name:");
            string second = Console.ReadLine();
            
            if (Char.IsNumber(second[0]))
            {
                Console.Write("Error: The second name was not accepted.\n");
                
                if(flag==1)
                {
                    flag=3;
                }
                flag=2;
            }
            else
            {
                Console.Write(second);
                Console.Write(" is the second name.\n");
            }
            Console.Write("Please input the third name:");
            string third = Console.ReadLine();
            
            if (Char.IsNumber(third[0]))
            {
                Console.Write("Error: The third name was not accepted.\n");
                
                if(flag==1)
                    flag=4;
                if(flag==2)
                    flag=5;
                if(flag==3)
                    flag=6;
                flag = 3;
            }
            else
            {
                Console.Write(third);
                Console.Write(" is the third name.\n");
            }
            Console.Write("The names in alphabetical order are\n");
            switch (flag)
            {
                case 0: if(second.CompareTo(third)<=0)
            {
                if (first.CompareTo(second) > 0)
                {
                    if (first.CompareTo(third) > 0)
                    {
                        Console.WriteLine(second);
                        Console.WriteLine(third);
                        Console.WriteLine(first);
                    }
                    else
                    {
                        Console.WriteLine(second);
                        Console.WriteLine(first);
                        Console.WriteLine(third);
                        
                    }
                }
                else
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                    Console.WriteLine(third);
                }
            }
            if (second.CompareTo(third) > 0)
            {
                if (first.CompareTo(second) > 0)
                {
                    if (first.CompareTo(third) > 0)
                    {
                        
                        Console.WriteLine(third);
                        Console.WriteLine(second);
                        Console.WriteLine(first);
                    }
                    else
                    {
                        Console.WriteLine(third);
                        Console.WriteLine(first);
                        Console.WriteLine(second);
                    }
                }
                else
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                    Console.WriteLine(second);
                }
            }
                    break;
                case 1:
                    if (second.CompareTo(third) <= 0)
                    {
                        Console.WriteLine(second);
                        Console.WriteLine(third);
                    }
                    else
                    {
                        Console.WriteLine(third);
                        Console.WriteLine(second);
                    }break;
                case 2:
                    if (first.CompareTo(third) <= 0)
                    {
                        Console.WriteLine(first);
                        Console.WriteLine(third);
                    }
                    else
                    {
                        Console.WriteLine(third);
                        Console.WriteLine(first);
                    }break;
                case 3:Console.WriteLine(third);break;
                case 4:Console.WriteLine(second); break;
                case 5:Console.WriteLine(first); break;
                case 6: break;

            }
        }
    }
}
