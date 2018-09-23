using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext context)
        {
            appDbContext = context;
        }

        public IEnumerable<Category> Categories
            => appDbContext.Categories;
    }
}
