using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }


        // Concrete Implementation
        public void Add(Course course)
        {
            _ctx.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses() => _ctx.Courses;
    }
}
