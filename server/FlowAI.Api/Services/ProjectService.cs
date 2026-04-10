using FlowAI.Api.Models;

namespace FlowAI.Api.Services;

public class ProjectService : IProjectService
{
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 1,
                Name = "FlowAI",
                Description = "AI workflow automation platform"
            },
            new Project
            {
                Id = 2,
                Name = "Interview Prep Tracker",
                Description = "Tracks study goals and coding progress"
            }
        };
    }
}