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

        public Category GetCategoryIdByName(string name) => categoryDAO.GetCategoryIdByName(name);

        public List<string> getCategoryNameList() => categoryDAO.getCategoryNameList();

        public bool CreateCategory(Category newCategory) => categoryDAO.CreateCategory(newCategory);

        public bool DeleteCategory(Category category) => categoryDAO.DeleteCategory(category);

        public bool UpdateCategory(Category category) => categoryDAO.UpdateCategory(category);
    }
}
