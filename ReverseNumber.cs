using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int number;
            int reverse = 0;
            int remainder;

            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            while(number != 0)
            {
                remainder = number % 10; //125 = 5, 2
                reverse = reverse*10 + remainder;// 0*10+5, 0*10+2
                number = number / 10; //12, 1

            }
            Console.WriteLine("Reversed number: " + reverse);
        }
    }
}
