using System;
//using System.Linq;

public static class ArrayDemo
{
    public static void Run()
    {
        OneDimensional();
        MultiDimensional();
        JaggedArrays();
    }

    static void OneDimensional()
    {
        Console.WriteLine("-- One-dimensional array --");
        int[] numbers = { 5, 3, 8, 1 };

        Console.WriteLine("Original: " + string.Join(", ", numbers));

        Array.Sort(numbers);
        Console.WriteLine("Sorted:   " + string.Join(", ", numbers));

        int index = Array.IndexOf(numbers, 8);
        Console.WriteLine($"Index of 8: {index}");

        int found = Array.BinarySearch(numbers, 3);
        Console.WriteLine($"BinarySearch for 3 returned: {found}");

        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Evens (LINQ): " + string.Join(", ", evens));

        int[] copy = new int[numbers.Length];
        Array.Copy(numbers, copy, numbers.Length);
        Console.WriteLine("Copied:   " + string.Join(", ", copy));

        Console.WriteLine();
    }

    static void MultiDimensional()
    {
        Console.WriteLine("-- Multidimensional array --");
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void JaggedArrays()
    {
        Console.WriteLine("-- Jagged arrays --");
        int[][] jagged = new int[3][];
        jagged[0] = new[] { 1, 2 };
        jagged[1] = new[] { 3, 4, 5 };
        jagged[2] = new[] { 6 };

        for (int i = 0; i < jagged.Length; i++)
        {
            Console.WriteLine("Row " + i + ": " + string.Join(", ", jagged[i]));
        }

        Console.WriteLine();
    }
}
