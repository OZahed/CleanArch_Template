using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
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
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepo, IMediatorHandler bus)
        {
            _courseRepository = courseRepo;
            _bus = bus;
        }

        public void CreateCourse(CourseViewModel courseVewModel)
        {
            CreateCourseCommand createCourseCommand = new(
                courseVewModel.Name,
                courseVewModel.Description,
                courseVewModel.ImageUrl
                );

            // send the command on the bus so the handker would recive it and work with it
            _bus.SendCommand(createCourseCommand);
        }

        CourseViewModel ICourseService.GetCourses() => new()
        {
            Courses = _courseRepository.GetCourses()
        };
    }
}
