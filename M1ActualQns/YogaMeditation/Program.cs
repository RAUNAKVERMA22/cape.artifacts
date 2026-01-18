using System;
using System.Collections;
using YogaMedation;
class Program
{
    public static ArrayList memberList = new ArrayList();

    static void Main()
    {
        Program p = new Program();

        Console.Write("Enter Member Id: ");
        int id = int.Parse(Console.ReadLine());


        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter Height: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Enter Goal: ");
        string goal = Console.ReadLine();

        p.AddYogaMember(id, age, weight, height, goal);

        double bmi = p.CalculateBMI(id);
        if (bmi == -1)
        {
            Console.WriteLine($"MemberId {id} is not present");
            return;
        }

        Console.WriteLine("BMI: " + bmi);

        int fee = p.CalculateYogaFee(id);
        Console.WriteLine("Yoga Fee: " + fee);
    }

    // Method 1
    public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
    {
        Meditation mc = new Meditation
        {
            MemberId = memberId,
            Age = age,
            Weight = weight,
            Height = height,
            Goal = goal
        };

        memberList.Add(mc);
    }

    // Method 2
    public double CalculateBMI(int memberId)
    {
        foreach (Meditation m in memberList)
        {
            if (m.MemberId == memberId)
            {
                double bmi = m.Weight / (m.Height * m.Height);
                bmi = Math.Floor(bmi * 100) / 100;
                m.BMI = bmi;
                return bmi;
            }
        }
        return -1;
    }

    // Method 3
    public int CalculateYogaFee(int memberId)
    {
        foreach (Meditation m in memberList)
        {
            if (m.MemberId == memberId)
            {
                if (m.Goal.Equals("Weight Loss", StringComparison.OrdinalIgnoreCase))
                {
                    if (m.BMI > 25 && m.BMI <= 30)
                        return 2000;
                    else if (m.BMI > 30 && m.BMI <= 35)
                        return 2500;
                    else if (m.BMI > 35)
                        return 3000;
                }
                else if (m.Goal.Equals("Weight Gain", StringComparison.OrdinalIgnoreCase))
                {
                    return 2500;
                }
            }
        }
        return 0;
    }
}
