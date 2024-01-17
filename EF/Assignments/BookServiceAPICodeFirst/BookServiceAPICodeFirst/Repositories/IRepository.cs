namespace BookServiceAPICodeFirst.Repositories
{
    public interface IRepository<T> where T : class
    {

        List<T> GetBooksByAuthor(string Author);
        List<T> GetBooksByLang(string Lang);
       List< T > GetBooksByYear(int year);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
