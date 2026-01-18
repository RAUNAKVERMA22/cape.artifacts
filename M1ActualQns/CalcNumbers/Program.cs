using System;
using System.Collections.Generic;
class Program
{
    public static List<int> NumberList = new List<int>();
    public static void Main()
    {
        Program pObj = new Program();
        Console.Write("Enter count of sub: ");
        int subCount = int.Parse(Console.ReadLine());
        for(int i = 0; i < subCount; i++)
        {
            Console.Write("Enter numbers: ");
            int num = int.Parse(Console.ReadLine());
            pObj.AddNumbers(num);
        }
        double gpa = pObj.GetGPAScored();
        if(gpa == -1)
        {
            Console.WriteLine("No numbers present");
            return;
        }
        Console.WriteLine("GPA Scored: " + gpa);
        char grade = pObj.GetGradeScored(gpa);
        if(grade == '\0')
        {
            Console.WriteLine("Invalid GPA");
            
        }
        else
        {
            Console.WriteLine("Grade Scored: " + grade);
        }
    }
    // Method 1 AddNumbers
    public void AddNumbers(int numbers)
    {
        NumberList.Add(numbers);
    }
    //Method 2 GetGPAScored
    public double GetGPAScored()
    {
        if(NumberList.Count == 0)
        {
            return -1;
        }
        double sum = 0;
        foreach(int num in NumberList)
        {
            sum = sum + num*3;
        }
        double gpa = sum/((NumberList.Count*3)*10);
        return gpa;
    }
    //Method 3 GetGradeScored 
    public char GetGradeScored(double gpa)
    {
        if(gpa < 5 || gpa > 10)
        {
            return '\0';
        }
        else if (gpa == 10)
        {
            return 'S';
        }
        else if(gpa >= 9)
        {
            return 'A';
        }
        else if (gpa >= 8)
        {
            return 'B';
        }
        else if (gpa >= 7)
        {
            return 'C';
        }
        else if (gpa >= 6)
        {
            return 'D';
        }
        else return 'E';
    }

}