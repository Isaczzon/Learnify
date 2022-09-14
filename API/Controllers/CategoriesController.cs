using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper mapper;
        public CategoriesController(ICategoryRepository repository, IMapper mapper)
        {
            this.mapper = mapper;
            _repository = repository;
        }
        [HttpGet]

        public async Task<ActionResult<IReadOnlyList<CategoriesDto>>> GetCategories()
        {
            var categories = await _repository.GetCategoriesAsync();
            return Ok(this.mapper.Map<IReadOnlyList<Category>, IReadOnlyList<CategoriesDto>>(categories));
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var category = await _repository.GetCategoriesByIdAsync(id);
            return this.mapper.Map<Category, CategoryDto>(category);
        }
    }
}