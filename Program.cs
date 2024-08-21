// See https://aka.ms/new-console-template for more information

    LinqQueries queries = new LinqQueries();
// printValues(queries.AllCollection());
// printValues(queries.GetBooksAfter2000());
// printValues(queries.AllFieldsHaveStatus());
// Console.WriteLine(queries.AllFieldsHaveStatus());
// Console.WriteLine(queries.SomeBookPublisInAYear(2005));
printValues(queries.GetBooksByCategory("Python"));

void printValues (IEnumerable<Book> BookList) {
        Console.WriteLine("{0, -60}, {1, 7}, {2, 11}\n  ", "Title", "# Pages", "Published Date");
        foreach(var item in BookList) {
            Console.WriteLine(item.ToString());
        }
    }