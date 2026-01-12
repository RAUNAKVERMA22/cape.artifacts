using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = Console.Out;

        ILibrarySystem librarySystem = new LibrarySystem();
        int bCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i <= bCount; i++)
        {
            var a = Console.ReadLine().Trim().Split(" ");

            IBook e = new Book();
            e.Id = Convert.ToInt32(a[0]);
            e.Title = a[1];
            e.Author = a[2];
            e.Category = a[3];
            e.Price = Convert.ToInt32(a[4]);

            librarySystem.AddBook(e, Convert.ToInt32(a[5]));
        }

        textWriter.WriteLine("Book Info:");
        var booksInfo = librarySystem.BooksInfo();

        foreach (var (title, quantity, price) in booksInfo.OrderBy(a => a.Item1))
            textWriter.WriteLine($"Book Name:{title}, Quantity:{quantity}, Price:{price}");

        textWriter.WriteLine("Category Total Price:");
        var categoryTotalPrice = librarySystem.CategoryTotalPrice();

        foreach (var (category, totalPrice) in categoryTotalPrice.OrderBy(a => a.Item1))
            textWriter.WriteLine($"Category:{category}, Total Price:{totalPrice}");

        textWriter.WriteLine("Category And Author With Count:");
        var categoryAndAuthorWithCount = librarySystem.CategoryAndAuthorWithCount();

        foreach (var (category, author, count) in categoryAndAuthorWithCount.OrderBy(a => a.Item1))
            textWriter.WriteLine($"Category:{category}, Author:{author}, Count:{count}");

        int total = librarySystem.CalculateTotal();
        textWriter.WriteLine($"Total Price: {total}");

        
        
    }
}
