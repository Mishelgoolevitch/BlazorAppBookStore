using BlazorAppBookStore.Models;

namespace BlazorAppBookStore.Services
{
    public class BookReviewService : IBookReviewService
    {
        

        private static readonly List<BooksModel> booksModels = new()
        {
            new BooksModel
            {

                 Id=1,
                Title="Победа",
                Description=" ",
                ImageUrl="images/products/Победа.jpg",
                Review="Победа",
                Price=100,
                RatingStars=4.5,
                PriceCount=85
            },
    new BooksModel        {

                 Id=2,
                Title="Бизнес-Со-Скоростью-Мысли",
                Description=" ",
                ImageUrl="images/products/бизнес-со-скоростью-мысли.jpg",
                Review="Бизнес-Со-Скоростью-Мысли",
                Price=110,
                RatingStars=4.5,
                PriceCount=85
            },
     new BooksModel        {

                 Id=3,
                Title="Практика-Менеджмента",
                Description=" ",
                ImageUrl="images/products/Практика-Менеджмента.jpg",
                Review="Практика-Менеджмента",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },

 new BooksModel        {

                 Id=4,
                Title="21-Минута-в-День-На-Развитие-Лидерства",
                Description=" ",
                ImageUrl="images/products/21-Минута-в-День-На-Развитие-Лидерства.jpg",
                Review="21-Минута-в-День-На-Развитие-Лидерства",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },
 new BooksModel        {

                 Id=5,
                Title="Кто-Взял-Мои-Деньги",
                Description=" ",
                ImageUrl="images/products/Кто-Взял-Мои-Деньги.jpg",
                Review="Кто-Взял-Мои-Деньги",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },
 new BooksModel        {

                 Id=6,
                Title="Магия-Оптимизма",
                Description=" ",
                ImageUrl="images/products/Магия-Оптимизма.jpg",
                Review="Магия-Оптимизма",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },
 new BooksModel        {

                 Id=7,
                Title="Почему-Toyota Лучше",
                Description=" ",
                ImageUrl="images/products/Почему-Toyota Лучше.jpg",
                Review="Почему-Toyota Лучше",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },

 new BooksModel        {

                 Id=8,
                Title="Богатство-От-Ума",
                Description=" ",
                ImageUrl="images/products/Богатство-От-Ума.jpg",
                Review="Богатство-От-Ума",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },
 new BooksModel        {

                 Id=9,
                Title="Програмируемый-Робот",
                Description=" ",
                ImageUrl="images/products/Програмируемый-Робот.jpg",
                Review="Програмируемый-Робот",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            },
  new BooksModel        {

                 Id=10,
                Title="Энциклопедия-Бизнес-Планов",
                Description=" ",
                ImageUrl="images/products/Энциклопедия-Бизнес-Планов.jpg",
                Review="Энциклопедия-Бизнес-Планов",
                Price=210,
                RatingStars=4.5,
                PriceCount=85
            }

      };



        public BooksModel? GetBookById(int id)
        {
            return booksModels.SingleOrDefault(m => m.Id == id);
            //throw new NotImplementedException();
        }

        public List<BooksModel>? GetBooks()
        {
            return booksModels;
            //throw new NotImplementedException();
        }

        
    }
}
