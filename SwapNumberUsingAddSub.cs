using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class SwapNumberUsingAddSub
    {
        static void Main(string[] args)
        {
            int a = 450;
            int b = 44;
            Console.WriteLine("Before swap = a: " + a + ", b " + b);

            a = a + b; //10+20=30
            b = a - b; //30-20=10
            a = a - b; //30-10=20

            Console.WriteLine("After swap = a: " + a + ", b " + b);
        }
    }
}
