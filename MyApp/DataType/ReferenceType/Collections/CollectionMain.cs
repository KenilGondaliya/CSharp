
namespace MyApp.DataType.ReferenceType.Collections
{
    public class Element
    {
        public required string Symbol { get; init; }
        public required string Name { get; init; }
        public required int AtomicNumber { get; init; }
    }

    public class CollectionMain
    {
        public static void Run(string[] args)
        {
            // Create a list of strings by using a
            // collection initializer.
            List<string> salmons = ["chinook", "coho", "pink", "sockeye"];

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("coho");

            // Iterate using the index:
            for (int i = 0; i < salmons.Count; i++)
            {
                Console.WriteLine(salmons[i], " ");
            }

            salmons.Add("coho");

            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }


        }
    }
}