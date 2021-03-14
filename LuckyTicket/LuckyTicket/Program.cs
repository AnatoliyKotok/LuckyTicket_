using System;
using System.Linq;

namespace LuckyTicket_
{
    class Program
    {
        static bool IsLuckyTicket(UInt32 number)
        {
            string numbStr = number.ToString();
            if (numbStr.Length >= 4 && numbStr.Length <= 8)
            {
                if (numbStr.Length % 2 != 0)
                {
                    numbStr = '0' + numbStr;
                }
                decimal sum1 = numbStr.Substring( 0, numbStr.Length / 2).ToArray().Sum(i => i);
                decimal sum2 = numbStr.Substring(numbStr.Length/2, numbStr.Length / 2).ToArray().Sum(i => i);
                return sum1 == sum2;
            }
            throw new ArgumentException("The ticket number must not contain less than 4 digits or more than 8");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Input your number->");
                UInt32 number = Convert.ToUInt32(Console.ReadLine());
                if (IsLuckyTicket(number))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have lucky ticket");
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry,you have a usual ticket");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue");
                Console.WriteLine("Press 'Esc' to exit");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
