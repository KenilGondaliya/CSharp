
namespace MyApp.DataType
{
    class RecordMain
    {
        public record Person(string FirstName, string LastName)
        {
            public required string[] PhoneNumbers { get; init; }
        }


        public static void Run(string[] args)
        {
            Person person1 = new("Kenil", "Gondaliya") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: Person { FirstName = Kenil, LastName = Gondaliya, PhoneNumbers = System.String[] }

            Person person2 = person1 with { FirstName = "John" };
            // output: Person { FirstName = John, LastName = Gondaliya, PhoneNumbers = System.String[] }
            Console.WriteLine(person2);
            Console.WriteLine(person1 == person2); // Output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Kenil, LastName = Gondaliya, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person2);

        }
    }
}