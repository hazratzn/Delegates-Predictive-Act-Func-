using System;
using Delegates1;
using static Delegates1.MethodDelegates;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // MathOperators test = Sum;
            //test += Multiply;

            //test(9, 8);

            //ChangeNames names = StringToUpper;
            ////names += StringToLower;
            //names += x => Console.WriteLine(x.ToLower());
            //names.Invoke ("hazrat");

            //names("hazrat");

            //Console.WriteLine(Sum(m => m%2 == 0, 1, 2, 3, 4, 5, 6, 7));
            //Console.WriteLine(Sum(CheckEven, 1, 2, 3, 4, 5, 6, 7));
            //Console.WriteLine(Sum(CheckNum, 1, 2, 3, 4, 5, 6, 7));

            //Action<string,int> names = StringToUpper;
            //names += StringToLower;
            //names("BEXtiyar",5);
            //names("Rovshen", 10);


        }
    }
}
