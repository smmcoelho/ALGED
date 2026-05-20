public class Person
{
    public Person(string name, string surname)
    {   
        Name = name;
        Surname = surname;
    }   

    public string Name { get; }
    public string Surname { get; }

}

public class Program
{
    static void Print<T>(List<T> items)
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static bool Matches(Person p)
    {
        return p.Name == "Robert" && p.Surname == "Plant";
    }

    public static void Main()
    {
        var employees = new List<Person>
        {
            new Person("Robert", "Plant"),
            new Person("Chris", "Cornell"),
            new Person("Kurt", "Cobain"),
        };

        var person = new Person("Robert", "Plant");

        // Lambda version
        var employee1 = employees.Find(
            p => p.Name == person.Name && p.Surname == person.Surname
        );

        if (employee1 is not null)
        {
            Console.WriteLine("Found employee 1!");
        }

        // Predicate method version
        var employee2 = employees.Find(Matches);

        if (employee2 != null)
        {
            Console.WriteLine("Found employee 2!");
        }

        Print(employees);
    }
}
