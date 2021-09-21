using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    interface ICourseRepository
    {
        // prosentation does not about the Course Entity    
        IEnumerable<Course> GetCourses();
    }
}
