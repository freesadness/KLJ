using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            ShowTitle(1);
            Question1();
            PressAnyKey("continue");

            ShowTitle(2);
            Question2();
            PressAnyKey("continue");

            ShowTitle(3);
            Question3();
            PressAnyKey("continue");

            ShowTitle(4);
            Question4();
            PressAnyKey("continue");

            ShowTitle(5);
            Question5();
            PressAnyKey("exit");
        }

        public static void ShowTitle(int number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }

        public static void PressAnyKey(string word)
        {
            Console.WriteLine();
            Console.Write("Press any key to {0}...", word);
            Console.ReadKey();
        }

        #endregion

        /// <summary>
        /// Write code that prompts the user for a starting value, and then prints
        /// all the multiples of 9 on a single line separated by spaces in descending 
        /// order between the starting value and 1. You must use a for loop.
        /// </summary>
        public static void Question1()
        {
            Console.Write("Enter a starting value: ");
            int num = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Write code that displays a conversion table of cm to inches. You must
        /// prompt the user for the start cm and end cm values. The table must be
        /// in 5cm increments. You must use a do loop. You must match the following
        /// format exactly:
        /// 
        /// cm    in
        ///  5   1.95
        /// 10   3.90
        /// 15   5.85
        /// </summary>
        public static void Question2()
        {
            Console.Write("Enter a starting value: ");
            int cm = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Write code that prompts the user for a target number and then continually
        /// prompts the user for a number to subtract from the target. When the target
        /// is 0 or becomes negative, print the final target value and the number of
        /// user inputs. You must use a while loop.
        /// </summary>
        public static void Question3()
        {
            
        }

        /// <summary>
        /// Write code that prompts the user for the starting and ending value of x
        /// and the increment and then displays the table shown below.
        /// The relationship is given by the quadratic equation: y = 3x^2 - 7x + 2
        /// You must use some kind of loop. You must match the following format exactly:
        /// (Example where the initial value of x is 0, the final value of x is 0.5
        /// and the increment is 0.125)
        /// 
        ///    x  3x^2   -7x    +2     y
        /// ----  ----  ----  ----  ----
        /// 0.00  0.00  0.00  2.00  2.00
        /// 0.13  0.05 -0.88  2.00  1.17
        /// 0.25  0.19 -1.75  2.00  0.44
        /// 0.38  0.42 -2.63  2.00 -0.20
        /// 0.50  0.75 -3.50  2.00 -0.75
        /// </summary>
        public static void Question4()
        {
            
        }

        /// <summary>
        /// Write code that prompts the user for the number of rows and columns, 
        /// then displays the following pattern shown below.
        /// You must you a nested loop.
        /// 
        /// Example 1 (where rows is 11 and columns is 15):
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// 
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// 
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// xxx xxx xxx xxx
        /// 
        /// Example 2 (where rows is 5 and columns is 5):
        /// xxx x
        /// xxx x
        /// xxx x
        /// 
        /// xxx x
        /// 
        /// Example 3 (where rows is 9 and columns is 31)
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// 
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// 
        /// xxx xxx xxx xxx xxx xxx xxx xxx
        /// 
        /// </summary>
        public static void Question5()
        {
            Console.Write("Enter a starting value: ");
            int cm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a starting value: ");
            int cm = Convert.ToInt32(Console.ReadLine());
        }
    }
}
