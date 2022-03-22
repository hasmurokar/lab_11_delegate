using System;

namespace task2
{
    class Program
    {
        private delegate bool Operation(double x, double y, double z);
        static void Main(string[] args)
        {
            var myDelegate = new Operation((x, y, z) =>
            {
                return x + y > z && x + z > y && z + y > x ? true : false;
            });
            Console.WriteLine(myDelegate(3, 6, 7));
            Console.WriteLine(myDelegate(7, 12, 4));
            Console.WriteLine(myDelegate(3, 0, 7));
        }
    }
}
