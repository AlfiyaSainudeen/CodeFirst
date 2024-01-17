namespace BookServiceAPI.Repositories
{
    public interface IRepository<T> where T : class
    {

        T Get(int id);
        List<T> GetAll();
        List<T> GetBooksByAuthor(string Author);
        List<T> GetBooksByLang(string lang);
        List<T> GetBooksByYear(int year);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
