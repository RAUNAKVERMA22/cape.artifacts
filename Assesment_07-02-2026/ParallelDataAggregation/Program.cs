using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sales = new List<Sale>
        {
            new Sale("North","Electronics",500,new DateTime(2026,1,1)),
            new Sale("North","Clothing",200,new DateTime(2026,1,1)),
            new Sale("South","Electronics",800,new DateTime(2026,1,2)),
            new Sale("South","Clothing",300,new DateTime(2026,1,2)),
            new Sale("North","Electronics",700,new DateTime(2026,1,3))
        };

        // TOTAL SALES BY REGION
        var totalByRegion = sales
            .AsParallel()
            .GroupBy(s => s.Region)
            .Select(g => new { Region = g.Key, Total = g.Sum(x => x.Amount) })
            .OrderBy(x => x.Region);

        Console.WriteLine("Total Sales by Region");
        foreach (var r in totalByRegion)
            Console.WriteLine($"{r.Region} : {r.Total}");

        // TOP CATEGORY PER REGION
        var topCategory = sales
            .AsParallel()
            .GroupBy(s => new { s.Region, s.Category })
            .Select(g => new { g.Key.Region, g.Key.Category, Total = g.Sum(x => x.Amount) })
            .GroupBy(x => x.Region)
            .Select(g => g.OrderByDescending(x => x.Total).First())
            .OrderBy(x => x.Region);

        Console.WriteLine("\nTop Category per Region");
        foreach (var t in topCategory)
            Console.WriteLine($"{t.Region} → {t.Category}");

        // BEST SALES DAY
        var bestDay = sales
            .AsParallel()
            .GroupBy(s => s.Date.Date)
            .Select(g => new { Date = g.Key, Total = g.Sum(x => x.Amount) })
            .OrderByDescending(x => x.Total)
            .First();

        Console.WriteLine("\nBest Sales Day");
        Console.WriteLine($"{bestDay.Date:d} : {bestDay.Total}");
    }
}