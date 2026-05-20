
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
        var employees = new LinkedList<int>(new List<int>{1, 4, 2, 5, 3 });
        employees = new LinkedList<int>(employees.OrderBy(p => p));
        Print(employees);
    }
}
