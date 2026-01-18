
namespace MyApp.Static
{
    public class Human
    {
        public int age;
        public string name;
        public int salary;
        public bool isMarried;

        public static long population;


        public Human(int age, string name, int salary, bool isMarried)
        {
            this.age = age;
            this.name = name;
            this.salary = salary;
            this.isMarried = isMarried;

            Human.population += 1;
        }
    }
}
