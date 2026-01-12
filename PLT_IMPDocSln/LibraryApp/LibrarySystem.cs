using System.Collections.Generic;
using System.Linq;

public class LibrarySystem : ILibrarySystem
{
    private Dictionary<IBook, int> books = new Dictionary<IBook, int>();

    public void AddBook(IBook book, int quantity)
    {
        if (books.ContainsKey(book))
            books[book] += quantity;
        else
            books.Add(book, quantity);
    }

    public void RemoveBook(IBook book, int quantity)
    {
        if (!books.ContainsKey(book)) return;

        books[book] -= quantity;
        if (books[book] <= 0)
            books.Remove(book);
    }

    public int CalculateTotal()
    {
        return books.Sum(b => b.Key.Price * b.Value);
    }

    public List<(string, int, int)> BooksInfo()
    {
        return books
            .Select(b => (b.Key.Title, b.Value, b.Key.Price * b.Value))
            .ToList();
    }

    public List<(string, int)> CategoryTotalPrice()
    {
        return books
            .GroupBy(b => b.Key.Category)
            .Select(g => (g.Key, g.Sum(x => x.Key.Price * x.Value)))
            .ToList();
    }

    public List<(string, string, int)> CategoryAndAuthorWithCount()
    {
        return books
            .GroupBy(b => new { b.Key.Category, b.Key.Author })
            .Select(g => (g.Key.Category, g.Key.Author, g.Sum(x => x.Value)))
            .ToList();
    }
}
