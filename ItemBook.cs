public class ItemBook {
    public string? Title {get; set;}
    public int PageCount {get; set;}

    public override string ToString() {
        return string.Format(
            "{0, -60}, {1, 7}", 
            this.Title, 
            this.PageCount
        );
    }
}