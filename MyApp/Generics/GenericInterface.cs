
interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
}

interface IComparable<T>
{
    int CompareTo(T other);
}

class Person: IComparable<Person>
{
    public int Age;

    public int CompareTo(Person other)
    {
        return Age.CompareTo(other.Age);
    }
}


// Generic Interface Inheritance
interface IMonth<T> { }
interface IMarch<T> : IMonth<T> { }



