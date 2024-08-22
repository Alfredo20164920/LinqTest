using System.Text.Json;
using System.Linq;
public class LinqQueries {
    private List<Book> booksCollection = new List<Book>();
    public LinqQueries () {
        using(StreamReader reader = new StreamReader("books.json")){
            string json = reader.ReadToEnd();
            this.booksCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true })!;
        }
    }

    public IEnumerable<Book> AllCollection () {
        return booksCollection;
    }

    public IEnumerable<Book> GetBooksAfter2000 () {
        return booksCollection.Where((book) => book.PublishedDate.Year > 2000);
        // return from book in booksCollection where book.PublishedDate.Year > 2000 select book;
    }

    public IEnumerable<Book> GetBooksByPageAndTitle (int pages, string title) {
        return booksCollection.Where((book) =>  book.Title!.Contains(title) && book.PageCount > pages);
    }

    public bool AllFieldsHaveStatus() {
        return booksCollection.All(book => book.Status != string.Empty);
    }

    public bool SomeBookPublisInAYear(int year) {
        return booksCollection.Any(book => book.PublishedDate.Year == year);
    }

    public IEnumerable<Book> GetBooksByCategory(string category) {
        return booksCollection.Where(book => book.Categories != null && book.Categories!.Contains(category));
    }
    
    public IEnumerable<Book> GetBooksByCategoryASCOrder(string category) {
        return booksCollection.Where(book => book.Categories != null && book.Categories!.Contains(category)).OrderBy(b => b.Title);
    }
    public IEnumerable<Book> GetBooksByPagesDescOrder(int pages) {
        return booksCollection.Where(b => b.PageCount > pages).OrderByDescending(b => b.PageCount);
    }

    public IEnumerable<Book> GetThreeRecentBooksByCategory(string category) {
        return booksCollection
            .Where(b => b.Categories!.Contains(category))
            .OrderByDescending(b => b.PublishedDate)
            .Take(3);
    }   

    public IEnumerable<Book> Get3And4BookByPage(int pages) {
        return booksCollection
        .Where(b => b.PageCount > pages)
        .OrderByDescending(b => b.PageCount)
        .Take(4)
        .Skip(2);
    }

    public IEnumerable<ItemBook> SelectColumns() {
        return booksCollection.Take(3).Select(b => new ItemBook() {Title = b.Title, PageCount = b.PageCount});
    }

    public int CountBooksByPages(int min, int max) {
        return booksCollection.Where(b => b.PageCount > min && b.PageCount < max).Count();
    }

    public DateTime GetLastPublishedBook() {
        return booksCollection.Min(b => b.PublishedDate);
    }

    public int GetBookWithMaxNumberOfPages() {
        return booksCollection.Max(b => b.PageCount);
    }

    public Book? GetBookWithPagesGraterThan(int pages) {
        return booksCollection.Where(b => b.PageCount > 0).MinBy(b => b.PageCount);
    }

    public Book? GetLastPublishedBookWithMaxBy() {
        return booksCollection.MaxBy(b => b.PublishedDate);
    }

    public int TotalPagesWithRange(int min, int max) {
        return booksCollection.Where(b => b.PageCount > min && b.PageCount < max).Sum(b => b.PageCount);
    }

    public string GetTitleOfBooksBeforeADate(int year) {
        return booksCollection.Where(b => b.PublishedDate.Year > year)
            .Aggregate("", (bookTitle, next) => {
                if(bookTitle != string.Empty) bookTitle += " - " + next.Title;
                else bookTitle += next.Title;

                return bookTitle;
            } );
    }
}