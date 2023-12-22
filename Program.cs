using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;

namespace Изучение_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [2, 5, 13, 7, 6, 4];
            int size = numbers.Length;
            int summ = 0;
            int avg = 0;
            int index = 0;
            while (index < size)
            {
                summ += numbers[index];

                index++;

            }
            Console.WriteLine(avg = summ / size);


        }
    }
}
