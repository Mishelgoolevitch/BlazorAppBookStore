namespace BlazorAppBookStore.Models
{
  

        public class Cart
        {
            private readonly List<BooksModel> _items = new();

            // Добавление книги в корзину
            public void Add(BooksModel book)
            {
                if (book != null)
                {
                    _items.Add(book);
                }
            }
        // Очистка корзины (функция для возможности сброса корзины)
        public void Clear()
        {
            _items.Clear();
        }


        // Удаление книги из корзины по Id
        public void Delete(int id)
            {
                var itemToRemove = _items.SingleOrDefault(b => b.Id == id);
                if (itemToRemove != null)
                {
                    _items.Remove(itemToRemove);
                }
            }

            // Обновление существующей книги в корзине
            public void Update(BooksModel updatedBook)
            {
                var itemToUpdate = _items.SingleOrDefault(b => b.Id == updatedBook.Id);
                if (itemToUpdate != null)
                {
                    itemToUpdate.Title = updatedBook.Title;
                    itemToUpdate.Description = updatedBook.Description;
                    itemToUpdate.ImageUrl = updatedBook.ImageUrl;
                    itemToUpdate.Price = updatedBook.Price;
                    itemToUpdate.RatingStars = updatedBook.RatingStars;
                    itemToUpdate.PriceCount = updatedBook.PriceCount;
                    itemToUpdate.Review = updatedBook.Review;  // Обновление отзыва
                }
            }

            // Загрузка текущих товаров в корзине
            public List<BooksModel> Load()
            {
                return _items;
            }
        }
    }

