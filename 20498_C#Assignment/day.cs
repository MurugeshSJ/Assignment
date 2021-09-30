using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class holiday
    {
        static void Main1()
        {
            Console.WriteLine("enter day");
            string day = Console.ReadLine();
            int n = int.Parse(day);
            if(n==0 || n > 7)
            {
                Console.WriteLine("invalid day");
            }else if (n <= 5)
            {
                Console.WriteLine("working day");
            }else
                Console.WriteLine("holiday");
        }
    }
}