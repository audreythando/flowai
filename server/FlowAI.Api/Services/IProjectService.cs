using FlowAI.Api.Models;

namespace FlowAI.Api.Services;

public interface IProjectService
{
    List<Project> GetProjects();
}