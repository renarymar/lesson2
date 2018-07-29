using System;
namespace Store
{
    /// <summary>
    /// Интерфейс печатных изданий
    /// </summary>
    public interface IBook : IItem
    {
        void SetAutor(Author author);
        void SetGernre(Genre genre);
    }


    public class Author {}
    public class Genre {}
}
