using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
public class CategoryDAO
{
    private static CategoryDAO instance;
    private static readonly object instanceLock = new object();
    private GameStoreDBContext context = new GameStoreDBContext();
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

    public List<Category> GetAllCategories() => context.Categories.ToList<Category>();
    public Category GetCategoryById(string id) => context.Categories.SingleOrDefault<Category>((c) => c.Id == id);

    public bool CreateCategory(Category newCategory)
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

    public bool DeleteCategory(string id)
    {
        try
        {
            Category deletedCategory = GetCategoryById(id);
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

    public bool UpdateCategory(string id, Category updatedMemberInfo)
    {
        try
        {
            Category updateCategory = GetCategoryById(id);
            if (updateCategory != null)
            {
                context.Categories.Update(updatedMemberInfo);
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
