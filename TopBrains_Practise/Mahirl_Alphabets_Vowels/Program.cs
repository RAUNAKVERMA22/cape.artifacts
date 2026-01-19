// using System;
// using System.Linq;

// public class Program

// {
//     public static void Main()
//     {
//         string word1 = Console.ReadLine();
//         string word2 = Console.ReadLine();

//         var secondSet = word2
//             .ToLower()
//             .ToHashSet();

//         string result = new string(
//             word1
//             .Where(c =>
//             {
//                 char lc = char.ToLower(c);
//                 return IsVowel(lc) || !secondSet.Contains(lc);
//             })
//             .Aggregate(
//                 "",
//                 (acc, c) => acc.Length == 0 || acc.Last() != c ? acc + c : acc
//             )
//             .ToCharArray()
//         );

//         Console.WriteLine(result);
//     }

//     static bool IsVowel(char c)
//     {
//         return "aeiou".Contains(c);
//     }
// }














using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        // Step 1: Store characters of second word (case-insensitive)
        HashSet<char> secondWordChars = new HashSet<char>();
        foreach (char c in word2.ToLower())
        {
            secondWordChars.Add(c);
        }

        // Step 2: Remove common consonants from first word
        StringBuilder filtered = new StringBuilder();

        foreach (char c in word1)
        {
            char lower = char.ToLower(c);

            if (IsVowel(lower))
            {
                filtered.Append(c); // keep vowels
            }
            else
            {
                // consonant → remove only if it exists in second word
                if (!secondWordChars.Contains(lower))
                {
                    filtered.Append(c);
                }
            }
        }

        // Step 3: Remove consecutive duplicate characters
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Length; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
            {
                result.Append(filtered[i]);
            }
        }

        // Output result
        Console.WriteLine(result.ToString());
    }

    static bool IsVowel(char c)
    {
        return "aeiou".Contains(c);
    }
}
