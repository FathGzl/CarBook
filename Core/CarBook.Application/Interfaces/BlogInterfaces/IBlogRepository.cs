using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        List<Blog> GetLast3BlogsWithAuthors();
        List<Blog> GetAllBlogsWithAuthors();
    }
}