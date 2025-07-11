using Taskify.DataAccess.IUnitOfWorks;
using Taskify.DataAccess.Models;
using Taskify.Services.DTOs.Responses;
using Taskify.Services.Interfaces;

namespace Taskify.Services.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponse<Project>> CreateProjectAsync(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project), "Project cannot be null");

            try
            {
                _unitOfWork.Repository<Project>().Add(project);
                var result = await _unitOfWork.SaveAsync();

                if (result > 0)
                {
                    return ResponseHelper.Success(project, "Project created successfully.");
                }

                return ResponseHelper.Failure<Project>("Failed to create project.");
            }
            catch (Exception ex)
            {
                return ResponseHelper.Failure<Project>($"An error occurred: {ex.Message}");
            }
        }



        public Task<bool> DeleteProjectAsync(string projectId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Project?> GetProjectByIdAsync(string projectId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<Project?> UpdateProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
