using BusinessLayer.Services;
using MVC_Example.Dtos;

namespace MVC_Example.Controllers
{
    public class CountryController : BaseCrudController<CountryDto>
    {
        public CountryController(ICrudService<CountryDto> crudService) : base(crudService)
        {
        }
    }
}
