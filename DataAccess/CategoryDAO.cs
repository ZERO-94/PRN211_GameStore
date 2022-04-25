
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class CategoryDAO
{
    private static CategoryDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context;
    public CategoryDAO()
    {
    }
    public static CategoryDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }

                return instance;
            }

        }
    }

    public List<Category> GetAllCategories()
    {
        using (context = new GameStoreDBContext())
        {
            return context.Categories.ToList();
        }
    }
    public Category GetCategoryById(string id)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Categories.SingleOrDefault<Category>((c) => c.Id == id);
        }
    }

    public Category GetCategoryIdByName(string name)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Categories.SingleOrDefault<Category>((c) => c.Name == name);
        }
    }

    public List<string> getCategoryNameList()
    {
        var categoryList = GetAllCategories();
        List<string> categoryNameList = new List<string>();
        foreach (Category c in categoryList)
        {
            categoryNameList.Add(c.Name);
        }
        return categoryNameList;
    }

    public bool CreateCategory(Category newCategory)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }

    public bool DeleteCategory(string id)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                Category deletedCategory = context.Categories.SingleOrDefault<Category>((c) => c.Id == id);
                if (deletedCategory != null)
                {
                    context.Categories.Remove(deletedCategory);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }

    }

    public bool UpdateCategory(Category updatedMemberInfo)
    {
        using (context = new GameStoreDBContext())
        {
            try
            {
                context.Categories.Update(updatedMemberInfo);
                context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            catch (DbUpdateException ex)
            {
                return false;
            }
        }
    }
}
