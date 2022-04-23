using BusinessObject.Models;
using System.Collections.Generic;

namespace DataAccess.repository
{
    public class CategoryRepository
    {
        private CategoryDAO categoryDAO;

        public CategoryRepository()
        {
            categoryDAO = new CategoryDAO();
        }

        public List<Category> GetAllCategories() => categoryDAO.GetAllCategories();

        public Category GetCategoryById(string id) => categoryDAO.GetCategoryById(id);

        public bool CreateCategory(Category newCategory) => categoryDAO.CreateCategory(newCategory);

        public bool DeleteCategory(string id) => categoryDAO.DeleteCategory(id);

        public bool UpdateCategory(Category updatedMemberInfo) => categoryDAO.UpdateCategory(updatedMemberInfo);
    }
}
