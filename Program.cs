using System;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("Waiting...");
                Thread.Sleep(1000);
            }

            // ReSharper disable once FunctionNeverReturns
        }
    }
}