namespace BlazorAppBookStore.Models
{
    public class BooksModel
    {
        public int Id { get; set; }
        public string Review { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double RatingStars { get; set; }
        public int PriceCount { get;set; }
    }
}
