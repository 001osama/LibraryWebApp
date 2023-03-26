using MovieWeb.DataAccess.Repository.IRepository;
using MovieWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWeb.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db)
        {
            _db= db;
        }
    

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
