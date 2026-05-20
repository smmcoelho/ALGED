public class Person
{
    public Person(string name, string surname)
    {   
        Name = name;
        Surname = surname;
    }   

    public string Name { get; set; }
    public string Surname { get; set; }

    public override string ToString() => $"({Name}, {Surname})";
    
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
        var employees = new LinkedList<Person>();
        
        employees.AddLast(new Person("Robert", "Plant"));
        employees.AddLast(new Person("Chris", "Cornell"));
        employees.AddLast(new Person("Kurt", "Cobain"));
        
        var person = new Person("Freddie", "Mercury");
        employees.AddLast(person);
        
        var employee = employees.Find(new Person("Freddie", "Mercury")); // needs Equals implementation
        
        if (employee != null)
        {
            Console.WriteLine("Found employee 2!");
            Console.WriteLine(employee.Value);
            employee.Value.Name = "John";
        }
        
        Print(employees);
    }
}
