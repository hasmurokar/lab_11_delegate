using System;
using System.Linq;

namespace task3
{
    class Program
    {
        private static Random rnd = new Random();
        private delegate bool MyDelegate(int x);
        private delegate void MethodDelegate(int [] array);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-20, 20);
            }

            var Print = new MethodDelegate(arr =>
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            });

            var Sum = new MethodDelegate(arr => Console.WriteLine(arr.Sum()));

            Console.WriteLine("Все элементы массива");
            Print(array);
            Console.WriteLine();
            Console.WriteLine("Положительные нечетные элементы массива");
            var uneven = new MyDelegate(u => u % 2 != 0 && u > 0);
            Print(array.Where(w => uneven(w)).ToArray());
            Console.WriteLine();
            Console.WriteLine("Сумма четных элементов массива");
            var summary = new MyDelegate(s => s % 2 == 0);
            Sum(array.Where(d => summary(d)).ToArray());


        }
    }
}
