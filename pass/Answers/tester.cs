using System;

public class Tester
{
    public static void Main()
    {
        List<int> list = new List<int>(20);
        int[] data = { 333, 236, 312, 780, 100, 722, 511, 966, 213, 724, 122, 120, 263, 175, 752, 958, 596, 299, 995, 772 };

        for (int i = 0; i < data.Length; i++)
        {
            list[i] = data[i];
        }

        // Test Default Search
        Console.WriteLine("Test A: Default Search");
        list.Searcher = new List<int>.DefaultSearcher();
        Console.WriteLine($"Resulting position: {list.Searcher.Search(data, 299)} :: SUCCESS\n");

        // Test Linear Search
        Console.WriteLine("Test B: Linear Search");
        list.Searcher = new LinearSearch();
        Console.WriteLine($"Resulting position: {list.Searcher.Search(data, 722)} :: SUCCESS\n");

        // Test Binary Search
        Console.WriteLine("Test C: Binary Search");
        Array.Sort(data);
        Console.WriteLine($"Resulting position: {list.Searcher.Search(data, 100)} :: SUCCESS\n");

        // Test Jump Search
        Console.WriteLine("Test D: Jump Search");
        list.Searcher = new JumpSearch();
        Console.WriteLine($"Resulting position: {list.Searcher.Search(data, 752)} :: SUCCESS\n");
    }
}
