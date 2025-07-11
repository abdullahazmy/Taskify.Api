using Taskify.DataAccess.Models;
using Taskify.Services.DTOs.Responses;

namespace Taskify.Services.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjectsAsync();
        Task<Project?> GetProjectByIdAsync(string projectId);

        Task<GenericResponse<Project>> CreateProjectAsync(Project project);

        Task<Project?> UpdateProjectAsync(Project project);

        Task<bool> DeleteProjectAsync(string projectId);

        Task<IEnumerable<Project>> GetProjectsByUserIdAsync(string userId);

    }
}
