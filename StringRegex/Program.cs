using System;
using System.Text.RegularExpressions;
class Program
{
    public static List<int> ValidateEmail(int N, string[] emails)
    {
        List<int> result = new List<int>();
        string pattern = @"^ [a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        for(int i = 0 ; i < N; i++)
        {
            if (Regex.IsMatch(emails[i], pattern))
            {
                result.Add(1);
            }

            else
            {
                result.Add(0);
            }

        }
        return result;
    }






    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] arr = new string[N];
        for(int i = 0; i < N; i++)
        {
            arr[i] = Console.ReadLine();
        }
        List<int> res = ValidateEmail(N,arr);
        foreach(int i in res)
        {
            Console.WriteLine(i);
        }
    }



        
}
