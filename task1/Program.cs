using System;

namespace task1
{
    class Program
    {
        private delegate int MyDelegate(int x, int y);
        static void Main(string[] args)
        {
            var myDeleg = new MyDelegate(Sum);

            Console.WriteLine(myDeleg(4, 20));
            Console.WriteLine(myDeleg(8, 35));
            Console.WriteLine(myDeleg(42, 2));
        }
        private static int Sum(int m, int n)
        {
            var sum = 0;
            for (int i = m; i < n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
