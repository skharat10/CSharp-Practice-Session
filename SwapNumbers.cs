using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class SwapNumbers
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 55;
            Console.WriteLine("Before swap a = "+ a +" b= " + b);
            a = a * b;  //55*10
            b = a / b;  //550/55
            a = a / b;  //550/10
            Console.WriteLine("After Swap a = " + a + " b= " + b);
        }
    }
}
