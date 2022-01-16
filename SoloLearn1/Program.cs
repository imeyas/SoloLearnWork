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

            //This session is about Assignment operators
            int x5 = 45;
            x5 += 10;
            Console.WriteLine(x5);
            int y4 = 45;
            y4 -= 10;
            Console.WriteLine(y4);

            //This session is about Increment operators
            int y5 = 7;
            y5++;
            Console.WriteLine(y5);

            int a = 6;
            int b = ++a;
            Console.WriteLine(b); //This code uses the Prefixed Increment operator which increments the value of 'a' and then assigned it to 'b'

            int a1 = 10;
            int b1 = a1++;
            Console.WriteLine(b1); //This code uses the Postfixed Increment operator which assigned the value of a1 to b1 and then increments a1
            Console.WriteLine(a1);

            //This session is about Decrement operator, which works in the same way as the Increment but instead of incrementing (adding) it decrements (decreases) by one
            int a3 = 8;
            a3--;
            Console.WriteLine(a3);

            //Used this code to solve for the answer to a quiz question
            int a4 = 15;
            int b4 = 6;
            a4 %= b4;
            Console.WriteLine(a4);

            //This code takes in the radius input of 5, a constant of pi (3.14) and outputs the area of a circle (78.5)
            const double pi = 3.14;
            double radius = 5.0;
            Console.WriteLine("Please enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
            double area = pi * (radius * radius);
            Console.WriteLine(area);

            //This code is asking user for their age, reading that and outputting a sentence that tells them how old they are
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("You are {0} years old", age);

            //If statements

            int e = 8;
            int e1 = 9;

            if (e > e1)
            {
                Console.WriteLine($"Greater than {e}");
            }
            else if (e < e1)
            {
                Console.WriteLine($"Less than {e1}");
            }
            else
            {
                Console.WriteLine($"Must be {e1}");
            }

            if (a == b)
                Console.WriteLine("Equal");

            int grade = 89;

            if (grade < 70)
            {
                Console.WriteLine("Did not pass");
            }
            else
            {
                Console.WriteLine($"Passed with {grade}");
            }

            //Syntax Sugar exercise - refactoring code to infered typing, string interpolation and ternary

            var answer = 4;
            string response;

            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + “greater than or equal to nine”;
            //}

            //Refactored code

            response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);

            //Nested If Statements

            int yourAge = 17;
            if (age > 14)
            {
                if (age > 18)
                {
                    Console.WriteLine($"Adult");
                }
                else
                {
                    Console.WriteLine($"Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine($"Child");
                }
                else
                {
                    Console.WriteLine($"Something's wrong");
                }
            }

            //The if - else - if statement

            int ageToEnter = 33;

            if (ageToEnter < 21 )
            {
                Console.WriteLine($"\nUnder the age limit for this bar");
            } else if (ageToEnter > 21)
            {
                Console.WriteLine($"\nYou may enter the bar");
            } else
            {
                Console.WriteLine($"\nPlease scan your I.D");
            }

            //Switch statements

            int num = 4;

            switch (num)
            {
                case 1:
                    Console.WriteLine($"\nOne");
                    break;

                case 2:
                    Console.WriteLine($"\nTwo");
                    break;

                case 3:
                    Console.WriteLine($"\nThree");
                    break;
                default:
                    Console.WriteLine($"\nInvalid input");
                    break;
            }

            int numX = 17;

            switch (num)
            {
                case 1:
                    Console.WriteLine($"\nOne");
                    break;

                case 2:
                    Console.WriteLine($"\nTwo");
                    break;

                case 3:
                    Console.WriteLine($"\nThree");
                    break;

                case 4:
                    Console.WriteLine($"\nFour");
                    break;

                case 5:
                    Console.WriteLine($"\nFive");
                    break;

                case 6:
                    Console.WriteLine($"\nSix");
                    break;

                case 7:
                    Console.WriteLine($"\nSeven");
                    break;

                case 8:
                    Console.WriteLine($"\nEight");
                    break;

                case 9:
                    Console.WriteLine($"\nNine");
                    break;

                case 10:
                    Console.WriteLine($"\nTen");
                    break;

                case 11:
                    Console.WriteLine($"'\nEleven");
                    break;

                case 12:
                    Console.WriteLine($"\nTwelve");
                    break;

                case 13:
                    Console.WriteLine($"\nThirteen");
                    break;

                case 14:
                    Console.WriteLine($"\nFourteen");
                    break;

                case 15:
                    Console.WriteLine($"\nFifteen");
                    break;

                case 16:
                    Console.WriteLine($"\nSixteen");
                    break;

                case 17:
                    Console.WriteLine($"\nSeventeen");
                    break;

                default:
                    Console.WriteLine($"\nInvalid input");
                    break;
            }

            //While loops

            int numG = 1;

            while (num <= 17)
            {
                Console.WriteLine($"\n{num}");
                num++;
            }

            int num2 = 2;

            while (num2 <= 17)
            {
                Console.WriteLine($"\n{num2}");
                num2++;
            }

            int num3 = 3;

            while (num3 <= 17)
            {
                Console.WriteLine($"\n{num3}");
                num3++;
            }

            int num4 = 4;

            while (num4 <= 17)
            {
                Console.WriteLine($"\n{num4}");
                num4++;
            }

            int num5 = 5;

            while (num5 <= 17)
            {
                Console.WriteLine($"\n{num5}");
                num5++;
            }
            var num6 = 6;

            while (num6 <= 17)
            {
                Console.WriteLine($"\n{num6}");
                num6++;
            }

            var otherNum = 0;

            while (otherNum <= 17)
            {
                Console.WriteLine($"\n{otherNum}");
                ++otherNum;
            }

            var otherNum1 = 1;

            while (otherNum1 <7)
            {
                Console.WriteLine($"\n{otherNum1}");
                otherNum1 += 2;
            }

            var otherNum3 = 0;

            while (++otherNum3 < 6)
            {
                Console.WriteLine($"\n{ otherNum3}");
            }

            var otherNum4 = 0;

            while (otherNum4++ < 6)
            {
                Console.WriteLine($"\n{otherNum4}");
            }    

            

            for (int numDecrease = 10; numDecrease > 0; numDecrease -= 2)
            {
                Console.WriteLine($"\n{numDecrease}");
            }

            int numIncrease = 17;

            for ( ; numIncrease > 0; )
            {
                Console.WriteLine($"\n{numIncrease}");
                numIncrease *= 2;
            }

            decimal newDecimal = 17.5555m;

            for ( ; newDecimal > 0; )
            {
                Console.WriteLine($"\n{newDecimal}");
                newDecimal /= 3;
            }


            int doWhile = 0;

            do
            {
                Console.WriteLine($"\n{doWhile}");
                doWhile++;
            } while (doWhile <= 17);

            int doWhileAgain = 10;

            do
            {
                Console.WriteLine($"\n{doWhileAgain}");
                doWhileAgain--;
            } while (doWhileAgain <= -17);

            int doWhileAgainAgain = 100;

            do
            {
                Console.WriteLine($"\n{doWhileAgainAgain}");
                doWhileAgainAgain /= 2;
            } while (doWhileAgainAgain == 0);

            int doingWhile = 1000;

            do
            {
                if (doingWhile <= 999);
                Console.WriteLine($"\n{doingWhile}");
                doingWhile -= 17;
            } while (doingWhile >= -1000);

            int breakNow = 0;

            while (breakNow <= 17)
            {
                if (breakNow == 9)
                break;

                Console.WriteLine($"\n{breakNow}");
                breakNow++;
            }

            int breakNowAgain = 100;

            while (breakNowAgain <= 10000)
            {
                if (breakNowAgain >= 10000)
                    break;

                Console.WriteLine($"\n{breakNowAgain}");
                breakNowAgain *= 9;
            }


            int continuing = 0;

            for (continuing = 0; continuing < 17; continuing++)
            {
                if (continuing == 7)
                    continue;

                Console.WriteLine($"\n{continuing}");
            }

            int continueAgain = 100;

            for (continueAgain = 100; continueAgain >= -100; continueAgain--)
            {
                if (continueAgain == 55)
                    continue;

                Console.WriteLine($"\n{continueAgain}");
            }

            for (int keepGoing = 0; keepGoing < 5; keepGoing++)
            {
                if (keepGoing == 5)
                    continue;
                Console.WriteLine($"\n{keepGoing}");
            }



        }
    }
}