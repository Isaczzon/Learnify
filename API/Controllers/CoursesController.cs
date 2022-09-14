using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class CoursesController : BaseController
    {
        private readonly ICourseRepository _repository;
        private readonly IMapper mapper;
        public CoursesController(ICourseRepository repository, IMapper mapper)
        {
            this.mapper = mapper;
            _repository = repository;
        }
        [HttpGet]

        public async Task<ActionResult<List<CourseDto>>> GetCourses()
        {
            var courses = await _repository.GetCoursesAsync();
            return Ok(this.mapper.Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<CourseDto>> GetCourse(Guid id)
        {
            var course = await _repository.GetCourseByIdAsync(id);
            return this.mapper.Map<Course, CourseDto>(course);
        }
    }
}