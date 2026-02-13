using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the string:");
        string input = Console.ReadLine();
        //string[] ch = input.Split(' ');
        input = input.ToLower();
        string[] words = input.Split(' ');
        Dictionary<string, int> freq = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if (freq.ContainsKey(word))
            {
                freq[word]++;
            }
            else
            {
                freq[word] = 1;
            }
            }
            Console.WriteLine("frequency of each word:");
        foreach(var i in freq){
            Console.WriteLine($"{i.Key} : {i.Value}");
            
        }
        }
        

    }
