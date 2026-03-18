using System;


namespace MyApp.DataType
{
    class DataTypeMain
    {
        public static void Run(string[] args)
        {
            ErrorCode code = ErrorCode.NotFound;
            Console.WriteLine($"Error code: {(int)code} - {code}");
        }
    }
}