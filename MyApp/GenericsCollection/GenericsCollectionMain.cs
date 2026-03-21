
namespace MyApp.GenericsCollection;

public class GenericsCollectionMain
{
    public static void Run(string[] args)
    {
        int[] arr = [0,1,2,3,4];
        List<int> list = new List<int>();

        for(int i = 5; i < 10; i++)
        {
            list.Add(i);
        }

        ProcessItems(arr);
        ProcessItems(list);

    }

    static void ProcessItems<T>(IList<T> coll)
    {
        // IsReadOnly returns True for the array and False for the List.
        System.Console.WriteLine($"IsReadOnly: {coll.IsReadOnly}");

        // The following statement causes a run-time exception for the
        // array, but not for the List.
        //coll.RemoveAt(4);

        foreach(T item in coll)
        {
            System.Console.WriteLine(item?.ToString() + "");
        }

        Console.WriteLine();
    } 
}