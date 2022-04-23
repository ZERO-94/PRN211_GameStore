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
            return context.Categories.ToList<Category>();
        }
    }
    public Category GetCategoryById(string id)
    {
        using (context = new GameStoreDBContext())
        {
            return context.Categories.SingleOrDefault<Category>((c) => c.Id == id);
        }
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
