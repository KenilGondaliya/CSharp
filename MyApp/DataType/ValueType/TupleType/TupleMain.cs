using System;

namespace MyApp.DataType.ValueType.StructType
{
    public class TupleMain
    {
        public static void Run(string[] args)
        {
            (double, int) t1 = (3.14, 42);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            (double, int) t2 = (2.718, 7);
            Console.WriteLine($"Tuple with elements {t2.Item1} and {t2.Item2}.");

            var t =
                (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25, 26);

            Console.WriteLine($"Tuple with 26 elements: {t.Item26}");

            var t3 = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {t3.Count} elements is {t3 .Sum}.");

            (double Sum, int Count) d = (4.5, 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");
        }
    }
}