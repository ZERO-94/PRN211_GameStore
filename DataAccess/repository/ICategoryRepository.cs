using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public interface ICategoryRepository
    {
        public List<Category> GetAllCategories();

        public Category GetCategoryById(string id);

        public List<string> getCategoryNameList();

        public bool CreateCategory(Category newCategory);

        public bool DeleteCategory(Category category);

        public bool UpdateCategory(Category category);

        public Category GetCategoryIdByName(string name);
    }
}
