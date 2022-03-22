using System;
using System.Linq;

namespace task4
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Func<double, double, double, bool> myDelegate = (x, y, z) =>
            {
                return x + y > z && x + z > y && z + y > x ? true : false;
            };
            Console.WriteLine(myDelegate(3, 6, 7));
            Console.WriteLine(myDelegate(7, 12, 4));
            Console.WriteLine(myDelegate(3, 0, 7));



            Console.WriteLine("Введите количество элементов массива");
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, 20);
            }

            Action<int[]> Print = (arr =>
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            });

            Action<int[]> Sum = arr => Console.WriteLine(arr.Sum());

            Console.WriteLine("Все элементы массива");
            Print(array);
            Console.WriteLine();
            Console.WriteLine("Положительные нечетные элементы массива");
            Predicate<int> uneven = u => u % 2 != 0 && u > 0;
            Print(array.Where(w => uneven(w)).ToArray());
            Console.WriteLine();
            Console.WriteLine("Сумма четных элементов массива");
            Predicate<int> summary = s => s % 2 == 0;
            Sum(array.Where(d => summary(d)).ToArray());
        }
    }
}
