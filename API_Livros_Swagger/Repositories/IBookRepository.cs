using API_Livros_Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Livros_Swagger.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();

        Task<Book> Get(int id);

        Task<Book> Create(Book book);
        Task Update(Book book);

        Task Delete(int id);


    }
}
