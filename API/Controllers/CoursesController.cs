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
        private readonly IMapper mapper;
        private readonly IGenericRepository<Course> _repository;
        public CoursesController(IGenericRepository<Course> repository, IMapper mapper)
        {
            _repository = repository;
            this.mapper = mapper;
        }
        [HttpGet]

        public async Task<ActionResult<List<CourseDto>>> GetCourses()
        {
            var courses = await _repository.ListAllAsync();
            return Ok(this.mapper.Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<CourseDto>> GetCourse(Guid id)
        {
            var course = await _repository.GetByIdAsync(id);
            return this.mapper.Map<Course, CourseDto>(course);
        }
    }
}