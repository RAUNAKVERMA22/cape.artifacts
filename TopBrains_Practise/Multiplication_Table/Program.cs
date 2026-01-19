using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());
        for(int i = 1; i <= upto ; i++)
        {
            Console.Write(n*i);
            if(i < upto)
            {
                Console.Write(" ");
            }
        }
    }
}