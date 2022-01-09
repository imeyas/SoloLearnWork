using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn //All code in this program come from SOlolearn lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //Line of code to pay respect to the craft lol

            // Decided to add to the actual lesson code with catentation learned in class; and adding the decimal and boolean types
            int x = 10;

            double y = 17.7;

            decimal z = 28.8m;

            bool isReal = true;

            Console.WriteLine("x = {0}; y = {1}; z = {2}; and ours is real:" + isReal, x, y, z);

            //This sessions involved writing code that takes user input and outputs it
            string yourName;
            Console.WriteLine("What is your name?");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);

            //This session is about the available Arithmetic operators in C#
            int q = 17;
            int o = 45;
            Console.WriteLine(q + o); //Addition

            int x1 = 23;
            int y1 = 27;
            int z1 = x1 * y1;
            Console.WriteLine(z1 + y1); //Multiplication

            int x2 = 45 / 35;
            Console.WriteLine(x2); //Division - the remainder to the answer is dropped off to make the final answer an integer

            int y2 = 25 % 7;
            Console.WriteLine(y2); //Modulus - captures the remaainder of an integer

            int y3 = 7 + 2 * 5;
            Console.WriteLine(y3); //Operator precedence with multiplication

            int x4 = ((7 + 2) * 5);
            Console.WriteLine(x4); //Operator precedence showing parenthesis performed first as the highest precedence

            //Question: How do I feed this line data that will be used in the place of {0} below, instead of running as "... 0 years old?
            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("You are {0} years old", age);


        }
    }
}