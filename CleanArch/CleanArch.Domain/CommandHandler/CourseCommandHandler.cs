using CleanArch.Domain.Commands;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandler
{
    // Handles All types of Course Comamnds
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;
        public CourseCommandHandler(ICourseRepository repository)
        {
            _courseRepository = repository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            Course course = new()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            // bussiness Logic Goes Here 
            // Add to repo, Send Email, Notify the users and so on...
            _courseRepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
