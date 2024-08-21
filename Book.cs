public class Book {
    public string? Title {get; set;}
    public int PageCount {get; set;}
    public DateTime PublishedDate {get; set;}
    public string? ThumbnailUrl {get; set;}
    public string? Status {get; set;}
    public string[]? Authors {get; set;}
    public string[]? Categories {get; set;}

    public override string ToString() {
        return string.Format(
            "{0, -60}, {1, 7}, {2, 11}", 
            this.Title, 
            this.PageCount, 
            this.PublishedDate.ToShortDateString()
        );
    }
}