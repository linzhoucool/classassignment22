using AMCAssignment1.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMCAssignment1.Controllers
{
    public class CourseController : Controller
    {  
  // GET: Course
        private ApplicationDbContext DbContext;
        public CourseController()
        {
            DbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var model = DbContext.Courses.Where(p => p.UserId == userId)
            .Select(p => new IndexCourseViewModel
            {
               Name=p.Name,
               NumberOfEnrollments=p.NumberOfEnrollments,
               NumberOfHours=p.NumberOfHours,
            }).ToList();
            return View(model);
        }
        
        [HttpGet]
        public ActionResult Detail(int? id)
        {
            if (!id.HasValue)
               return RedirectToAction(nameof(CourseController.Index));
            var userId = User.Identity.GetUserId();
            var course = DbContext.Courses.FirstOrDefault(p =>
            p.Id == id.Value);
              if (course == null)
              return RedirectToAction(nameof(CourseController.Index));
            var model = new CourseDetailViewModel();
            model.Name = course.Name;
            model.NumberOfEnrollments = course.NumberOfEnrollments;
            model.NumberOfHours = course.NumberOfHours;
            return View(model);
        }
    }
}