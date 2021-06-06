using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCIntro.Models.Context;
using CoreMVCIntro.Models.Entities;
using CoreMVCIntro.VMClasses;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCIntro.Controllers
{
    public class CategoryController : Controller
    {


        MyContext _db;

        public CategoryController(MyContext db)
        {
            _db = db;
        }






        public IActionResult Index()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList()
            };
            return View(cvm);
        }

        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new CategoryVM
            {
                Category = _db.Categories.Find(id)
            };
            return View(cvm);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            Category toBeUpdated = _db.Categories.Find(category.ID);
            _db.Entry(toBeUpdated).CurrentValues.SetValues(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            _db.Categories.Remove(_db.Categories.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
