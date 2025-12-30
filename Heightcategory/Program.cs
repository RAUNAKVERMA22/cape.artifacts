using System;

// class HeightCategory
// {
//     static void Main()
//     {
//         Console.Write("Enter height: ");
//         int h = int.Parse(Console.ReadLine());

//         if (h < 150)
//             Console.WriteLine("Dwarf");
//         else if (h <= 165)
//             Console.WriteLine("Average");
//         else if (h <= 190)
//             Console.WriteLine("Tall");
//         else
//             Console.WriteLine("Abnormal");
//     }
// }

class ht
{
    static void Main()
    {
        Console.Write("Enter the height:");
        int height = int.Parse(Console.ReadLine());
        if (height < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if(height<=165)
        {
            Console.WriteLine("Average");
        }
        else if(height <= 190)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal");
        }
    }
}