// T → general type
// K → key
// V → value


// Basic Generic Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

class Box<T> : Animal
{
    public T Value { get; set; }
}

class Box2<T>
{
    public T Data;
}

// Generic → Generic (same type parameter)
class Derived<T> : Box2<T>
{
    public void Display()
    {
        Console.WriteLine(Data);
    }
}

// Generic → Generic (different type arguments)
class DerivedBox<T> : Box2<int>
{
    public void Display()
    {
        Console.WriteLine(Data);
    }
}

//Partial Generic Inheritance

class Base<T, U>
{
    public T First;
    public U Second;
} 

class Derived1<T> : Base<T, string>
{
    public void Show()
    {
        Console.WriteLine($"First: {First}, Second: {Second}");
    }
}

// Multiple Type Parameters

class Car<T, U>
{
    public T Make;
    public U Model;
}

class SportCar<X, Y> : Car<X, Y>
{
    
}