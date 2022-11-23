using System;

namespace hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the beginning of the range");

            int begin = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the end of the range");

            int end = int.Parse(Console.ReadLine());

            while (begin < end)
            {
                begin++;
                if (begin % 2 ==0)
                {
                    Console.WriteLine("an even number");
                    Console.WriteLine(begin);
                }
                else
                {
                    Console.WriteLine("odd number");
                    Console.WriteLine(begin);
                }
            }
        }
    }
}