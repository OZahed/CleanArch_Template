using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private readonly IMapper _autoMapper;

        public CourseService( ICourseRepository courseRepo, 
            IMediatorHandler bus,
            IMapper autoMapper)
        {
            _courseRepository = courseRepo;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void CreateCourse(CourseViewModel courseVewModel)
        {
            
            // send the command on the bus so the handker would recive it and work with it
            _bus.SendCommand(_autoMapper.Map<CreateCourseCommand>(courseVewModel));
        }

        IEnumerable<CourseViewModel> ICourseService.GetCourses() => 
            _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
    }
}
