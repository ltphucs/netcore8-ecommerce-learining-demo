using System;
using EcommerceDemo.Models.Models;

namespace EcommerceDemo.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository:IRepository<Category>
	{
        void Update(Category obj);
    }
}

