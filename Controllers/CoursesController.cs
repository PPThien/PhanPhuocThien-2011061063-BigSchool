using PhanPhuocThien_2011061063.Models;
using PhanPhuocThien_2011061063.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhanPhuocThien_2011061063.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public CoursesController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbcontext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}