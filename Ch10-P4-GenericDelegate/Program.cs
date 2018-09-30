using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_P4_GenericDelegate
{
    //// This generic delegate can represnet any method
    //// returning void and taking a single parameter of type T.
    //public delegate void MyGenericDelegate<T>(T arg);

    //public delegate void GenericSumDelegate<T>(T arg1, T arg2);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Generic Delegates *****\n");
            ////// Register targets.
            ////MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            ////strTarget("Some string data");
            ////MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            ////intTarget(9);

            //GenericSumDelegate<int> delSum = new GenericSumDelegate<int>(Sum);
            //delSum.Invoke(3, 3);
            //Console.WriteLine();

            //GenericSumDelegate<float> delSum2 = new GenericSumDelegate<float>(Sum);
            //delSum2.Invoke(3, 3);

            //GenericSumDelegate<double> delsum3 = new GenericSumDelegate<double>(GenericSum);
            //delsum3.Invoke(3, 3);

            //GenericSumDelegate<short> delsum4 = new GenericSumDelegate<short>(GenericSum);
            //delsum4.Invoke(3, 3);

           //Action<

           // Func<>

            Console.ReadLine();
        }

        static void GenericSum<T>(T arg1 , T arg2)
        {
            Console.WriteLine("\n Generic Sum invoked ( T )  ");
            Console.WriteLine(" Incoming arg1 Type : {0}" , arg1.GetType().Name  );
            Console.WriteLine(" Incoming arg2 Type : {0}" , arg2.GetType().Name  );
            //var sum = arg1 + arg2; 
            //Console.WriteLine(" Sum of numbers = {0} " , arg1 + arg2);
            Console.WriteLine(" Sum of numbers = {0} ");
        }

        static void Sum(int no1, int no2)
        {
            Console.WriteLine(" Sum invoked ( int )  ");
            Console.WriteLine(" Sum of numbers : {0}", no1 + no2);
        }
        static void Sum(float no1, float no2)
        {
            Console.WriteLine(" Sum invoked ( float )  ");
            Console.WriteLine(" Sum of numbers : {0}", no1 + no2);
        }
        static void StringTarget(string arg)
        {
            Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
        }
        static void IntTarget(int arg)
        {
            Console.WriteLine("++arg is: {0}", ++arg);
        }

        
    }
}
