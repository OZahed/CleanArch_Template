using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{

    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepo)
        {
            _courseRepository = courseRepo;
        }

        CourseViewModel ICourseService.GetCourses() => new()
        {
            Courses = _courseRepository.GetCourses()
        };
    }
}
