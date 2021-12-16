using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates1
{
    public class MethodDelegates
    {
        public delegate bool Check(int num);
        public delegate void MathOperators(int a, int b);
        public delegate void ChangeNames(string str);
        public static void Sum(int a, int b)
        {
            Console.WriteLine((a + b));
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine((a * b));
        }


        public static void StringToUpper(string str, int n)
        {
            Console.WriteLine(str.ToUpper()+ " " +n);
        }
        public static void StringToLower(string str, int n)
        {
            Console.WriteLine(str.ToLower()+ " " + n);
        }
        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool CheckNum(int num)
        {
            return num > 5;
        }

        public static int Sum(Predicate<int> func, params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (func(item))
                {
                    sum += item;
                }
            }

            return sum;

        }
    }
}
