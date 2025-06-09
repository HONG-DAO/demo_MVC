using MyStore.Business;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyStore.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync(int currentPage, int pageSize);
        Task<Category?> GetByIdAsync(int id);
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<bool> DeleteAsync(int id);
    }
}