using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class ReverseNumberToString
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            int reversedNumber = 0;
            while(number > 0)
            {
                int remainder = number % 10;
                reversedNumber = (reversedNumber * 10 + remainder);
                number = number / 10;
            }
           Console.WriteLine("reverse of a given number is: " + reversedNumber);
        }
    }
}
