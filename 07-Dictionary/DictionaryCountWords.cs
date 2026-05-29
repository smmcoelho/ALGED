class Program
{
    static void Main()
    {
        string text = "o gato e o cão e o gato";

        var wordCounts = CountWords(text);

        foreach (var pair in wordCounts)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }

    static Dictionary<string, int> CountWords(string input)
    {
        var dictionary = new Dictionary<string, int>();

        // TODO
        
        return dictionary;
    }
}
