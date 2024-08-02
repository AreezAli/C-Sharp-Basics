using System;
using System.Collections.Generic;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    private bool isHungry; 
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
        isHungry = true; 
    }
    ~Animal()
    {
        Console.WriteLine($"Destructor called for {Name}");
    }
    public void Feed()
    {
        isHungry = false;
        Console.WriteLine($"{Name} has been fed.");
    }
}

public struct Coordinates
{
    public int X { get; set; }
    public int Y { get; set; }

    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;
    }
}
public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }
}


public class Addition
{

    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}

public class NewAddition : Addition
{
    public new double Add(double a, double b) => a + b + 10; 
}

public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    protected int age;

    internal string address;

    protected internal string phoneNumber;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}, Phone: {phoneNumber}");
    }
}

public class ReadOnlyClass
{
    public const double Pi = 3.14159;
    public readonly double gravity;

    public ReadOnlyClass()
    {
        gravity = 9.8;    }

    public void ShowValues()
    {
        Console.WriteLine($"Pi: {Pi}, Gravity: {gravity}");
    }
}



public static class StaticClass
{
    public static void ShowMethod()
    {
        Console.WriteLine("This is a static class method.");
    }
}

public class NonStaticClass
{
    public void ShowMethod()
    {
        Console.WriteLine("This is a non-static class method.");
    }
}


public class CollectionClass
{
    public void ShowCollections()
    {
        
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
        {
            {1, "One"},
            {2, "Two"},
            {3, "Three"}
        };

        Console.WriteLine("Dictionary elements:");
        foreach (KeyValuePair<int, string> element in keyValuePairs)
        {
            Console.WriteLine($"Key: {element.Key}, Value: {element.Value}");
        }

        List<string> fruits = new List<string> { "Apple", "Mango", "Banana" };
        fruits.Add("Orange");

        Console.WriteLine("List elements:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}

public class LoopsClass
{
    public void ShowLoops()
    {
        
        int i = 0;
        Console.WriteLine("while loop:");
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }

        int j = 0;
        Console.WriteLine("do-while loop:");
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 5);

        
        Console.WriteLine("for loop:");
        for (int k = 0; k < 5; k++)
        {
            Console.WriteLine(k);
        }

   
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("foreach loop:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Lion", 5);
        myAnimal.Feed();

        Coordinates point1 = new Coordinates(10, 20);
        Coordinates point2 = point1;
        point2.X = 30; 

        Console.WriteLine($"point1: ({point1.X}, {point1.Y}), point2: ({point2.X}, {point2.Y}), point1: ({point1.X}, {point1.Y})");

        Shape myShape = new Circle(5.5);
        myShape.Draw();

        Addition addition = new Addition();
        NewAddition newAddition = new NewAddition();
        Console.WriteLine($"Addition Add(int, int): {addition.Add(5, 3)}");
        Console.WriteLine($"Addition Add(double, double): {addition.Add(5.5, 3.3)}");
        Console.WriteLine($"NewAddition Add(double, double): {newAddition.Add(5.5, 3.3)}");

        Person person = new Person("Areez Ali", 22);
        person.address = "ABCD Karachi";
        person.phoneNumber = "00000000000";
        person.DisplayInfo();

        ReadOnlyClass values = new ReadOnlyClass();
        values.ShowValues();

        StaticClass.ShowMethod();
        NonStaticClass nonStatic = new NonStaticClass();
        nonStatic.ShowMethod();

        CollectionClass collections = new CollectionClass();
        collections.ShowCollections();

        LoopsClass loops = new LoopsClass();
        loops.ShowLoops();

        Console.ReadLine();
    }
}

