using System;
using EcommerceDemo.DataAccess.Repository.IRepository;
using EcommerceDemo.DataAccess.Data;

namespace EcommerceDemo.DataAccess.Repository
{
	public class UnitOfWork:IUnitOfWork
	{
        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
		{
            _db = db;
            Category = new CategoryRepository(_db);
        }

       

        void IUnitOfWork.Save()
        {
            _db.SaveChanges();
        }
    }
}

