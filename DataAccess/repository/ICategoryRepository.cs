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

        public bool DeleteCategory(string id);

        public bool UpdateCategory(Category updatedMemberInfo);

        public Category GetCategoryIdByName(string name);
    }
}
