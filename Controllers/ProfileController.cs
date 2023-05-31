using Microsoft.AspNetCore.Mvc;

namespace study_docker.Controllers
{
    [ApiController]
    [Route("/")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        
        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        [HttpGet("hello/{name}")]
        public async Task<IActionResult> Hello([FromRoute] string name)
        {
            return Ok($"Hello {name}");
        }
        
        [HttpGet("students")]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _profileRepository.Get());
        }
        
        [HttpGet("students/{id:int}")]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            return Ok(await _profileRepository.Get(id));
        }
    }
}