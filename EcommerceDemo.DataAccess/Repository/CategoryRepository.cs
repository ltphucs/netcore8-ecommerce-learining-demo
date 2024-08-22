using System;
using EcommerceDemo.DataAccess.Repository.IRepository;
using EcommerceDemo.Models.Models;
using EcommerceDemo.DataAccess.Data;

namespace EcommerceDemo.DataAccess.Repository
{
	public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}

