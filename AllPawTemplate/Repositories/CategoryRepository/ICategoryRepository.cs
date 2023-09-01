using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategoryAsync();
        Task<Category> GetCategoryByAdvertIdAsync(int categoryId);
    }
}
