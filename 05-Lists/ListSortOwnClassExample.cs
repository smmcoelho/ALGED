
public class Person : IComparable<Person>
{
    public Person(string name, string surname)
    {   
        Name = name;
        Surname = surname;
    }   

    public string Name { get; }
    public string Surname { get; }

    public override string ToString() => $"({Name}, {Surname})";
    
    public int CompareTo(Person other)
    {
        return Name.CompareTo(other.Name);
    }
    
    public override bool Equals(object obj)
    {
        return obj is Person other &&
               Name == other.Name &&
               Surname == other.Surname;
    }
}


public class Program
{
    static void Print<T>(LinkedList<T> items)
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {        
        var numeros = new List<Person>();
        numeros.Add(new Person("Robert", "Plant"));
        numeros.Add(new Person("Chris", "Cornell"));
        numeros.Add(new Person("Kurt", "Cobain"));
        
        // numeros.Sort((a, b) => a.Name.CompareTo(b.Name));
        numeros.Sort(); // uses CompareTo
        
        Console.WriteLine(string.Join(", ", numeros));
    }
}

