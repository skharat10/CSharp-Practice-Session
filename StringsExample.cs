using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SamplePracticeQuestions
{
    internal class StringsExample
    {
        static void Main(string[] args)
        {
            //string str1 = "+ Hello, I am Sachin + ";
            //Console.WriteLine("Before trim: " + str1);

            //Console.WriteLine("After trim: " + str1.TrimStart());    


            //Console.ReadLine();
            string s1 = " Sachin";
            string s2 = " Sachin ";
            string s3 = "Sachin ";

            // Before Trim method call
            Console.WriteLine("Before:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("");

            // After Trim method call
            Console.WriteLine("After:");
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());
        }
    
    }
}
