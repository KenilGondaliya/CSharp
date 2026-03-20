
namespace MyApp.Generics
{
    public class GenericMain
    {
        public static void Run(string[] args)
        {
            // Create a list of type int.
            GenericList<int> list1 = new();
            list1.Add(1);

            // Create a list of type string.
            GenericList<string> list2 = new();
            list2.Add("");

            // Create a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new();
            list3.Add(new ExampleClass());
        }
    }
}

