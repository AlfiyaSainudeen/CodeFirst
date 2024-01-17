using BookServiceAPICodeFirst.Entities;

namespace BookServiceAPICodeFirst.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly MyContext _context;
        public BookRepository()
        {
            _context = new MyContext();
        }
        public void Add(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Book book = _context.Books.Find(id);
            
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetBooksByAuthor(string Author)
        {
            try
            {
               var book= _context.Books.Where(x => x.Author == Author).ToList();
                return _context.
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Book GetBooksByLang(string Lang)
        {
            return _context.Books.Find(Lang);
        }

        public Book GetBooksByYear(int year)
        {
            return _context.Books.Find(year);
        }

        public void Update(Book entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        List<Book> IRepository<Book>.GetBooksByAuthor(string Author)
        {
            try
            {
                var books = _context.Books.Where(x => x.Author == Author);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        List<Book> IRepository<Book>.GetBooksByLang(string Lang)
        {
            try
            {
                var books = _context.Books.Where(x => x.Lang == Lang);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        List<Book> IRepository<Book>.GetBooksByYear(int year)
        {
            try
            {
                var books = _context.Books.Where(x => x.ReleaseDate==year);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
