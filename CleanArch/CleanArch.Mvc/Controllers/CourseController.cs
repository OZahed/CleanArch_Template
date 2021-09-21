using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {

        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            // course service have been added to dependencies from Infra.IoC
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            
            // we should return model to the view funtion 
            return View(model);
        }
    }
}
