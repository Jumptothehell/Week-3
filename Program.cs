using System;

namespace tammaidai
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, num6;
            Console.WriteLine("Enter numbers 0 - 9");
            Console.WriteLine("Plese input 6-digits : ");
            int.TryParse(Console.ReadLine(), out num1);
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            num6 = int.Parse(Console.ReadLine());


            Console.WriteLine("Your 6 digits is " + num1 + num2 + num3 + num4 + num5 + num6);
            Console.ReadLine();
            Console.WriteLine("Please input an abbreviation of the organization : ");
            string a = Console.ReadLine();
            if (a == "CIA")
            {
                if (num6 % 3 == 0)
                {
                    if (num5 != 1 && num5 != 3 && num5 != 5)
                    { 
                        if (num3 >=6 && num3 != 8)
                        {
                            Console.WriteLine("True");
                        }
                        else
                            Console.WriteLine("False");
                    }
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("False");
            }
            else if (a == "FBI")
            {
                if(num1 >=4 && num1 <=7)
                {
                    if (num4 % 2 == 0 && num4 != 6)
                    {
                        if (num2 % 2 == 0)
                        {
                            Console.WriteLine("False ");
                        }
                        else
                            Console.WriteLine("True");
                    }
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("False");
            }
            else if (a == "NSA")
            {
                if (30 % num6 == 0)
                {
                    if (num4 % 3 == 0 && num4 % 2 != 0)
                    {
                        if (num1 == 7)
                        {Console.WriteLine("True");}
                        else if (num2 == 7)
                        { Console.WriteLine("True"); }
                        else if (num3 == 7 )
                        { Console.WriteLine("True"); }
                        else if (num4 == 7 )
                        { Console.WriteLine("True"); }
                        else if (num5 == 7)
                        { Console.WriteLine("True"); }
                        else if (num6 == 7)
                        { Console.WriteLine("True"); }
                        else
                        { Console.WriteLine("False"); }
                    }
                    else
                        Console.WriteLine("False");
                }
                else
                    Console.WriteLine("False");
            }
            else
                Console.WriteLine("Your password is incorrect.");
        }
    }
}