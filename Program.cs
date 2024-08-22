// See https://aka.ms/new-console-template for more information

    LinqQueries queries = new LinqQueries();
// printValues(queries.AllCollection());
// printValues(queries.GetBooksAfter2000());
// printValues(queries.AllFieldsHaveStatus());
// Console.WriteLine(queries.AllFieldsHaveStatus());
// Console.WriteLine(queries.SomeBookPublisInAYear(2005));
// printValues(queries.GetBooksByCategory("Python"));
// printValues(queries.GetBooksByCategoryASCOrder("Java"));
// printValues(queries.GetBooksByPagesDescOrder(450));
// printValues(queries.GetThreeRecentBooksByCategory("Java"));
// printValues(queries.Get3And4BookByPage(400));
// printValues2(queries.SelectColumns());
// System.Console.WriteLine(queries.CountBooksByPages(200, 500));
// Console.WriteLine(queries.GetLastPublishedBook());
// Console.WriteLine(queries.GetBookWithMaxNumberOfPages());
// printValue(queries.GetBookWithPagesGraterThan(0)!);
// printValue(queries.GetLastPublishedBookWithMaxBy()!);
// System.Console.WriteLine(queries.TotalPagesWithRange(0, 500));
// System.Console.WriteLine(queries.GetTitleOfBooksBeforeADate(2005));
// System.Console.WriteLine(queries.GetAvarageTitleCharacters());
System.Console.WriteLine(queries.GetAvaragePages());

// void printValues (IEnumerable<Book> BookList) {
//         Console.WriteLine("{0, -60}, {1, 7}, {2, 11}\n  ", "Title", "# Pages", "Published Date");
//         foreach(var item in BookList) {
//             Console.WriteLine(item.ToString());
//         }
//     }

// void printValue (Book book) {
//     Console.WriteLine("{0, -60}, {1, 7}, {2, 11}\n  ", "Title", "# Pages", "Published Date");
//     Console.WriteLine(book.ToString());
// }

// void printValues2 (IEnumerable<ItemBook> BookList) {
//         Console.WriteLine("{0, -60}, {1, 7}\n  ", "Title", "# Pages");
//         foreach(var item in BookList) {
//             Console.WriteLine(item.ToString());
//         }
//     }