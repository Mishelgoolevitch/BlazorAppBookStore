using BlazorAppBookStore.Models;

namespace BlazorAppBookStore.Services
{
    public interface IBookReviewService
    {
        List<BooksModel>? GetBooks();
        BooksModel? GetBookById(int id);
    }
}
