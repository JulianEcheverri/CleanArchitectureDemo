using CleanArchitectureDemo.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.MVC.Controllers
{
    //[Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public ActionResult Index()
        {
            return View(_courseService.GetCourses());
        }
    }
}
