// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    LinqQueries queries = new LinqQueries();
    printValues(queries.AllCollection());


    void printValues (IEnumerable<Book> BookList) {
        Console.WriteLine("{0, -60}, {1, 7}, {2, 11}\n  ", "Title", "# Pages", "Published Date");
        foreach(var item in BookList) {
            Console.WriteLine("{0, -60}, {1, 7}, {2, 11}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
        }
    }