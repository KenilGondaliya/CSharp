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
        }
    }
}