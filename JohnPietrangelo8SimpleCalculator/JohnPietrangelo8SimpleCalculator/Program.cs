//John Pietrangelo 9:00 a.m. Tuesdays & Thursdays.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPietrangelo8SimpleCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool enteryIsValid = true;
            string numberX = "";
            string numberY = "";
            Console.Write("Simple Calculator\n\n\t1) Add\n\t2) Subtract\n\t3) Multiply\n\t4) Divide\n\t5) Quit\n\nEnter Selection: ");
                
            while (enteryIsValid == true)   
                {
                    Console.Write("Enter Selection: ");
                    String userSelection1 = Console.ReadLine();
                    int userSelection = Convert.ToInt32(userSelection1);
                    if (userSelection < 1 && userSelection < 5)
                    {
                        enteryIsValid = !enteryIsValid;
                        Console.Write("\nInvalid Menu Selection, please try again. ");
                        userSelection1 = Console.ReadLine();
                    }    
                    switch (userSelection)
                    {
                        case 1:
                        Console.Clear();
                        Console.WriteLine("Simple Calculator\n\n\t1) Add\n\t2) Subtract\n\t3) Multiply\n\t4) Divide\n\t5) Quit\n\n");
                        Console.WriteLine("Enter two numbers, press enter after entering each one.\n");
                        Console.Write("\nEnter Number 1: ");
                        numberX = (Console.ReadLine());
                        Validate(numberX);
                        Console.Write("\nEnter Number 2: ");
                        numberY = (Console.ReadLine());
                        Validate(numberY);
                        double number1 = Convert.ToDouble(numberX);
                        double number2 = Convert.ToDouble(numberY);
                        Program.Add(number1,number2);
                        Console.Write("\nResult: ");
                        Console.WriteLine(Add(number1,number2));
                        Console.ReadLine();
                        break;

                        case 2:
                        Console.Clear();
                        Console.WriteLine("Simple Calculator\n\n\t1) Add\n\t2) Subtract\n\t3) Multiply\n\t4) Divide\n\t5) Quit\n\n");
                        Console.WriteLine("Enter two numbers, press enter after entering each one.\n");
                        Console.Write("\nEnter Number 1: ");
                        numberX = (Console.ReadLine());
                        Validate(numberX);
                        Console.Write("\nEnter Number 2: ");
                        numberY = (Console.ReadLine());
                        Validate(numberY);
                        number1 = Convert.ToDouble(numberX);
                        number2 = Convert.ToDouble(numberY); 
                        Program.Sub(number1, number2);
                        Console.Write("\nResult: ");
                        Console.WriteLine(Program.Sub(number1, number2));
                        Console.ReadLine();
                        break;

                        case 3:
                        Console.Clear();
                        Console.WriteLine("Simple Calculator\n\n\t1) Add\n\t2) Subtract\n\t3) Multiply\n\t4) Divide\n\t5) Quit\n\n");
                        Console.WriteLine("Enter two numbers, press enter after entering each one.\n");
                        Console.Write("\nEnter Number 1: ");
                        numberX = (Console.ReadLine());
                        Validate(numberX);
                        Console.Write("\nEnter Number 2: ");
                        numberY = (Console.ReadLine());
                        Validate(numberY);
                        number1 = Convert.ToDouble(numberX);
                        number2 = Convert.ToDouble(numberY);
                        Console.Write("\nResult: ");
                        Console.WriteLine(Program.Mult(number1, number2));
                        Console.ReadLine();
                        break;
                    
                        case 4:
                        Console.Clear();
                        Console.WriteLine("Simple Calculator\n\n\t1) Add\n\t2) Subtract\n\t3) Multiply\n\t4) Divide\n\t5) Quit\n\n");
                        Console.WriteLine("Enter two numbers, press enter after entering each one.\n");
                        Console.Write("\nEnter Number 1: ");
                        numberX = (Console.ReadLine());
                        Validate(numberX);
                        Console.Write("\nEnter Number 2: ");
                        numberY = (Console.ReadLine());
                        Validate(numberY); 
                        number1 = Convert.ToDouble(numberX);
                        number2 = Convert.ToDouble(numberY);
                        if (number2 == 0)
                        Console.Write("\ninvalid entery, cannot divid by 0\n\nre-enter number ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.Write("\nResult: ");
                        Console.WriteLine(Program.Div(number1, number2));
                        Console.ReadLine();
                        break;
                    
                        case 5:
                        Console.WriteLine("\t\t\t\tGOOD BYE, COME AGAIN!!!");
                        System.Threading.Thread.Sleep(750);
                        // Console.ReadKey();
                        break;

                        
                    }
                }  
        }//m
        public static bool Validate(string a)
        { 
             int count = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 if (a[i] > 0 && a[i] <=9) 
                 {
                     if (a[i] == '-' && i > 0)
                     {
                         if (a[i] == '.')
                         {
                             count++;

                             if (count == 2)
                             {
                                 return false;
                             }
                         }
                     }
                 }
                 else
                 {
                     return false;
                 }
             }
                     return true;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }//c
}//nS
