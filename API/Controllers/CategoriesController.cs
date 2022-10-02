using API.Dto;
using AutoMapper;
using Entity.Specifications;

namespace API.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IGenericRepository<Category> _repository;
        public CategoriesController(IGenericRepository<Category> repository, IMapper mapper)
        {
            this.mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CategoriesDto>>> GetCategories()
        {
            var categories = await _repository.ListAllAsync();
            return Ok(this.mapper.Map<IReadOnlyList<Category>, IReadOnlyList<CategoriesDto>>(categories));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var spec = new CategoriesWithCoursesSpecification(id);
            var category = await _repository.GetEntityWithSpec(spec);
            return this.mapper.Map<Category, CategoryDto>(category);
        }
    }
}