using EasyCrud.Domain.Dtos;
using EasyCrud.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EasyCrud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private readonly IDeveloperService _developerService;

        public DevelopersController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DeveloperDto developerDto)
        {
            var result = await _developerService.ApplyADeveloper(developerDto);

            if (_developerService.Errors.Count > 0)
                return BadRequest(_developerService.Errors);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] DeveloperDto developerDto)
        {
            await _developerService.UpdateAnApplicant(developerDto);

            if (_developerService.Errors.Count > 0)
                return BadRequest(_developerService.Errors);

            return Ok(developerDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _developerService.RemoveAnApplicant(id);

            if (_developerService.Errors.Count > 0)
                return BadRequest(_developerService.Errors);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _developerService.GetAnApplicant(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _developerService.GetAllApplicants();
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
