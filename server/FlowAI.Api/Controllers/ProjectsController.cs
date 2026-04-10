using Microsoft.AspNetCore.Mvc;
using FlowAI.Api.Dtos;
using FlowAI.Api.Services;

namespace FlowAI.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var projects = _projectService.GetProjects();

        var result = projects.Select(project => new ProjectDto
        {
            Id = project.Id,
            Name = project.Name.ToUpper()
        });

        return Ok(result);
    }
}