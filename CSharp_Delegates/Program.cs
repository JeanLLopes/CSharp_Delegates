using System;

namespace CSharp_Delegates
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void WriteConsoleLine(string text)
        {
            Console.WriteLine($"Start {nameof(WriteConsoleLine)} with parameter: {text}.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Start {nameof(CSharp_Delegates)}");

            //CREATE DELEGATE Func<T> Delegate
            Console.WriteLine($"Start Func<T> Delegate");
            Func<int, int, int> sumDelegate = Sum;
            Console.WriteLine($"Result: {sumDelegate(10,30)}");
            Console.ReadKey();
            
            //CREATE DELEGATE Action<T> Delegate
            Console.WriteLine("Start Action<T> Delegate");
            Action<string> writeConsoleLineDelegate = WriteConsoleLine;
            Console.ReadKey();
        }
    }
}
