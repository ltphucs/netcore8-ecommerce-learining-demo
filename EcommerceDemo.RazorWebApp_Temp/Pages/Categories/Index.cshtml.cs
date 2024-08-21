using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceDemo.RazorWebApp_Temp.Data;
using EcommerceDemo.RazorWebApp_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcommerceDemo.RazorWebApp_Temp.Pages.Categories
{
	public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
