using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Abstractions;
using WebShopDemo.Domain;

namespace WebShopDemo.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
