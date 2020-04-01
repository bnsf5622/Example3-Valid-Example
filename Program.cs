using System;
namespace Example3_Valid_Example
{
    class First
    {
        public int sum(int val1) //This method has pne argument, while
            // the next method has two.Hence during compilation, system will
           // identify it as 2 different methods.
                { 
                                return val1 + 1;
        }

        public int sum(int val1, int val2)
        {
            return val2 + val2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            First fObj = new Example3_Valid_Example.First();
            int val = fObj.sum(3);
            Console.WriteLine("sum=" + val);
        }
    }
}