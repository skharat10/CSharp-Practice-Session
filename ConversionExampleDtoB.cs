using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class ConversionExampleDtoB
    {
        static void Main(string[] args)
        {
            int decimalNumber;
            int i;
            int[] a = new int[10];

            Console.WriteLine("Enter the number to convert from Decimal to Binary: ");
            decimalNumber = int.Parse(Console.ReadLine());

            for(i = 0; decimalNumber > 0; i++)
            {
                a[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
            }
            Console.WriteLine("Binary of the "+ decimalNumber + "number is: ");
            for(i = i-1; i>= 0; i--)
            {
                Console.Write(a[i]);
            }

        }
    }
}
