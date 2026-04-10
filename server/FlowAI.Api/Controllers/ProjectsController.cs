using Microsoft.AspNetCore.Mvc;

namespace FlowAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        var projects = new[]
        {
            new
            {
                Id = 1,
                Name = "FlowAI",
                Description = "AI workflow automation platform"
            },
            new
            {
                Id = 2,
                Name = "Interview Prep Tracker",
                Description = "Tracks study goals and coding progress"
            }
        };

        return Ok(projects);
    }
}